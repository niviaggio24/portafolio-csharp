using System;

namespace CicloForAnidadNumerPrimos
{
    class Program
    {
        static void Main(string[] args)
        {

            //Este programa muestra los numeros primos del 1 al 100            
            
            //El  numero primo es aquel que puede dividirse entre si mismo y la unidad unicamente por ejemplo el numero 12 no es primo porque se puede dividir entre 3,  4 y desde luego entre 12
            //entocs tuvo otros divisores aparte del 12 y del 1.En cambio el numero 7 si es un numero primo porque no se puede dividir entre 2 de manera exacta ni entre 3 entre 4 el numer 7 solo se puede
            //dividir de manera exacta entre el 1 y el 7.

            //Variables

            int n = 0;
            int m = 0;
            bool primo = true;


            for (n = 2; n < 100; n++)
            {
                primo = true;
                for (m = 2; m < n; m++)
                {

                    if (n % m == 0)
                        primo = false;
                }            

                if (primo == true)
                Console.Write("{0}, ", n);
            }

            Console.WriteLine();

        }
    }
}
