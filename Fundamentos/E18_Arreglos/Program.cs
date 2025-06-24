using System;
using System.Reflection.PortableExecutable;

namespace E18_Arreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            // un arreglo es un grupo de variables
            // Programa que calcula el promedio de tres calificaciones y muestra que tan lejos estan esas calificaciones del mismo

            //SE COMENTAREA EL COFIGO DE EJERCICIO PARA DESPUES VER COMO SE IMPLEMENTA CON ARREGLOS

            /*
            // variables
            double calif1 = 0.0;
            double calif2 = 0.0;
            double calif3 = 0.0;

            double promedio = 0.0;
            double diferencia = 0.0;
            string dato = "";

            //Pedir calificaciones

            Console.WriteLine("Ingrese calificacion1");
            dato = Console.ReadLine();
            calif1 = Convert.ToDouble(dato);

            Console.WriteLine("Ingrese calificacion2");
            dato = Console.ReadLine();
            calif2 = Convert.ToDouble(dato);

            Console.WriteLine("Ingrese calificacion3");
            dato = Console.ReadLine();
            calif3 = Convert.ToDouble(dato);

            //Calcula promedioo

            promedio = (calif1 + calif2 + calif3) / 3.0;

            // mostrar la diferencia con relaciona al promedio
            diferencia = promedio - calif1;
            Console.WriteLine("la calif1 es{0}, el promedio es {1}, y su diferencia es de {2}", calif1, promedio, diferencia);

            diferencia = promedio - calif2;
            Console.WriteLine("la calif2 es{0}, el promedio es {1}, y su diferencia es de {2}", calif2, promedio, diferencia);

            diferencia = promedio - calif3;
            Console.WriteLine("la calif3 es{0}, el promedio es {1}, y su diferencia es de {2}", calif3, promedio, diferencia);
            */

            //**********************PROGRAMA DE ARREGLOS********************//

            // Declara arreglo que es lo mismo que un vector en este ejemplo es un arreglo o vecto de una sola dimension
            
            //tipo deto + corchet +nombre + igual + new +tipodato + valor arreglo 
            
            double[] calif = new double[3];

            
            // Define variables            
            double promedio = 0.0;
            double sumatoria = 0.0;
            double diferencia = 0.0;
            int n = 0; // variables de control del ciclo
            string dato = "";

            //pedir datos
            for (n = 0; n < 3; n++)
            {
                Console.WriteLine("Dame la calificacion");
                dato = Console.ReadLine();
                calif[n] = Convert.ToDouble(dato); // Linea importando donse se asigna valor a la vartiable del arreglo
            }

            //Calcular promedio
            for (n = 0; n < 3; n++)
            {
                //sumatoria = sumatoria + calif[n];
                sumatoria += calif[n];
            }
            
            promedio = sumatoria / 3;

            //Calculamos la diferencia e imprimos
            for (n = 0; n < 3; n++)
            {
                diferencia = promedio - calif[n];
                Console.WriteLine("la calif es{0}, el promedio es {1}, y su diferencia es de {2}", calif[n], promedio, diferencia);

            }
            

            










            
















        }
    }
}
