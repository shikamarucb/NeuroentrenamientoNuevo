using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Neuroentrenamiento.Models.AccountViewModels
{
    public class ContactViewModel
    {
        [Required]
        [Display(Name ="Nombre")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Correo Electrónico")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Asunto")]
        public string Subject { get; set; }

        [Required]
        [Display(Name = "Mensaje")]
        public string Message { get; set; }
    }
}
