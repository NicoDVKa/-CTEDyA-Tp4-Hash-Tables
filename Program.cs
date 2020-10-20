using System;

namespace HT
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado1 = new Empleado("Nicolas Herlan",01,43400885);
            Empleado empleado2 = new Empleado("Lionel Farias",02,44022345);
            Empleado empleado3 = new Empleado("Francisco Iturburu",03,41400379);
            Empleado empleado4 = new Empleado("Joaquin Brilz",04,45400985);
            Empleado empleado5 = new Empleado("Bruno Hoffmann",05,46400345);
            
            Console.WriteLine(empleado1.NumEmpleado + " " + empleado1.DNI + " " + empleado1.Nombre);
            Console.WriteLine(empleado2.NumEmpleado + " " + empleado2.DNI + " " + empleado2.Nombre);
            Console.WriteLine(empleado3.NumEmpleado + " " + empleado3.DNI + " " + empleado3.Nombre);
            Console.WriteLine(empleado4.NumEmpleado + " " + empleado4.DNI + " " + empleado4.Nombre);
            Console.WriteLine(empleado5.NumEmpleado + " " + empleado5.DNI + " " + empleado5.Nombre);
        }
    }
}
