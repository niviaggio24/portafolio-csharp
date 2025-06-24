using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;


// principio 
namespace SingleResponsability1
{
    class CEmpleado
    {
        private string nombre;
        private string puesto;
        private int edad;
        private double sueldo;

        public CEmpleado(string pNombre, string pPuesto, int pEdad, double pSueldo)
        {
            nombre = pNombre;
            puesto = pPuesto;
            edad = pEdad;
            sueldo = pSueldo;        
        }

        public override string ToString()
        {
            return string.Format("{0},{1},{2},{3}", nombre, puesto, edad, sueldo);
        }

    }
}
