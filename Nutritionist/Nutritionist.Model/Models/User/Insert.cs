﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Nutritionist.Core.Models.User
{
    public class Insert
    {

        [Required(ErrorMessage = "Username is required")]
        [StringLength(24, ErrorMessage = "Must be between 8 and 24 characters", MinimumLength = 8)]

        public string Username { get; set; }

        [Required(ErrorMessage = "FirstName is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "SecondName is required")]
        public string SecondName { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(24, ErrorMessage = "Must be between 8 and 24 characters", MinimumLength = 8)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm Password is required")]
        [StringLength(24, ErrorMessage = "Must be between 8 and 24 characters", MinimumLength = 8)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

    }
}
