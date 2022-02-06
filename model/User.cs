
using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace registerModuleRPC.model
{
    public class User
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "User name is required")]
       // [UserExist]
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

   /* public class UserExistAttribute : ValidationAttribute
    {
        private readonly registerModuleRPC.Data.registerModuleRPCContext2 _context;

        public UserExistAttribute(registerModuleRPC.Data.registerModuleRPCContext2 context)
        {
            _context = context;
        }

        [BindProperty]
        public User User { get; set; }

        protected override ValidationResult? IsValid(object value, ValidationContext validationContext)
        {
            string userN=(string)value;
            foreach (var user in _context.User) {

                if (user.UserName == userN)
                {
                    return new ValidationResult("El nombre de usuario ya existe");
                }

            }
            return ValidationResult.Success;
        }
    }*/
}
