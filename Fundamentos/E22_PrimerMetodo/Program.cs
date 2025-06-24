using System;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;

namespace E22_PrimerMetodo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio donde se disminuye las instrucciones por implementar un metodo.
            // calcular el promedio de cinco numeros.
            

            //Variables
            string dato = "";
            double num1 = 0;
            double num2 = 0;
            double num3 = 0;
            double num4 = 0;
            double num5 = 0;
            double promedio = 0;

            /*
             * 
             // Pedir numero 1
             Console.WriteLine("Dame el numero 1");
             dato = Console.ReadLine();
             num1 = Convert.ToDouble(dato);
            
             // Pedir numero 2
             Console.WriteLine("Dame el numero 2");
             dato = Console.ReadLine();
             num2 = Convert.ToDouble(dato);
 
             // Pedir numero 3
             Console.WriteLine("Dame el numero 3");
             dato = Console.ReadLine();
             num3 = Convert.ToDouble(dato);

             // Pedir numero
             Console.WriteLine("Dame el numero 4");
             dato = Console.ReadLine();
             num4 = Convert.ToDouble(dato);

             // Pedir numero
             Console.WriteLine("Dame el numero 5");
             dato = Console.ReadLine();
             num5 = Convert.ToDouble(dato);

             //Calcula promedio
             promedio = (num1 + num2 + num3 + num4 + num5) / 5.0;

             */

            //Ahora transformamos el programa para utilizar el metodo.
            //El metodo nos sirve para la reutilizacin de codigo 
            //Especializacion es decir el metodo se dedica a una sola cosa
            //Mas facil mantenimiento y depuracion 
            //Partes de un metodo : el tipo de acceso(public,privado) modificador(static) , tipo de retorno (int,double, ) + nombre del metodo (atravez del nombre hacems la invocacion)+ parametros (los metodos pueden tener o no parametros)
            //los parametros sirver para enviar informacion al metodos, si el metodos necesita informacion para trabajar 
            //los nombre de los metodos deben ser unicos deben se verbos, debe empezar con letra 


            // Pedir numero1 
            num1 = Pedir(1);
            // Pedir numero2 
            num1 = Pedir(2);
            // Pedir numero3 
            num1 = Pedir(3);
            // Pedir numero4 
            num1 = Pedir(4);
            // Pedir numero5 
            num1 = Pedir(5);

            //Calcula promedio
            promedio = (num1 + num2 + num3 + num4 + num5) / 5.0;

            //Mostrar promedio
            Console.WriteLine("El promedio es {0}", promedio);            
        }

        public static double Pedir(int n)
        {
            double numero = 0.0;
            string dato = "";
            Console.WriteLine("->Dame el numero{0}", n);
            dato = Console.ReadLine();
            numero = Convert.ToDouble(dato);

            return numero;
        }
    }
}
