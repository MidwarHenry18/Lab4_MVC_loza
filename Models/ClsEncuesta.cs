using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio4_mvc_Maldonado.Models
{
    public class ClsEncuesta
    {
        public string pregunta1 { get; set; }
        public string pregunta2 { get; set; }
        public string pregunta3 { get; set; }

        public int votos1 { get; set; }
        public int votos2 { get; set; }
        public int votos3 { get; set; }
        
        public double porcentaje1 { get; set; }
        public double porcentaje2 { get; set; }
        public double porcentaje3 { get; set; }

        public int totalvotos { get; set; }
        public double totalporcentaje { get; set; }


    }
}