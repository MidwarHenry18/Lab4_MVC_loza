using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio4_mvc_Maldonado.Models
{
    public class ClsVenta
    {
        public bool Cursophp { get; set; }
        public bool CursoWeb { get; set; }
        public bool CursoMovil { get; set; }
        public bool Cursopython { get; set; }

        public double subtotal { get; set; }
        public double precio { get; set; }
        public double igv { get; set; }
        public double total { get; set; }

    }
}