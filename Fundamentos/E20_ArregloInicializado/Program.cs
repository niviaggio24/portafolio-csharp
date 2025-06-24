using System;

namespace E20_ArregloInicializado
{
    class Program
    {
        static void Main(string[] args)
        {
            // en esta ocacion se crea un arreglo e inicializarlo a lmismo tiempo que lo estamos creando

            double[] calif = { 7.5, 8.0, 9.2, 6.7 };

            double promedio = 0.0;
            double sumatoria = 0.0;
            double diferencia = 0.0;
            int n = 0;

            //calculamos el promedio

            for (n = 0; n < calif.Length; n++)
            {
                sumatoria += calif[n];
            }

            promedio = sumatoria / calif.Length;

            //calculamos la diferencia e imprimimos
            for (n = 0; n < calif.Length; n++)
            {

                diferencia = promedio - calif[n];
                Console.WriteLine("la calificacion es {0}, el promedio es {1}, y su diferencia es {2}", calif[n], promedio, diferencia);            
            }
        }
    }
}
