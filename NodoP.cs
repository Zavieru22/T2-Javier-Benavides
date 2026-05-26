using ProyectoArbolEmpleados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace T2
{
    internal class NodoP
    {
        public Empleado Valor {  get; set; }
        public NodoP Izqu {  get; set; }

        public NodoP Dere {  get; set; }

        public NodoP(Empleado dato)
        {
            Valor = dato;
            Izqu = null;
            Dere = null;
        }

        public override string? ToString()
        {
            return $"{Valor}";
        }
    }
}
