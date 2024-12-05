﻿using System.ComponentModel.DataAnnotations;

namespace AonFreelancing.Models.Requests
{
    public class LoginRequest
    {
        //[Required, StringLength(14, ErrorMessage = "Invalid Phone Number, should be 14 digit starts with country code")] 
        //string PhoneNumber,
        [Required]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }
        [Required]
        [MinLength(6, ErrorMessage = "too short password")]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[#$^+=!*()@%&]).{6,}$", ErrorMessage = "Password must be at least 6 characters long, contains at least one uppercase letter, one lowercase letter, one number, and one special character (#$^+=!*()@%&).")]
        public string Password { get; set; }
    }
}
