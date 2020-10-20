using System;

namespace HT
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado1 = new Empleado("Nicolas Herlan",01,43400885);
            Empleado empleado2 = new Empleado("Lionel Farias",02,44022344);
            Empleado empleado3 = new Empleado("Francisco Iturburu",03,41400379);
            Empleado empleado4 = new Empleado("Joaquin Brilz",04,45400982);
            Empleado empleado5 = new Empleado("Bruno Hoffmann",05,46400343);

            HashTable tabla = new HashTable(5);

            tabla.insertar(empleado1);
            tabla.insertar(empleado2);
            tabla.insertar(empleado3);
            tabla.insertar(empleado4);
            tabla.insertar(empleado5);

            Empleado buscado = tabla.buscar(46400343);
            if (buscado != null)
            {
                Console.WriteLine("El empleado con dni {0} es: {1} y su numero de empleado es {2}",buscado.DNI,buscado.Nombre,buscado.NumEmpleado);
            }


            Console.WriteLine("Presione un tecla para salir...");
            Console.ReadKey(true);

        }
    }
}
