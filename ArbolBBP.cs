using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    internal class ArbolBBP
    {
        public NodoP Primero;

        public ArbolBBP()
        {
            Primero = null;
        }

        public void Agrega(Empleado empleado)
        {
            NodoP nuevo = new NodoP(empleado);

            if (Primero == null)
            {
                Primero = nuevo;
                return;
            }

            NodoP actual = Primero;

            while (true)
            {
                if (empleado.Codigo < actual.Valor.Codigo)
                {
                    if (actual.Izqu == null)
                    {
                        actual.Izqu = nuevo;
                        return;
                    }

                    actual = actual.Izqu;
                }
                else
                {
                    if (actual.Dere == null)
                    {
                        actual.Dere = nuevo;
                        return;
                    }

                    actual = actual.Dere;
                }
            }
        }

        public void MuestraInCodigo()
        {
            Console.WriteLine("\n--- LISTADO INORDEN ---");
            MostrarInOrden(Primero);
        }

        private void MostrarInOrden(NodoP nodo)
        {
            if (nodo != null)
            {
                MostrarInOrden(nodo.Izqu);

                Console.WriteLine(nodo.Valor);

                MostrarInOrden(nodo.Dere);
            }
        }
        public void MuestraPosAntiguedad()
        {
            Console.WriteLine("\n--- LISTADO POSORDEN ---");
            MostrarPosOrden(Primero);
        }

        private void MostrarPosOrden(NodoP nodo)
        {
            if (nodo != null)
            {
                MostrarPosOrden(nodo.Izqu);

                MostrarPosOrden(nodo.Dere);

                Console.WriteLine(nodo.Valor);
            }
        }

        public int MayoresA(int antiguedad)
        {
            return ContarMayores(Primero, antiguedad);
        }

        private int ContarMayores(NodoP nodo, int antiguedad)
        {
            if (nodo == null)
                return 0;

            int contador = 0;

            if (nodo.Valor.Antiguedad > antiguedad)
                contador = 1;

            return contador
                + ContarMayores(nodo.Izqu, antiguedad)
                + ContarMayores(nodo.Dere, antiguedad);
        }

        public string Penultimo()
        {
            if (Primero == null)
                return "El árbol está vacío.";

            if (Primero.Dere == null)
                return "No existe penúltimo.";

            NodoP actual = Primero;
            NodoP anterior = null;

            while (actual.Dere != null)
            {
                anterior = actual;
                actual = actual.Dere;
            }

            return anterior.Valor.ToString();
        }






















    }
}
