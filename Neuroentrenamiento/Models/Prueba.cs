using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Neuroentrenamiento.Models
{
    public class Prueba
    {

        public int Id { get; set; }

        [StringLength(20)]
        public string Tipo { get; set; }

        public virtual List<PruebaPeriodo> PruebaPeriodos { get; set; }
    }
}
