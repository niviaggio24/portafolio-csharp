using System;

namespace E19_ArregloEnTiempoEjecucion
{
    class Program
    {
        static void Main(string[] args)
        {

            //Arreglo donde su tamaño se establece en tiempo de ejecucion es decir se puede decir que es diamico.
            
            //Varaibles

            double[] calif;

            double promedio = 0.0;
            double sumatoria = 0.0;
            double diferencia = 0.0;
            int cantidad = 0;

            int n = 0;
            string dato = "";

            // Pedir cantidad de datos

            Console.WriteLine("Ingrese la cantidad de calificaciones");
            dato = Console.ReadLine();
            cantidad = Convert.ToInt32(dato);

            calif = new double[cantidad];

            // Pedimos las calificaciones
            for (n = 0; n < calif.Length; n++)
            {
                Console.WriteLine("Dame la calificacion");
                dato = Console.ReadLine();
                calif[n] = Convert.ToDouble(dato);
            }

            // Calculamos el promedio

            for (n = 0; n < calif.Length; n++)
            {
                //sumatoria = sumatoria + calif[n]
                sumatoria += calif[n];
            }
            promedio = sumatoria / calif.Length;

            // Calculamos el direncia e imprimimos

            for (n = 0; n < calif.Length; n++)
            {
                //sumatoria = sumatoria + calif[n]
                diferencia = promedio - calif[n];
                Console.WriteLine("la calificacion es {0}, su promedio es {1} y su diferencia es {2}", calif[n], promedio, diferencia);
            }
            
        }
    }
}

