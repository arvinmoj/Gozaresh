using System;
using System.ComponentModel.DataAnnotations;

namespace My_Application.Models
{
    public class Users
    {
        public Users() : base()
        {
            Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }

        [Display(Name = "Name")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Enter Your Name")]
        [StringLength(maximumLength: 50, MinimumLength = 5,
                      ErrorMessage = "Name should be minimum 5 characters and a maximum of 50 characters")]
        public string Name { get; set; }

        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Enter Email")]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Please enter correct email")]
        public string Email { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Username")]
        [Required(ErrorMessage = "Enter Username")]
        [StringLength(maximumLength: 50, MinimumLength = 5,
                      ErrorMessage = "Username should be minimum 5 characters and a maximum of 50 characters")]
        public string Username { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        [Required(ErrorMessage = "Enter Password")]
        [RegularExpression(@"^((?=.*[a-z])(?=.*[A-Z])(?=.*\d)).+$")]
        [StringLength(maximumLength: 50, MinimumLength = 8,
                      ErrorMessage = "Username should be minimum 8 characters and a maximum of 50 characters")]
        public string Password { get; set; }


    }
}