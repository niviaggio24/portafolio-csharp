using System;

namespace E21_UsoArreglosyCiclos
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Variabls
            int[] valores = new int[11]; // se declara Arreglo de una sola dimension
            int numero = 0;
            string dato = ""; //obtiene informacion por el usuario via teclado
            int n = 0;
            int mayor = 0;

            //pedir nbumeros
            for (n = 0; n < 10; n++)
            {
                Console.WriteLine("Dame un numero  entre 0 y 10");
                dato = Console.ReadLine();
                numero = Convert.ToInt32(dato);

                //llevar acabo el conteo

                valores[numero]++; // aca acumula la cantidad de numeros repetidos.
            }

            for (n = 0; n < 11; n++)
            {
                Console.WriteLine("El numero {0} aparecio {1} veces ", n, valores[n]); 
            }

            for (n = 0; n < 11; n++)
            {
                if (valores[n] > mayor)
                    mayor = n;
            }

            Console.WriteLine("El numero que se repitio mas veces {0}", mayor);

        }
    }
}