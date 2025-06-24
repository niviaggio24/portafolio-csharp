using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace E16_CicloForAnidado
{
    class Program
    {
        static void Main(string[] args)
        {

            // Este es un ejemplo de ciclos anidados 
            // El cliclo interno siempre avanza mas rapido que el externo, tenemos de un ciclo for dentro de un ciclo for
            // se puede para los ciclos do o while o combinados.

            //Varibles
            int n = 0;
            int m = 0;
            int producto = 0;

            //Imprime las tablas de multiplicar
                        
            for (n = 1; n <= 10; n++)
            // Se repite lo que esta dentro del bloque de codigo            
            {
                // Primero ejecuta este for termina cuando sea mayor a 10 y valida que n sea igual 2 y entra nuevamente
                for (m = 1; m <= 10; m++)
                {
                    
                    producto = n * m;
                    Console.WriteLine("{0} X {1} = {2}", n, m, producto);
                }
                Console.WriteLine();
            }
        }
    }
}
