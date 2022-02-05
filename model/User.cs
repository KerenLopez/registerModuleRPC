using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace registerModuleRPC.model
{
    public class User
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "User name is required")]
        [StringLength(20,MinimumLength = 4)]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(20,MinimumLength = 7)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm Password is required")]
        [StringLength(20, MinimumLength = 7)]
        [Compare("Password", ErrorMessage = "Password and Confirmation Password must match.")]
        public string ConfirmPwd { get; set; }

        [Required(ErrorMessage = "First name is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "last name is required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Birthdate is required")]
        [Display(Name = "BirthDate")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
    }
}
