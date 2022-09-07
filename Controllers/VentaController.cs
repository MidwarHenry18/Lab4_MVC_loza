using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Laboratorio4_mvc_Maldonado.Models;

namespace Laboratorio4_mvc_Maldonado.Controllers
{
    public class VentaController : Controller
    {
        public static double precioC1 = 500;
        public static double precioC2 = 350;
        public static double precioC3 = 1500;
        public static double precioC4 = 850.99;


        // GET: Venta
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CalcularVenta(ClsVenta objVenta)
        {
            if (objVenta.Cursophp == true)
            {
                objVenta.subtotal = objVenta.subtotal + precioC1;
            }
            if (objVenta.CursoWeb == true)
            {
                objVenta.subtotal = objVenta.subtotal + precioC2;
            }
            if (objVenta.CursoMovil == true)
            {
                objVenta.subtotal = objVenta.subtotal + precioC3;
            }
            if (objVenta.Cursopython == true)
            {
                objVenta.subtotal = objVenta.subtotal + precioC4;
            }
            objVenta.igv = objVenta.subtotal * 0.18;
            objVenta.total = objVenta.subtotal + objVenta.igv;




            return View(objVenta);
        }

    }
}