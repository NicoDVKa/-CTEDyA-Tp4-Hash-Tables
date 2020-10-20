using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace HT
{
    class Empleado
    {
        private string nombre;
        private int numEmpleado;
        private int dni;

        public Empleado(string nombre, int numEmpleado, int dni)
        {
            this.nombre = nombre;
            this.numEmpleado = numEmpleado;
            this.dni = dni;
        }
        
        public int DNI
        {
            get { return this.dni; }        
        }
        
        public string Nombre
        {
            get { return this.nombre; }
        }
        
        public int NumEmpleado
        {
            get { return this.numEmpleado; }
        }

    }
}
