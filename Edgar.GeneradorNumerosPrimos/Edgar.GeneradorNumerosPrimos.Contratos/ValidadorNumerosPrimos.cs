using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edgar.GeneradorNumerosPrimos.Contratos
{
    public static class ValidadorNumerosPrimos
    {
        public static bool EsNumeroPrimo(int numero)
        {
            var bandera = true;
            for (int i = 2; i < numero; i++)
            {
                if (numero % 2 == 0)
                {
                    bandera = false;
                }
            }

            if(numero != 1 && bandera)
            {
                return true;
            }
            return false;
            
        }
    }
}
