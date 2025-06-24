using System;
using System.Reflection.PortableExecutable;

namespace E15_CicloWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ciclo while se utiliza para cuando no sabemos el numero de repeticiones
            // Puede no llevarse a cabo ni una sola vez

            // Variables            
            int dinero = 0;
            int total = 0;
            string dato = "";
            int opcion = 0;

            //Pedir datos 

            Console.WriteLine("Cuanto dinero tienes");
            dato = Console.ReadLine();
            dinero = Convert.ToInt32(dato);

            while (dinero > 0 && opcion != 5)
            {
                //Presentar el menu
                Console.WriteLine("1. Dulces, 2. Papas, 3. Chocolates, 4. Helado, 5. Salir");
                dato = Console.ReadLine();
                opcion = Convert.ToInt32(dato);

                //Evalua casos de opcion digitada.
                switch (opcion)
                {
                    case 1:
                        dinero -= 3;  // Decremento dinero en 3 es decir le quita a dinero inicial
                        total += 3;   // Incrementa el total de lo que ha gastado lo va acumulando
                        break;

                    case 2:
                        dinero -= 12;
                        total += 12;
                        break;

                    case 3:
                        dinero -= 7;
                        total += 7;
                        break;

                    case 4:
                        dinero -= 25;
                        total  += 25;
                        break;
                } // Fin del while

                Console.WriteLine("Tienes {0} y haz gastado {1}", dinero, total);            
            }

            Console.WriteLine("Adios");

        }
    }
}
