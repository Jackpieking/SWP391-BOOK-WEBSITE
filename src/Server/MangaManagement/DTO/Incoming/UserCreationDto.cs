﻿namespace DTO.Incoming;

public class UserCreationDto
{
    public string Username { get; set; }

    public string Password { get; set; }

    public string ConfirmPassword { get; set; }

    public string UserEmail { get; set; }
}
