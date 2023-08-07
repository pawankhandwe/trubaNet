﻿using System.ComponentModel.DataAnnotations;

namespace Identity_App.ViewModel
{
    public class Login
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType (DataType.Password)]
        public string Password { get; set; }
        public Boolean RememberMe { get; set; }
    }
}
