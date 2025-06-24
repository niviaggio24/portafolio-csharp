using System;
using System.Diagnostics.CodeAnalysis;

namespace E21_MatricesArreglos
{
    class Program
    {
        static void Main(string[] args)
        {

            //La matrix es un arreglo de dos dimensiones 
            //Son una colecccion de datos donde vamos a tener renglones y filas. 
            // Programa que muestra el uso de arreglos en dos dimensiones o matrices.
            // Tabla donde voy a colocar la temperatura de cada dia en diferentes semanas
            
            //Variables
            int n = 0;  //variable de control primer ciclo
            int m = 0;  //variable de control primer ciclo
            double sumatoria = 0;
            double promedio = 0;
            Random rnd = new Random();

            
            //Aqui se crea la MATRIZ

            int[,] datos = new int[4, 7]; // la coma va indcar que va utilizar dos indices. lo que esta en los parentesis son las dimensiones  4 filas x 7 columnas

            //llenamos los datos

            for (n = 0; n < 4; n++)   //Aca se recorren las filas
            { 
                for (m = 0; m < 7; m++) // Aca recorre las columans 
                {
                    datos[n, m] = rnd.Next(30); //aca asignamos los valores a la fila y columna, sea el valor random.
                }
            }

            //Imprimos los datos

            for (n = 0; n < 4; n++)
            {
                Console.WriteLine("Semana {0}", n);
                for (m = 0; m < 7; m++)
                {
                    Console.WriteLine("dia {0}, ", datos[n, m]);
                }
                Console.WriteLine();            
            }

            // calcular  el promedio por semana
            for (n = 0; n < 4; n++)
            {
                //Se limpian variables
                sumatoria = 0.0;
                promedio = 0.0;

                for (m = 0; m < 7; m++)
                {
                    sumatoria += datos[n, m];
                
                }

                promedio = sumatoria / 7.0;
                Console.WriteLine("El promedio de la semana {0} es {1}", n, promedio);
            }

            // calcular  el promedio Total
            //Se limpian variables
            Console.WriteLine();
            sumatoria = 0.0;
            promedio = 0.0;

            for (n = 0; n < 4; n++)
            {
                for (m = 0; m < 4; m++)
                { 
                sumatoria += datos[n, m];
                }
            }

            promedio = sumatoria / 28.0;
            Console.WriteLine("El promedio total es {0}", promedio);
        }

    }
}