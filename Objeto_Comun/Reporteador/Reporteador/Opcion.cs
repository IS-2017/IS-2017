using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reporteador
{
    class Opciones
    {
        private static string opcion;
        public static string Opcion
        {
            get
            {
                return opcion;
            }
            set
            {
                opcion = value;
            }
        }
    }
}
