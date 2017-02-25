using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PeliculaActores
{
    public class Utilitarios
    {
        public static int TOINT(string name)
        {
            int num ;
            int.TryParse(name, out num);
            return num;
        }
    }
}
