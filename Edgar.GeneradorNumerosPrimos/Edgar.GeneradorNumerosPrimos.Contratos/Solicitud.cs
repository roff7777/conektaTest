using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edgar.GeneradorNumerosPrimos.Contratos
{
    public class Solicitud
    {
        public int Inicial { get; set; }
        public int Final { get; set; }
        public int CantidadGenerada { get; set; }
        public int[] Primos { get; set; }
    }
}
