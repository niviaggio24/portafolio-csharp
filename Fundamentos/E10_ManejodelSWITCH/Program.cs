using System;
using System.Collections;

namespace E10_ManejodelSWITCH
{
    class Program
    {
        static void Main(string[] args)
        {

            //declaro variables
            double numero1 = 0.0;
            double numero2 = 0.0;
            double resultado = 0.0;
            int seleccion = 0;
            string dato = "";

            //pedir por pantalla  numeros

            Console.WriteLine("Ingrese primer numero ");
            dato = Console.ReadLine();
            numero1 = Convert.ToInt32(dato);

            Console.WriteLine("Ingrese primer numero ");
            dato = Console.ReadLine();
            numero2 = Convert.ToInt32(dato);

            //pedir por pantalla operacion

            Console.WriteLine("1.Suma, 2.Resta, 3.Multiplicacion, 4.Division");
            Console.WriteLine("Que operacion deseas hacer");
            dato = Console.ReadLine();
            seleccion = Convert.ToInt32(dato);

            //No se puede colocar el switc con una variable es un error. El switch no va llevar comparaciones al estilo del if como Mayor o igual que.
            //El SWITCH es variable de comparacion con el valor de los casos no se pueden colocar expresion.El switch solo se puede utilizar con valores boleanos, enteros, char o cadena pero no se puede con doubles.

            switch (seleccion)
            {
                // determinar si es suma
                case 1:
                    resultado = numero1 + numero2;
                    break;

                // determinar si es resta
                case 2:
                    resultado = numero1 - numero2;
                 break;
                
                // determinar si es multiplicacion
                case 3:
                    resultado = numero1 * numero2;
                    break;

                // determinar si es division
                case 4:
                    resultado = numero1 / numero2;
                    break;
                // determinar si no existe opcion de seleccion
                default:
                    Console.WriteLine("Su seleccion es invlidad");
                    break;
            }
            //mostrar resultados
            Console.WriteLine("El resultado es {0}", resultado);
        }
    }
}
