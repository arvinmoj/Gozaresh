using System;
using System.ComponentModel.DataAnnotations;

namespace My_Application.Models
{
    public class RegisterViewModel
    {
        public RegisterViewModel() : base()
        {

        }


        [Display(Name = "Name")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Enter Your Name")]
        public string Name { get; set; }

        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Enter Email")]
        public string Email { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Username")]
        [Required(ErrorMessage = "Enter Username")]
        public string Username { get; set; }

        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Enter Password")]
        public string Password { get; set; }

        [Display(Name = "RePassword")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Enter RePassword")]
        [Compare("Password")]
        public string RePassword { get; set; }
    }

    public class LoginViewModel
    {


        [DataType(DataType.Text)]
        [Display(Name = "Username")]
        [Required(ErrorMessage = "Enter Username")]
        public string Username { get; set; }

        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Enter Password")]
        public string Password { get; set; }

    }
}