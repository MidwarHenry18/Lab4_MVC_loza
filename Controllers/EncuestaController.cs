using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.SessionState;
using Laboratorio4_mvc_Maldonado.Models;

namespace Laboratorio4_mvc_Maldonado.Controllers
{
    public class EncuestaController : Controller
    {
        // GET: Encuesta
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Encuestar(ClsEncuesta objEncuensta)
        {
            ViewBag.Pregunta1 = "PHP";
            ViewBag.Pregunta2 = "Python";
            ViewData["Pregunta3"] = "Java";

            objEncuensta.totalvotos = 0;
            objEncuensta.totalporcentaje = 0.0d;
            if (Request["curso"] == "Curso 1")
            {
                int contador = 0;
                if (Session["cv1"] == null)
                {
                    Session["cv1"] = 1;
                }
                else
                {
                    contador = Convert.ToInt32(Session["cv1"]);
                    contador++;
                    Session["cv1"] = contador;
                    objEncuensta.totalvotos += Convert.ToInt32(Session["cv1"]);

                }
            }
            if (Request["curso"] == "Curso 2")
            {
                int contador = 0;
                if (Session["cv2"] == null)
                {
                    Session["cv2"] = 2;
                }
                else
                {
                    contador = Convert.ToInt32(Session["cv2"]);
                    contador++;
                    Session["cv2"] = contador;
                    objEncuensta.totalvotos += Convert.ToInt32(Session["cv2"]);

                }
            }
            if (Request["curso"] == "Curso 3")
            {
                int contador = 0;
                if (Session["cv3"] == null)
                {
                    Session["cv3"] = 3;
                }
                else
                {
                    contador = Convert.ToInt32(Session["cv3"]);
                    contador++;
                    Session["cv3"] = contador;
                    objEncuensta.totalvotos += Convert.ToInt32(Session["cv3"]);

                }
            }
            Session["Totalvotos"] = (Convert.ToInt32(Session["cv1"]) + Convert.ToInt32(Session["cv2"])+ Convert.ToInt32(Session["cv3"]));
            
            Session["vp1"] = (Convert.ToDouble(Session["porC1"]).ToString("0.00"));
            Session["porC1"] = ((Convert.ToDouble(Session["porC1"]) * 100.0d) / Convert.ToDouble(Session["Totalvotos"])).ToString("0.00");

            Session["vp2"] = (Convert.ToDouble(Session["porC2"]).ToString("0.00"));
            Session["porC2"] = ((Convert.ToDouble(Session["porC2"]) * 100.0d) / Convert.ToDouble(Session["Totalvotos"])).ToString("0.00");

            Session["vp3"] = (Convert.ToDouble(Session["porC3"]).ToString("0.00"));
            Session["porC3"] = ((Convert.ToDouble(Session["porC3"]) * 100.0d) / Convert.ToDouble(Session["Totalvotos"])).ToString("0.00");
            return View(objEncuensta);
        }
    }
}