using System;

namespace E24_EjerciciosMetodos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programa que realiza operaciones aritmeticas usando metodos
            string dato = "";
            int opcion = 0;
            double a = 0;
            double b = 0;
            double c = 0;
            
            do
            {
                Console.WriteLine("1-Suma, 2-Resta, 3-Multi, 4-Div, 5-Salir");
                dato = Console.ReadLine();
                opcion = Convert.ToInt32(dato);

                if (opcion == 1)
                    suma();

            } while (opcion != 5) ;            
        }       
        
        
        
        // Se declara metodo tipo que no retorna nada toda la logica la hace el mismoVoid quiere decir que no recibe nada 
        public static void suma()
        {

            //Variables
            double x = 0.0;
            double y = 0.0;
            double result = 0.0;
            string valor = "";

            Console.WriteLine("ingrese el primer valor");
            valor = Console.ReadLine();
            x = Convert.ToDouble(valor);

            Console.WriteLine("ingrese el primer valor");
            valor = Console.ReadLine();
            y = Convert.ToDouble(valor);

            result = x + y;
            Console.WriteLine("El resultado de la suma es {0}", result);
        }

        // Se declara metodo tipo que no retorna nada toda la logica la hace el mismoVoid quiere decir que no recibe nada 








    }
}
