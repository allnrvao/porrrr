using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fundamentos.Models
{
    internal class Cerveza : Bebida
    {
        public Cerveza(int Cantidad, String Nombre = "Cerveza") : base(Nombre, Cantidad) { } 
    }
}
