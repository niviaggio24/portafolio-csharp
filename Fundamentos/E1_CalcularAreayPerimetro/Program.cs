using System;

namespace E1_CalcularAreayPerimetro
{
    class Program
    {
        static void Main(string[] args)
        {
            // Programa que calcula el area y el perimetro de un cuadrado ( para calcular el area de un programa)

            //Definimos variables

            string rectan = "";
            double ladoA = 0.0;
            double ladoB = 0.0;
            double area = 0.0;
            double perimetro = 0.0;

            // Pedir valor del Lado A

            Console.WriteLine("Ingrese el valor del lado A");
            rectan = Console.ReadLine();
            ladoA = Convert.ToDouble(rectan);

            // Pedir valor del Lado B

            Console.WriteLine("Ingrese valor del lado B");
            rectan = Console.ReadLine();
            ladoB = Convert.ToDouble(rectan);


            //Calcular el area . El area de un cuadrado va ser igual al lado X lado.

            area = ladoA + ladoB;

            //Calcular el perimentro. que es la suma de las logintudes de cada lado

            perimetro = 2 * (ladoA * ladoB);

            //Mostrar resultados

            Console.WriteLine("el retangulo de lados {0}, {1}", ladoA, ladoB);
            Console.WriteLine("Tiene un area de {0} y un perimetro de {1}", area, perimetro);
        }
    }
}
