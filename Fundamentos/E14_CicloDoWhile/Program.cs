using System;

namespace E14_CicloDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            //El cliclo Do while se utiliza siempre y cuando no conocemos el valor de las repeticiones que deseamos hacer tal como el ciclo for
            //Programa muestra el uso de while
            //Se lleva ejecuta al menos una vez

            int opcion = 0;
            string dato = "";
            double dolares = 0.0;
            double pesos = 0.0;
            double tipocambio = 18.20;

            // hacemos el ciclo while
            do
            {
                // Mostramos el menu
                Console.WriteLine("1.Pesos a dolares, 2.Dolares a pesos, 3.Salir");
                dato = Console.ReadLine();
                opcion = Convert.ToInt32(dato);

                //Validar opcion seleccionada
                if (opcion == 1)                
                {
                    //Pedimos los pesos
                    Console.WriteLine("Cuantos pesos");
                    dato = Console.ReadLine();
                    pesos = Convert.ToDouble(dato);

                    //Convertirnos
                    dolares = pesos / tipocambio;
                    Console.WriteLine("Son {0} dolares", dolares);                
                }

                if (opcion == 2)
                {
                    //Pedimos dolares
                    Console.WriteLine("Cuantos dolares");
                    dato = Console.ReadLine();
                    dolares = Convert.ToDouble(dato);

                    //Convertir a pesos
                    pesos = dolares * tipocambio;
                    Console.WriteLine("Son {0} pesos", pesos);
                }
            } while (opcion !=3);  //Expresion logica

        }
    }
}
