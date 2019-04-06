using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Edgar.GeneradorNumerosPrimos.Contratos;
using Edgar.GeneradorNumerosPrimos.Dao;
using Edgar.GeneradorNumerosPrimos.Facade;

namespace Edgar.GeneradorNumerosPrimos.App.Controllers
{
    public class GeneradorPrimosController : Controller
    {
        private FacadeImplementation facade;
        public GeneradorPrimosController()
        {
            this.facade = new FacadeImplementation(new DaoImplementacion());
        }
        // GET: GeneradorPrimos
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GenerarGuardarSolicitud(Solicitud solicitud)
        {
            int[] primos = facade.ObtenerNumerosPrimos(solicitud);

            solicitud.CantidadGenerada = primos.Length;
            solicitud.Primos = primos;
            //acade.GuardarSolicitud(solicitud);

            return Json(solicitud);
        }

    }
}