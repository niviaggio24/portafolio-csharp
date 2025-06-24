using System;

namespace E13_CicloFor
{
    class Program
    {
        static void Main(string[] args)
        {

            //Ciclo FOR Estructuras repetitivas Se debe utilizar si en el problema se sabe cuantas veces se va a repetir
            // Partes de ciclo For:
            // Inicializacion: Se va hacer uso de una varible de conteo y se debe incializar en que numero debe arrancar siempre va en 0  Int = 0: 
            // Condicion: Nos sirve para saber si continuemos contando o si llegaamos aca colocamos hasta que numero va a llegar y con esa expresion si se va a cumplir Codigo a ejecutar: 
            // Si cumple es que ya llego a su fin y continu con el resto de programa
            // Ejecucion codigo : Aca va un bloque de codigo que quier quese haga un switch o if cualquier codigo valido
            // Incremento: es esta seccion incrementamos la variable de conteo o inicializacion para que le vaya aumentando hasta que se cumple

            //********************EJEMPLO DE UN FOR BASICO***********************************

            Console.WriteLine("//********************EJEMPLO DE UN FOR BASICO***********************************//");
            Console.WriteLine();
            //declaro variable
            int n = 0;

            //Inicializacion + Condicion + incremento
            for (n = 0; n < 5; n = n + 1)
            {
                Console.WriteLine("hola {0}",n ); //            
            }


            //********************EJEMPLO DE UN CONTADOR***********************************

            Console.WriteLine("//********************EJEMPLO DE UN CONTADOR***********************************//");
            Console.WriteLine();

            int n1 = 0; //variable del for inicializada en contador
            int n2 = 0; //variable del for inicializada en acumulador
            int contador = 0;
            int acumulador = 0;
            int valor = 0;
            string dato = "";


            for (n1 = 0; n1 < 10; n1 = n1 + 1)
            {
                Console.WriteLine("en cliclo");
                contador = contador + 3;            
            }

            Console.WriteLine("El contador tiene {0}", contador); // El contador siempre increment o decrementa en un valor CONSTANTE puede -


            //********************EJEMPLO DE UN CONTADOR***********************************

            // El acumulador es unja variable tambien solo que  a diferencia del contador el acumulador va ir incrementand o decrementando en valores que pueden variar, es decir en el acumulador en alguna oportunidad le aumentamos uno
            // luego le aumentamos 3 7 o luego 2 etc, Es decir el acumulador va ir incrementando o decrementando pero no en un valor CONSTANTE sino que puede incrementar o decrementar en cualquier valor.


            Console.WriteLine("//********************EJEMPLO DE UN ACUMULADOR***********************************//");
            Console.WriteLine();

            // El Operador ++ adiciona uno a a la variable 
            // n= n+1 es igual a n++

            for (n2 = 0; n2 < 5; n2++)
            {
                Console.WriteLine("Ingrese un numero");
                dato = Console.ReadLine();
                valor = Convert.ToInt32(dato);

                acumulador = acumulador + valor;            
            }

            Console.WriteLine("el acumulador es {0}", acumulador);



            Console.WriteLine("//********************CALCULAR EL PROMEDIO DE 3 NUMEROS***********************************//");
            Console.WriteLine();
            Console.WriteLine();
          
            //Variables
            double numero1 = 0.0;
            double numero2 = 0.0;
            double numero3 = 0.0;
            double promedio = 0.0;            
            string dato1 = "";

            // Pedir numero 1
            Console.WriteLine("Ingrese numero 1");
            dato1 =  Console.ReadLine();
            numero1 = Convert.ToDouble(dato);

            // Pedir numero 3
            Console.WriteLine("Ingrese numero 2");
            dato1 = Console.ReadLine();
            numero3 = Convert.ToDouble(dato);

            // Pedir numero 3
            Console.WriteLine("Ingrese numero 3");
            dato1 = Console.ReadLine();
            numero3 = Convert.ToDouble(dato);

            //Calcular promedio
            promedio = (numero1 + numero2 + numero3) / 3.0;

            //mostrar resultado

            Console.WriteLine("El promedio es {0}", promedio);


            Console.WriteLine("//********************CALCULAR EL PROMEDIO DE CUALQUIER CANTIDAD DE NUMEROS CON EL FOR***********************************//");
            Console.WriteLine();
            Console.WriteLine();

            //variables
            int cantidad = 0;        // Cantidad en numero ingresa
            int n4 = 0;              // variable contador del for inicializada 
            double sumatoria = 0.0;  // funciona como acumulador de lso numeros que ingresan
            double valor9 = 0.0;     // en esta variable se captura el numero ingresado
            double promedio4 = 0.0;  // va a guardar el resultado de la sumatoria de los numeros dividido en la cantidad.
            string dato9 = "";

            //Pedir numeros
            Console.WriteLine("Ingrese la cantidad de numeros");
            dato9 = Console.ReadLine();
            cantidad = Convert.ToInt32(dato9);

            //
            //n4 = n4 + 1 -> n4++ es mas eficiente

            for (n4 = 0; n4 < cantidad; n4++) 
            {
                Console.WriteLine("Ingrese un numero");
                dato9 = Console.ReadLine();
                valor9 = Convert.ToDouble(dato9);

                // es lo mismo que sumatoria = sumatoria + valor4;
                sumatoria += valor9;            
            }

            promedio4 = sumatoria / cantidad;

            // Mostrar resultados
            Console.WriteLine("El promedio de los numeros es {0}", promedio4);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("//********************VALIDACIONES DEL CICLO FOR *******************************************************************//");
            Console.WriteLine("//********************Rango de conteo, Incremento en diferentes valores y ciclo regresivo **************************//");
            Console.WriteLine("//********************ciclo que va del 3 al 7 regresivo ************************************************************//");
            Console.WriteLine();

            //Definir variables
            int n5 = 0;  // contador de primer for 
            int n6 = 0;  // contador de segundo for 
            int n7 = 0;  // contador del tercer for 

            //Ciclo de cierto numero a otro
            for (n5 = 3; n5 <= 7; n5++)
                Console.WriteLine(n5);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("//********************ciclo con incremento de dos en dos hasta 100**************************************************//");
            //Ciclo de dos en dos
            for (n6 = 0; n6 < 20; n6 = n6 + 2)
                Console.WriteLine("{0},", n6);


            Console.WriteLine();
            Console.WriteLine("//********************ciclo que va en forma regresiva *************************************************************//");

            //Console.WriteLine("Ciclo que cuenta regresivamente");
            // n7-- -> n7= n7-1
            for (n7 = 10; n7 > 0; n7--)
                Console.WriteLine(n7);


            Console.WriteLine();
            Console.WriteLine("//********************Errores del ciclo for *************************************************************//");
            Console.WriteLine("//********colocar el ; no colocar el bloque {} o inicializar mas la variables del contarodr**************//");

            int x = 0;
            int y = 0;

            Console.WriteLine("ANTES DEL CICLO");
            for (x = 0; x < 5; x++)
                {
                Console.WriteLine("En el ciclo");
                Console.WriteLine(x);
                }
            Console.WriteLine("Fuera del ciclo");
        }
    }
}