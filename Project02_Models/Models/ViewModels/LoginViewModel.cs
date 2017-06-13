using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Project02_Models.Models.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [StringLength(10, MinimumLength =3, ErrorMessage =  "ERROR!!!!")]
        //[Display(Name ="Enter username")]
        [Display(Name = "UsernameText", ResourceType = typeof(Project02_Models.Resources.Models.LoginViewModel))]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]

        public string Password { get; set; }

        [Display(Name = "Remember me!!!")]

        public bool Remember { get; set; }
    }
}