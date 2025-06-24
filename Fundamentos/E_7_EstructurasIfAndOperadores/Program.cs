using System;
using System.Threading.Tasks.Dataflow;
using System.Transactions;

namespace E_7_EstructurasIfAndOperadores
{
    class Program
    {
        static void Main(string[] args)
        {

            // estructuras selectivas
            // if(expresion sentencia;
            // Operadores  ==, >, <, >=, <=, !=

            int a = 5;
            int b = 8;
            int c = 5;

            if (a == b)
                Console.WriteLine("a es mayor que b");

            if (b > c)
                Console.WriteLine("");

            if (a < c)
                Console.WriteLine("a es mayor a c");

            if (a >= 5)
                Console.WriteLine("a es mayor o igual a 5");

            if (a != b)
                Console.WriteLine("a es diferente a b");


            // Sino se cumple ninguno
            Console.WriteLine("Adios");


            //*******Ejercicio1***** Realiza la suma, resta, multiplicacion o division de dos numeros, segun lo desea el usuario

            // crear variables

            string dato = "";
            double numero1 = 0.0;
            double numero2 = 0.0;
            int seleccion = 0;
            double resultado = 0.0;

            // pedir numero 1
            Console.WriteLine("Ingrese numero 1");
            dato = Console.ReadLine();
            numero1 = Convert.ToDouble(dato);

            // pedir numero 2
            Console.WriteLine("ingrese numero 2");
            dato = Console.ReadLine();
            numero2 = Convert.ToDouble(dato);

            // pedir operacion
            Console.WriteLine("1.Suma, 2.Resta, 3.Multiplicacion, 4.Division ");
            Console.WriteLine("Que operacion deseas?");
            dato = Console.ReadLine();
            seleccion = Convert.ToInt32(dato);

            // determinar si es suma

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


            // Bloques de codigo junto con el IF es decir como hacemos que se ejecute el if se cumple y tiene que hacer mas de una linea
            //*******Ejercicio2 - Convertir de metros a pies o de pies a metros, segun lo seleccione el usuario.
            Console.WriteLine();
            Console.WriteLine("Ejercicio convertir de metros a pies");

            // Variables
            string dato1 = "";
            int opcion = 0;
            Double metros = 0.0;
            Double pies = 0.0;
          

            // Pedir opcion
            Console.WriteLine("1. Convertir de metros a pies ,  2. Convertir de pies a metros");
            Console.WriteLine("que opcion deseas?");
            dato1 = Console.ReadLine();
            opcion = Convert.ToInt32(dato1);

            // Determinar si es metros a pies
            if (opcion == 1)

            {            
            
                // Pedir cantidad de metros
                Console.WriteLine("Dame los metros");
                dato1 = Console.ReadLine();
                metros = Convert.ToDouble(dato1);

                // Calcular pies
                pies = metros * 3.28;

                //Mostrar resultado
                Console.WriteLine("{0} metros son {1} pies", metros, pies);
            }

            if (opcion == 2)
            {
                //Pedir cantidad de pies
                Console.WriteLine("dame los pies");
                dato1 = Console.ReadLine();
                pies = Convert.ToDouble(dato1);

                // Calcular metros
                metros = pies / 3.28;

                // mostrar resultado

                Console.WriteLine("{0} pies son {1} metros", pies, metros);
            }

            // Ejercicio 4 - Validar si el numero es par o impar

            Console.WriteLine();
            Console.WriteLine("// Ejercicio 4 - Validar si el numero es par o impar");

            //declarar variables
            string dato2 = "";
            int numerox = 0;

            //ingresar numero
            Console.WriteLine("Ingresa el numero a validar");
            dato2 = Console.ReadLine();
            numerox = Convert.ToInt32(dato2);

            //Hacer validacion de si es par  o impar
            if (numerox % 2 == 0)
                Console.WriteLine("el numero {0} es par", numerox);
            else
                Console.WriteLine("el numero {0} es impar", numerox);

            // Ejercicio 5 - programa que pide datos solo a los mayores de 18 años
            Console.WriteLine();
            Console.WriteLine("programa que valida edada para pedir informacion");

            // Declara variables
            int edad = 0;
            int diferencia = 0;
            string nombre = "";
            string ciudad = "";
            string datom = "";

            //Pedir edad
            Console.WriteLine("ingrese su edad");
            datom = Console.ReadLine();
            edad = Convert.ToInt32(datom);

            // Si es mayor o igual que 18 solicita pedir nombre y ciduad sino lo del  bloque else
            if (edad >= 18)
            {
                Console.WriteLine("Ingrese su nombre");
                nombre = Console.ReadLine();

                Console.WriteLine("ingrese tu ciudad de nacimiento");
                ciudad = Console.ReadLine();

                Console.WriteLine("Hola{0}, me da gusta saber que usted es de{1}", nombre, ciudad);
            }
            else
            {
                // se calcula cuantos años faltan para poder ser adulto
                diferencia = 18 - edad;

                // se envia mensaje

                Console.WriteLine("lo siento, te hace falta {0} años para que pueda participar", diferencia);            
            }
        }
    }
}
