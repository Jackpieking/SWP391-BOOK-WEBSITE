﻿using DTO.Incoming;
using MangaManagementAPI.Options;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Model;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net.Mime;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace MangaManagementAPI.Controllers;

[Consumes(contentType: MediaTypeNames.Application.Json)]
[Produces(contentType: MediaTypeNames.Application.Json)]
[Route(template: "api/[controller]")]
[ApiController]
public class AuthController : ControllerBase
{
	private readonly UserManager<IdentityUser> _userManager;
	private readonly JwtConfig _jwtConfig;

	public AuthController(
		UserManager<IdentityUser> userManager,
		IOptions<JwtConfig> jwtConfig)
	{
		_userManager = userManager;
		_jwtConfig = jwtConfig.Value;
	}

	[HttpPost("register")]
	public async Task<IActionResult> RegisterAsync([FromBody] UserRegistrationRequestDto requestDto)
	{
		var foundUser = await _userManager.FindByEmailAsync(requestDto.Email);

		IdentityUser new_user = new()
		{
			Email = requestDto.Email,
			UserName = requestDto.Name,
		};

		var result = await _userManager.CreateAsync(user: new_user, password: requestDto.Password);

		if (!result.Succeeded)
		{
			return BadRequest(new AuthResult()
			{
				Result = false,
				Errors = new List<string>()
				{
					"Server error: cannot create user"
				}
			});
		}

		var emailConfirmToken = await _userManager.GenerateEmailConfirmationTokenAsync(new_user);
		var encodedEmailConfirmToken = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(emailConfirmToken));

		var jwt = GenerateJwtToken(new_user, false, false, encodedEmailConfirmToken);

