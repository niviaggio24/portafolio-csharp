using System;

namespace E6_CalcularPromediodeTresnum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calcular el promedio de tres numeros

            // Definir nuestras variables
            string dato = "";  //inicializado
            double num1 = 0.0;
            double num2 = 0.0;
            double num3 = 0.0;
            double promedio = 0.0;

            // Pedir numero 1
            Console.WriteLine("ingresar numero 1");
            dato = Console.ReadLine();
            num1 = Convert.ToDouble(dato);

            // Pedir numero 2
            Console.WriteLine("ingresar numero 2");
            dato = Console.ReadLine();
            num2 = Convert.ToDouble(dato);

            // Pedir numero 3
            Console.WriteLine("ingresar numero 3");
            dato = Console.ReadLine();
            num3 = Convert.ToDouble(dato);

            // Calcular promedio es ( es la  suma de todos lo valores divido sobre la cantidad de valores)

            promedio = (num1 + num2 + num3) / 3.0;

            // Mostrar el promedio

            Console.WriteLine("el promedio es {0}", promedio);

        }
    }
}
