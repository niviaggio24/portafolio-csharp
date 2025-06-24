using System;
using System.Diagnostics;
using System.Linq.Expressions;

namespace E12_EjerciciosPlanetconSWITCH
{
    class Program
    {
        static void Main(string[] args)
        {

            // Hacer un programa que calcule el peso de la tierra al peso de mercurio, venus o marte.

            //Variables
            int opcionpant = 0;
            double pesotierra = 0.0;
            double pesoplaneta = 0.0;
            string dato = "";

            // 1. Pedir planetas pos pantalla

            Console.WriteLine("1. Mercurio, 2. Venus, 3. Marte");
            dato = Console.ReadLine();
            opcionpant = Convert.ToInt32(dato);


            // 2. Pedir  el peso en la tierra

            Console.WriteLine("ingrese el peso en la tierra");
            dato = Console.ReadLine();
            pesotierra = Convert.ToInt32(dato);


            // 3. Verificar en que planeta fue

            switch(opcionpant)
                {
                // Caso Mercurio para calcularlo se debe tomar el peso de la tierra por el factor de conversion en mercurio 
                case 1:
                    pesoplaneta = pesotierra * 0.38;
                    break;

                // Caso Venus
                case 2:
                    pesoplaneta = pesotierra * 0.91;
                    break;

                // Caso Marte
                case 3:
                    pesoplaneta = pesotierra * 0.38;
                    break;
            }

            //Mostrar resultados
            Console.WriteLine("Tu peso en ese planeta es tal {0}", pesoplaneta);

        }
    }
}
