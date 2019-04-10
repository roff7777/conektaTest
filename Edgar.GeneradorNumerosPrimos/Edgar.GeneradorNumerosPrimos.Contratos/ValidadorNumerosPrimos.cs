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
            //TODO:Realizar con recursividad
            int divisores = 0;
            for(int i = 1; i<= numero; i++)
            {
                if(numero%i ==0)
                {
                    divisores++;
                }
            }

            if(divisores == 2)
            {
                return true;
            }
            return false;
        }
    }
}
