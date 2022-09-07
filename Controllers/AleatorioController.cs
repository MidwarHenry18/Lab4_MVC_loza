using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Laboratorio4_mvc_Maldonado.Models;

namespace Laboratorio4_mvc_Maldonado.Controllers
{
    public class AleatorioController : Controller
    {
        // GET: Aleatorio
        public ActionResult Index()
        {
            return View();
        }

        
        public ActionResult Generar(ClsAleatorio objAleatorio)
        {
            Random rand = new Random();
            objAleatorio.a = rand.Next(3);
            objAleatorio.b = rand.Next(3);
            objAleatorio.c = rand.Next(3);

            if(objAleatorio.a == objAleatorio.b)
            {
                if (objAleatorio.b == objAleatorio.c)
                {
                    if (objAleatorio.a == objAleatorio.c)
                    {
                        objAleatorio.resultado = "Los 3 numeros son iguales, ganaste una entrada para Rosalia....";
                    }

                }
                else
                {
                    objAleatorio.resultado = "Perdiste... Sigue intentandolo ";
                }

            }
            else
            {
                objAleatorio.resultado = "Para la proxima... ";
            }


            return View(objAleatorio);
        }


    }
}
