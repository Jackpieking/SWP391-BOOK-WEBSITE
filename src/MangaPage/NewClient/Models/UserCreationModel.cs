﻿using System.ComponentModel.DataAnnotations;

namespace NewClient.Models;

public class UserCreationModel
{
    [Required(ErrorMessage = "Vui lòng nhập tài khoản")]
    [MinLength(length: 3, ErrorMessage = "Tên phải dài ít nhất 3 ký tự !!")]
    public string Username { get; set; }

    [Required(ErrorMessage = "Vui lòng nhập mật khẩu")]
    [RegularExpression(pattern: "^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)[a-zA-Z\\d]{3,}$", ErrorMessage = "Vui lòng nhập mật khẩu với its nhất 3 ký tự, ít nhất 1 chữ cái in hoa, 1 chữ cái in thường !!")]
    [DataType(DataType.Password)]
    public string Password { get; set; }

    [Required(ErrorMessage = "Vui lòng nhập mật khẩu")]
    [RegularExpression(pattern: "^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)[a-zA-Z\\d]{3,}$", ErrorMessage = "Vui lòng nhập mật khẩu với its nhất 3 ký tự, ít nhất 1 chữ cái in hoa, 1 chữ cái in thường !!")]
    [DataType(DataType.Password)]
    [Compare("Password", ErrorMessage = "Mật khẩu không giống !!")]
    public string ConfirmPassword { get; set; }

    [Required(ErrorMessage = "Vui lòng nhập email")]
    [DataType(DataType.EmailAddress)]
    public string UserEmail { get; set; }
}
