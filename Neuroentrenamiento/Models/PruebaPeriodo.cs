using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Neuroentrenamiento.Models
{
    public class PruebaPeriodo
    {
        public int Id { get; set; }

        public virtual List<Resultado> Resultados { get; set; }

        public int Id_Periodo { get; set; }
        [ForeignKey("Id_Periodo")]
        public virtual Periodo Periodo { get; set; }

        public int Id_Prueba { get; set; }
        [ForeignKey("Id_Prueba")]
        public virtual Prueba Prueba { get; set; }
    }
}
