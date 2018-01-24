using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WowForum.Models
{
        public class NewUserModel
        {
            [Required]
            public string Username { get; set; }

            [Required]
            [EmailAddress(ErrorMessage = "Please enter a valid email")]
            public string Email { get; set; }

            [Required]
            public string Password { get; set; }


            [Required]
            [Compare("Password")]
            public string ConfirmPassword { get; set; }
        }
}