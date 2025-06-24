using System;

namespace E2_ConvertirGradosCelsi_A_Faren
{
    class Program
    {
        static void Main(string[] args)
        {
            // Convertir de grados celsius a faregei

            // definir variables

            double grad_Celsius = 38.3;
            double grad_fahrenh = 0.0;

            // Convertir de C a F . Para convertirlos necesito multiplicar los grados celsius por 1.8 y adicionar 32

            grad_fahrenh = (grad_Celsius * 1.8) + 32;

            // Mostrar resultados

            Console.WriteLine("Tantos grados celsius {0} son {1} grados fahrenh", grad_Celsius, grad_fahrenh);         
        }
    }
}
