using System;

namespace E3_CalcularAreaTotalCasa
{
    class Program
    {
        static void Main(string[] args)
        {

            // Calcular el area total de una casa con tres habitaciones. Como se calcula? El area total de la casa va a ser igual a la suma del area de cada una de las habitaciones.
            // Como calculamos el area de un habitacion ? Simplemente se multiplican las medidas del ancho por el largo de esa habitacion.

            // Declarar valores ( Siempre es lo primero)

            // Calcular area de habitacion 1

            double ancho1 = 4.3;
            double largo1 = 4.0;
            double area1 = 0.0;

            // Calcular area de habitacion 2

            double ancho2 = 5.0;
            double largo2 = 6.7;
            double area2 = 0.0;


            // Calcular area de habitacion 3

            double ancho3 = 2.89;
            double largo3 = 3.54;
            double area3 = 0.0;

            // define variable para guardar area total de la casa
            double areatotal = 0.0;


            // Calcular area de habitacion 1
            area1 = ancho1 * largo1;

            // Calcular area de habitacion 2
            area2 = ancho2 * largo2;

            // Calcular area de habitacion 3
            area3 = ancho3 * largo3;

            // Calcular area total

            areatotal = area1 + area2 + area3;

            Console.WriteLine("El area total de la casa es {0}", areatotal);













            // Mostrar resulados

        }
    }
}