		return Ok(new AuthResult()
		{
			Result = true,
			Token = jwt
		});
	}

	[HttpPost("login")]
	public async Task<IActionResult> LoginAsync([FromBody] UserLoginDto requestDto)
	{
		var foundUser = await _userManager.FindByNameAsync(requestDto.Username);

		if (Equals(foundUser, null))
		{
			return BadRequest(new AuthResult()
			{
				Result = false,
				Errors = new List<string>()
				{
					"Invalid payload"
				}
			});
		}

		var result = await _userManager.CheckPasswordAsync(user: foundUser, password: requestDto.Password);

		if (!result)
		{
			return BadRequest(new AuthResult()
			{
				Result = false,
				Errors = new List<string>()
				{
					"Invalid credentials"
				}
			});
		}

		if (!await _userManager.IsEmailConfirmedAsync(foundUser))
		{
			return UnprocessableEntity(new AuthResult()
			{
				Result = false,
				Errors = new List<string>()
				{
					"Email is not confirm"
				}
			});
		}

		var jwt = GenerateJwtToken(foundUser, requestDto.RememberMe, true);

		return Ok(new AuthResult()
		{
			Result = true,
			Token = jwt
		});
	}

	[HttpPost("validate-email")]
	public async Task<IActionResult> CheckIfEmailIsExisted([FromBody] string email)
	{
		var foundUser = await _userManager.FindByEmailAsync(email: email);

		if (!Equals(foundUser, null))
		{
			return BadRequest(new AuthResult()
			{
				Result = false,
				Errors = new List<string>()
				{
					"Email is existed"
				}
			});
		}

		return Ok(new AuthResult()
		{
			Result = true
		});
	}

	[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
	[HttpGet("validate")]
	public IActionResult ValidateTokenAsync([FromHeader] string authorization)
	{
		var jwt = authorization.Split(" ")[1];

		if (!CheckTokenIsValid(token: jwt))
		{
			return Forbid();
		}

		return Accepted("User credentials are still valid and not expired");
	}

	[HttpGet("confirm-email/{userId}/{encodedEmailConfirmToken}")]
	public async Task<IActionResult> ConfirmEmail(
		[FromRoute] string userId,
		[FromRoute] string encodedEmailConfirmToken)
	{
		var emailConfirmationToken = Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(encodedEmailConfirmToken));

		if (Equals(userId, null) || Equals(emailConfirmationToken, null))
		{
			return BadRequest(new AuthResult()
			{
				Result = false,
				Errors = new List<string>()
				{
					"Server cannot process this information"
				}
			});
		}

		var foundUser = await _userManager.FindByIdAsync(userId);

		if (Equals(foundUser, null))
		{
			return BadRequest(new AuthResult()
			{
				Result = false,
				Errors = new List<string>()
					{
						"Invalid payload"
					}
			});
		}

		if (await _userManager.IsEmailConfirmedAsync(foundUser))
		{
			return UnprocessableEntity(new AuthResult()
			{
				Result = false,
				Errors = new List<string>()
				{
					"Email is already confirmed"
				}
			});
		}

		await _userManager.ConfirmEmailAsync(foundUser, emailConfirmationToken);

		return Ok();
	}


	private string GenerateJwtToken(
		IdentityUser user,
		bool isPersistance,
		bool isEmailConfirmed)
	{
		SecurityTokenDescriptor tokenDescriptor = new()
		{
			Audience = _jwtConfig.Audience,
			Issuer = _jwtConfig.Issuer,
			Subject = new(new List<Claim>()
			{
				new(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
				new(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
				new(JwtRegisteredClaimNames.Sub, user.Id),
				new(JwtRegisteredClaimNames.Name, user.UserName),
				new(JwtRegisteredClaimNames.Email, user.Email),
				new("email-cfr", isEmailConfirmed.ToString())
			}),
			SigningCredentials = new(
		new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtConfig.PrivateKey)),
		SecurityAlgorithms.HmacSha256)
		};

		if (isPersistance)
		{
			tokenDescriptor.Expires = DateTime.UtcNow.AddDays(7);
		}
		else
		{
			tokenDescriptor.Expires = DateTime.UtcNow.AddDays(1);
		}

		JwtSecurityTokenHandler jwtTokenHandler = new();

		var token = jwtTokenHandler.CreateToken(tokenDescriptor);

		return jwtTokenHandler.WriteToken(token);
	}

	private string GenerateJwtToken(
		IdentityUser user,
		bool isPersistance,
		bool isEmailConfirmed,
		string emailConfirmToken)
	{
		SecurityTokenDescriptor tokenDescriptor = new()
		{
			Audience = _jwtConfig.Audience,
			Issuer = _jwtConfig.Issuer,
			Subject = new(new List<Claim>()
			{
				new(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
				new(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
				new(JwtRegisteredClaimNames.Sub, user.Id),
				new(JwtRegisteredClaimNames.Name, user.UserName),
				new(JwtRegisteredClaimNames.Email, user.Email),
				new("email-cfr", isEmailConfirmed.ToString()),
				new("email-cfr-tk", emailConfirmToken)
			}),
			SigningCredentials = new(
		new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtConfig.PrivateKey)),
		SecurityAlgorithms.HmacSha256)
		};

		if (isPersistance)
		{
			tokenDescriptor.Expires = DateTime.UtcNow.AddDays(7);
		}
		else
		{
			tokenDescriptor.Expires = DateTime.UtcNow.AddDays(1);
		}

		JwtSecurityTokenHandler jwtTokenHandler = new();

		var token = jwtTokenHandler.CreateToken(tokenDescriptor);

		return jwtTokenHandler.WriteToken(token);
	}

	private long GetTokenExpirationTime(string token)
	{
		JwtSecurityTokenHandler handler = new();

		var jwtSecurityToken = handler.ReadJwtToken(token);

		var tokenExp = jwtSecurityToken.Claims.First(claim => claim.Type.Equals(JwtRegisteredClaimNames.Exp)).Value;

		var ticks = long.Parse(tokenExp);

		return ticks;
	}

	private bool CheckTokenIsValid(string token)
	{
		var tokenTicks = GetTokenExpirationTime(token);

		var tokenDate = DateTimeOffset.FromUnixTimeSeconds(tokenTicks).UtcDateTime;

		var now = DateTime.UtcNow.ToUniversalTime();

		var valid = tokenDate >= now;

		return valid;
	}

	private string GetNameClaim(string token)
	{
		JwtSecurityTokenHandler handler = new();

		var jwtSecurityToken = handler.ReadJwtToken(token);

		var nameClaim = jwtSecurityToken.Claims.First(claim => claim.Type.Equals(JwtRegisteredClaimNames.Name)).Value;

		return nameClaim;
	}
}