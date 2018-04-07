using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Neuroentrenamiento.Models
{
    public class Resultado
    {

        public int Id_PruebaPeriodo { get; set; }
        [ForeignKey("Id_PruebaPeriodo")]
        public virtual PruebaPeriodo PruebaPeriodo { get; set; }

        public string Id_ApplicationUser { get; set; }
        [ForeignKey("Id_ApplicationUser")]
        public virtual ApplicationUser ApplicationUser { get; set; }

        public int Puntaje { get; set; }

        public DateTime Tiempo { get; set; }
    }
}
