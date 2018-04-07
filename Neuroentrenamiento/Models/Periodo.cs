using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Neuroentrenamiento.Models
{
    public class Periodo
    {
        public int Id { get; set; }

        public int Dia { get; set; }
        public int Semana { get; set; }

        public virtual List<PruebaPeriodo> PruebaPeriodos { get; set; }
    }
}
