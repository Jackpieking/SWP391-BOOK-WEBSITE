using System.ComponentModel.DataAnnotations;

namespace DTO.Incoming;

public class UserLoginDto
{
    [Required]
    public string Username { get; set; }

    [Required]
    public string Password { get; set; }

    [Required]
    public bool RememberMe { get; set; }
}
