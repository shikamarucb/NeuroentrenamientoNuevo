using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Neuroentrenamiento.Models.AccountViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [StringLength(100)]
        [Display(Name="Nombre")]
        public string Name { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Apellido")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Edad")]
        public int Age { get; set; }

        [Required]
        [Display(Name="Sexo")]
        public string Sex { get; set; }

        [Required]
        [Display(Name ="Curso")]
        public string Grade { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmar Contraseña")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
}
