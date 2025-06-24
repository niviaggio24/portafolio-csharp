using System;

namespace E11_EjerciciosIFySWITCH
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programa que convierte de millas a kilometros o de Kilolmentos a millas

            //variables

            int opcion = 0;
            double km = 0.0;
            double millas = 0.0;
            string dato = "";

            // Presentar  menu
            Console.WriteLine("1. Millas a Km, 2. Km a Millas");
            dato = Console.ReadLine();
            opcion = Convert.ToInt32(dato);

            // si es de milla a km
            if (opcion == 1)
            {
                // pedir la cantidad de millas
                Console.WriteLine("Ingrese las millas");
                dato = Console.ReadLine();
                millas = Convert.ToDouble(dato);

                // if anidado
                if (millas < 0)
                {
                    Console.WriteLine("Por favor ingrese un valor postivo");

                }
                else
                {
                    // convertir a kim
                    km = millas * 1.609;
                
                    //mostrar resultdos
                    Console.WriteLine("{0} millas son {1} km", millas, km);
                }
            }

            // si es de km a milla
            if (opcion ==2)
            
            {
                // pedir la cantidad de km
                Console.WriteLine("Ingrese km");
                dato = Console.ReadLine();
                km = Convert.ToDouble(dato);

                // evalua if aninadado para validar valor que ingresen valores postivos
                if(km >=0)
                {
                    // convertir a Milas
                    km = km / 1.609;

                    //mostrar resultdos
                    Console.WriteLine("tantos km {0} son {1}", km, millas);
                }
                else
                {
                    Console.WriteLine("Ingrese un valor positivo");
                }

            }

        }
    }
}