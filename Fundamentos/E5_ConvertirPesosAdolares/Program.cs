using System;

namespace E5_ConvertirPesosAdolares
{
    class Program
    {
        static void Main(string[] args)
        {

            // Programa que convierte de pesos a dolares

            // Variables

            string dato = "";
            double cant_pesos = 0.0;
            double tasa_cambio = 0.0;
            double cant_dolare = 0.0;


            // Pedir cantidad de pesos

            Console.WriteLine("ingrese el valor en pesos");
            dato = Console.ReadLine();
            cant_pesos = Convert.ToDouble(dato);


            // Pedir la tasa de cambio

            Console.WriteLine("Un dolar cuantos pesos son?");
            dato = Console.ReadLine();
            tasa_cambio = Convert.ToDouble(dato);

            // Hacer la conversion de pesos a dolares

            cant_dolare = cant_pesos / tasa_cambio;

            //mostrar resultados 

            Console.WriteLine("{0} pesos son {1} dolares", cant_pesos, cant_dolare);


        }
    }
}
