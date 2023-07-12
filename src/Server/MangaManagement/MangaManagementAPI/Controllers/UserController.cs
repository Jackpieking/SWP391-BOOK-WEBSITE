using BusinessLogicLayer.Services;
using Helper.DefinedEnums;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Model;
using Npgsql;
using System;
using System.Net.Mime;
using System.Threading.Tasks;

namespace MangaManagementAPI.Controllers;

[Produces(contentType: MediaTypeNames.Application.Json)]
[Route(template: "api/[controller]")]
public class UserController : Controller
{
    private readonly UserManagementService _userManagementService;
    private readonly ILogger<UserController> _logger;

    public UserController(UserManagementService userManagementService, ILogger<UserController> logger)
    {
        _userManagementService = userManagementService;
        _logger = logger;
    }

    [HttpPost]
    public async Task<IActionResult> CreatedAUserAsync(IFormCollection formcollection)
    {
        try
        {
            //check for existing user by username
            if (await _userManagementService
                .CheckIfUserIsExistedByUsernameAsync(formcollection["Username"]))
            {
                return UnprocessableEntity();
            }

            var getGenderFunc = (int value) => value switch
            {
                (int)DefinedGender.MALE => DefinedGender.MALE,
                (int)DefinedGender.FEMALE => DefinedGender.FEMALE,
                _ => DefinedGender.OTHERS
            };

            //construct a new user
            UserModel userModel = new()
            {
                UserIdentifier = Guid.NewGuid(),
                Username = formcollection["Username"],
                Password = formcollection["Password"],
                UserFullName = formcollection["UserFullName"],
                UserGender = getGenderFunc(arg: int.Parse(s: formcollection["UserGender"])),
                UserBirthday = Equals(objA: formcollection["UserBirthday"], objB: null)
                    ? DateOnly.Parse(s: formcollection["UserBirthday"])
                    : DateOnly.MinValue,
                UserPhoneNumber = formcollection["UserPhoneNumber"],
                UserEmail = formcollection["UserEmail"],
                UserAccountBalance = int.Parse(s: formcollection["UserAccountBalance"]),
                UserAvatar = string.Empty,
            };

            await _userManagementService.AddOneUserToDatabaseAsync(userModel: userModel);

            return Ok();
        }
        catch (NpgsqlException N_e)
        {
            _logger.LogError(message: $"[{DateTime.Now}]: Error: {N_e.Message}");

            return StatusCode(statusCode: StatusCodes.Status500InternalServerError);
        }
    }
}
