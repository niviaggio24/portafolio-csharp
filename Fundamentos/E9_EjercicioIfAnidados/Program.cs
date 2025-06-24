using System;

namespace E9_EjercicioIfAnidados
{
    class Program
    {
        static void Main(string[] args)
        {
            // Vamos a enteder los ifs anidados. Es tener dentro de un bloque de ifs otros ifs
            // Calcular el impuesto ambiental
            
            Console.WriteLine("***********EJERCICIO DE IFS ANIDADOS*************");
            // Definicios de variables
            int opcion = 0;
            int fabricacion = 0;
            string dato;

            // pedir el tipo de articulo por pantalla
            Console.WriteLine("1. Auto, 2. Motocicleta, 3. Bicicleta ");
            dato = Console.ReadLine();
            opcion = Convert.ToInt32(dato);

            // pedir fecha de cuando se fabrico
            Console.WriteLine("En que año se fabrico ?");
            dato = Console.ReadLine();
            fabricacion = Convert.ToInt32(dato);

            // Verificamos las opciones 

            if (opcion == 1)
            {
                if (fabricacion <= 1980)
                    Console.WriteLine("El impuesto del auto es del 8%");
                if (fabricacion > 1980 && fabricacion < 2000)
                    Console.WriteLine("El impuesto del auto es del 5%");
                if (fabricacion >= 2000)
                    Console.WriteLine("El impuesto del auto es del 3%");            
            }


            if (opcion == 2)
            {
                if (fabricacion <= 1980)
                    Console.WriteLine("El impuesto del motocicleta es 4%");
                if (fabricacion > 1980 && fabricacion < 2000) 
                    Console.WriteLine("El impuesto de la motocicleta es 2%");
                if (fabricacion > 2000)
                    Console.WriteLine("El impuesto de la motocicleta es 1%");
            }

            if (opcion == 3)
            {   
                    Console.WriteLine("la bicicleta no tiene impuesto ");
            }

            // Ejercicio 2 

            Console.WriteLine();
            Console.WriteLine("**************EJERCICIO DE IFS ESCALERA**************");
            // la escalera de ifs es una buena tecnica para el rendimientos del programa



            //*******Ejercicio1***** Realiza la suma, resta, multiplicacion o division de dos numeros, segun lo desea el usuario

            // crear variables

            string datoe = "";
            double numero1 = 0.0;
            double numero2 = 0.0;
            int seleccion = 0;
            double resultado = 0.0;

            // pedir numero 1
            Console.WriteLine("Ingrese numero 1");
            datoe = Console.ReadLine();
            numero1 = Convert.ToDouble(datoe);

            // pedir numero 2
            Console.WriteLine("ingrese numero 2");
            datoe = Console.ReadLine();
            numero2 = Convert.ToDouble(datoe);

            // pedir operacion
            Console.WriteLine("1.Suma, 2.Resta, 3.Multiplicacion, 4.Division ");
            Console.WriteLine("Que operacion deseas?");
            datoe = Console.ReadLine();
            seleccion = Convert.ToInt32(datoe);

            // determinar si es suma Aca tiene recorrer todos por eso toca convertirlo en una escalera de IFS
            /*
            if (seleccion == 1)
                resultado = (numero1 + numero2);

            // determinar si es resta

            if (seleccion == 2)
                resultado = (numero1 - numero2);

            // determinar si es multiplicacion 
            if (seleccion == 3)
                resultado = (numero1 * numero2);

            // determinar si es division
            if (seleccion == 4)
                resultado = (numero1 / numero2);

            // determinar si no existe opcion
            if (seleccion > 4)
                Console.WriteLine("su seleccion es invalida");

            // mostrar datos
            Console.WriteLine("Resultado es {0}", resultado);
            */

            if (seleccion == 1)
                resultado = (numero1 + numero2);  //determina es suna
            else if (seleccion == 2)
                resultado = (numero1 - numero2);
                else if (seleccion == 3)
                     resultado = (numero1 * numero2);  //determina multiplicacion
                     else if (seleccion == 4)
                          resultado = (numero1 / numero2);  //determina division
                          else
                              Console.WriteLine("su seleccion es invalida");

            // Mostramos resultado
            Console.WriteLine("El resultaod es {0}", resultado);

        }
    }
}
