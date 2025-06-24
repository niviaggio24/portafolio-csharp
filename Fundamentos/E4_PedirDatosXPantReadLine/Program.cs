using System;
using System.Globalization;

namespace E4_PedirDatosXPantReadLine
{
    class Program
    {
        static void Main(string[] args)
        {

            // Readline pertene a la clase consola va esperar que la informacion sea ingresada por teclado por parte del usuario para que esa informacion sea captura atravez de una variable
            // Readline siempre va enviar la informacion como una cadena.

            //*****************EJERCICIO1******************************
            
            Console.WriteLine("//*******EJERCICIO1-funcionalidad de la clase readline******");
            Console.WriteLine();

            // Definir variables
            string nombre = "";


            // pedro nombre 
            Console.WriteLine("Ingresa tu nombre porfavor");
            nombre = Console.ReadLine();

            // mandar saludo
            Console.WriteLine("hola {0}, mucho gusto", nombre);

            Console.WriteLine();
            Console.WriteLine();

            //*****************EJERCICIO2******************************s

            Console.WriteLine("//*******EJERCICIO2-capturar una cadena************");
            Console.WriteLine();

            //Definir variables

            string nombres = "";
            string apellidos = "";

            //Pedir nombres
            Console.WriteLine();
            Console.WriteLine("Dame tu nombre");
            nombres = Console.ReadLine();    //aca capturo los nombres            

            //Pedir apellidos
            Console.WriteLine("Dame tus apellidos");
            apellidos = Console.ReadLine();

            //mandar mensajes
            Console.WriteLine("hola{0}{1}", nombres,apellidos);

            Console.WriteLine();
            Console.WriteLine();

            //*****************EJERCICIO3******************************

            Console.WriteLine("//*****************EJERCICIO3-Convertir de caracter a entero para recibir por pantalla******************************");
            Console.WriteLine();

            // Variables
            String dato = "";
            int valor = 0;

            // pedir numero
            Console.WriteLine("Ingres un numero");            
            dato = Console.ReadLine();
            valor = Convert.ToInt32(dato);

            //mostrar
            Console.WriteLine("El numero es {0}", valor);

            //*****************EJERCICIO4******************************


            Console.WriteLine("//*****************EJERCICIO4 - pedir valor tipo flotante por pantalla******************************");
            Console.WriteLine();

            // Variables
            String dato1 = "";
            double valorpf = 0.0;

            // pedir numero
            Console.WriteLine("Ingrese un numero tipo flotante");
            dato1 = Console.ReadLine();
            valorpf = Convert.ToDouble(dato1);

            //mostrar
            Console.WriteLine("el numero punto flotante es {0}", valorpf);






            
            //mostrar
            






















        }
    }
}
