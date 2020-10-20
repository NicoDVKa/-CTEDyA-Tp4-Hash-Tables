using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace HT
{
    class HashTable
    {
        private int tamaño;
        private ArrayList[] tabla;

        public HashTable(int tamaño)
        {
            this.tamaño = tamaño;
            this.tabla = new ArrayList[tamaño];
        }

        //Dispersion abierta
        public void insertar(Empleado empleado)
        {
            int clave = empleado.DNI % tamaño;

            if (tabla[clave]==null)
            {
                tabla[clave] = new ArrayList();
                tabla[clave].Add(empleado);
            }
            else
            {
                tabla[clave].Add(empleado);
            }
            
        }

        public void mostrarTabla() //Lo use para corroborar que funcionara bien
        {
            for (int i = 0; i<tamaño ; i++)
            {
                Console.WriteLine("Tabla en la posicion {0}",i);
                
                if (tabla[i]!=null)
                {
                    foreach (Empleado x in tabla[i])
                    {
                        Console.WriteLine(x.DNI);
                    }
                }
            }
        }
    }
}
