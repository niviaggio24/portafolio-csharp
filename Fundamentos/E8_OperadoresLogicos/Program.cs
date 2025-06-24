using System;

namespace E8_OperadoresLogicos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Operadores Logicos : Sirve para evaluar mas de una expresion relacional a  la vez.

            // AND - && - Y
            // Solo es verdadero cuando los dos son verdaderos.
            // A  B | R
            // F  F | F
            // F  V | F
            // V  F | F
            // V  V | V

            // Este programa imprime la suma , solo cuando los dos numeros son menores a 10

            Console.WriteLine("OPERADOR AND &&");
            // declaro variables
            int a = 0;
            int b = 0;
            int suma = 0;
            string dato = "";

            // pedir numeros
            Console.WriteLine("ingrese primer numero");
            dato = Console.ReadLine();
            a = Convert.ToInt32(dato);

            Console.WriteLine("ingrese el segundo numero");
            dato = Console.ReadLine();
            b = Convert.ToInt32(dato);

            // se verifica que a sea menor a 10 y b sea menor que 10
            if (a < 10 && b < 10)
            {
                // se calcula la suma
                suma = a + b;
                // se imprimen resultados
                Console.WriteLine("La suma es {0}", suma);
            }
            else
            {

                Console.WriteLine("los dos numeros no son menores a 10");

            }

            // OPERADOR OR de igual forma va necesitar de dos operando es decir dos expresiones relacionales que se evaluen como verdadero o falso
            // OR - || - O 
            // Es verdadero si al menos uno es verdadero TABLA DE VERDAD

            // A  B | R
            // F  F | F
            // F  V | V
            // V  F | V
            // V  V | V

            // Estre programa imprime la suma, si hay un numero menor a 10 

            Console.WriteLine("OPERADOR OR ||");
            // Variables
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Ejercicio del Operador OR");

            //Defino variables
            int a1 = 0;
            int a2 = 0;
            int suma1 = 0;
            string datoO = "";

            //pedir numero primer numero
            Console.WriteLine("Ingrese un numero X ");
            dato = Console.ReadLine();
            a1 = Convert.ToInt32(datoO);

            //pedir segundo numero
            Console.WriteLine("Ingrese numero Y");
            datoO = Console.ReadLine();
            a2 = Convert.ToInt32(datoO);

            // Verificamos que sea menos que 10 O b sea menor que 10

            if (a1 < 10 || a2 < 10)
            {
                suma1 = a1 + a2;
                Console.WriteLine("la suma es {0}", suma1);
            }
            else
            {
                Console.WriteLine("Ninguno numero fue menor a 10 ");
            }


            // OPERADOR NOT se conoce como negacion y se representa !  este es un operador unario es decir solo va a necesitar de un operando
            // NOT lo que va hacer es llevar la negacion
            // Es verdadero cuando el valor es falso
            // A  | R
            // F  | V
            // V  | F
            // Estre programa imprime la suma, solo cuando el primer numero NO sea menos a 10
            
            Console.WriteLine("OPERADOR NOT ||");

            // Declaro variables

            int a3 = 0;
            int b3 = 0;
            int sumaNot = 0;
            string datonot = "";

            // Pedir numero por pantalla
            Console.WriteLine("Ingrese el primer numero ");
            datonot = Console.ReadLine();
            a3 = Convert.ToInt32(datonot);

            // Pedir numero por pantalla
            Console.WriteLine("Ingrese el segundo numero ");
            datonot = Console.ReadLine();
            b3 = Convert.ToInt32(datonot);

            // Verificamos que no sea menor que 10

            if (!(a3 < 10))
            {
                sumaNot = a + b;
            }
            else
            {
                Console.WriteLine("El numero no es menor que 10");
            
            }






















        }
    }
}
