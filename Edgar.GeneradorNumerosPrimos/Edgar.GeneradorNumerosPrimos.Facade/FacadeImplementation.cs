using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Edgar.GeneradorNumerosPrimos.Facade;
using Edgar.GeneradorNumerosPrimos.Dao;
using Edgar.GeneradorNumerosPrimos.Contratos;

namespace Edgar.GeneradorNumerosPrimos.Facade
{
    public class FacadeImplementation
    {
        private DaoImplementacion dao;
        public FacadeImplementation(DaoImplementacion dao)
        {
            this.dao = dao;
        }


        public int[] ObtenerNumerosPrimos(Solicitud solicitud)
        {
            List<int> primos = new List<int>();
            for(int i = solicitud.Inicial; i <= solicitud.Final; i++)
            {
                if(ValidadorNumerosPrimos.EsNumeroPrimo(i))
                {
                    primos.Add(i);
                }
            }
            return primos.ToArray();
        }

        public int GuardarSolicitud(Solicitud solicitud)
        {
            return dao.GuardarSolicitud(solicitud);
        }
    }
}
