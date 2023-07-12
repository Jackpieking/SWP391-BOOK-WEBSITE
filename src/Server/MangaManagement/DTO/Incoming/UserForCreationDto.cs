﻿using System;
using System.ComponentModel.DataAnnotations;

namespace DTO.Incoming;

public class UserForCreationDto
{
    [Required(ErrorMessage = "Please enter the Username")]
    [MinLength(length: 3, ErrorMessage = "Length must be at least 3 letters !!")]
    public string Username { get; set; }

    [Required(ErrorMessage = "Please enter the password")]
    [RegularExpression(pattern: "^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)[a-zA-Z\\d]{3,}$", ErrorMessage = "Please enter password with at least three characters, at least one uppercase letter, one lowercase letter and one number !!")]
    public string Password { get; set; }

    [RegularExpression(pattern: "^[a-zA-Z_ÀÁÂÃÈÉÊẾÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêếìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂưăạảấầẩẫậắằẳẵặẹẻẽềềểỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễệỉịọỏốồổỗộớờởỡợụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ\\ ]{2,}$", ErrorMessage = "Please enter user fullname with at least 2 letter !!")]
    public string UserFullName { get; set; }

    public int UserGender { get; set; }

    public DateOnly UserBirthday { get; set; }

    [RegularExpression(pattern: "^[0][1-9][0-9][0-9]{7,7}$", ErrorMessage = "Please enter phone number with at least 10 and start with 0 !!")]
    public string UserPhoneNumber { get; set; }

    [Required(ErrorMessage = "Please enter the email")]
    public string UserEmail { get; set; }

    [Required(ErrorMessage = "Please enter the user account balance")]
    public int UserAccountBalance { get; set; }
}
