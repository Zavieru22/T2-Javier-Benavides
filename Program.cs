using System;
using T2;

namespace ProyectoArbolEmpleados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArbolBBP arbolEmpleados = new ArbolBBP();

            int opcion;

            do
            {
                Console.WriteLine("\n----------------------");
                Console.WriteLine("   MENU DE EMPLEADOS");
                Console.WriteLine("----------------------");
                Console.WriteLine("1) Agregar");
                Console.WriteLine("2) Listar1 - InOrden");
                Console.WriteLine("3) Listar2 - PosOrden");
                Console.WriteLine("4) Mayores de cierta Antiguedad");
                Console.WriteLine("5) Penultimo");
                Console.WriteLine("9) Fin");
                Console.Write("Seleccione opción: ");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:

                        Console.Write("Codigo: ");
                        int codigo = int.Parse(Console.ReadLine());

                        Console.Write("Nombre: ");
                        string nombre = Console.ReadLine();

                        Console.Write("Antiguedad: ");
                        int antiguedad = int.Parse(Console.ReadLine());

                        Empleado emp = new Empleado(codigo, nombre, antiguedad);

                        arbolEmpleados.Agrega(emp);

                        Console.WriteLine("Empleado agregado.");
                        break;

                    case 2:

                        arbolEmpleados.MuestraInCodigo();
                        break;

                    case 3:

                        arbolEmpleados.MuestraPosAntiguedad();
                        break;

                    case 4:

                        Console.Write("Ingrese antiguedad: ");
                        int ant = int.Parse(Console.ReadLine());

                        int cantidad = arbolEmpleados.MayoresA(ant);

                        Console.WriteLine($"Cantidad de empleados mayores a {ant}: {cantidad}");
                        break;

                    case 5:

                        Console.WriteLine("\nPenúltimo empleado según código:");
                        Console.WriteLine(arbolEmpleados.Penultimo());
                        break;

                    case 9:

                        Console.WriteLine("Fin del programa.");
                        break;

                    default:

                        Console.WriteLine("Opción inválida.");
                        break;
                }

            } while (opcion != 9);
        }
    }
}