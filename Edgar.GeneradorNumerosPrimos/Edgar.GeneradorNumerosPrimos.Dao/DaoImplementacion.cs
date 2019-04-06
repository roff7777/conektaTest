using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Edgar.GeneradorNumerosPrimos.Contratos;

namespace Edgar.GeneradorNumerosPrimos.Dao
{
    public class DaoImplementacion
    {
        public int GuardarSolicitud(Solicitud solicitud)
        {
            using (testEntities con = new testEntities())
            {
                con.solicitud.Add(new Dao.solicitud() {
                    cantidad = solicitud.CantidadGenerada,
                    fin = solicitud.Final,
                    inicio = solicitud.Inicial
                });

                return con.SaveChanges();
            }
        }

    }
}
