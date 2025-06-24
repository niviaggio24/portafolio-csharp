using System;

namespace GeneraInfoAleatoria
{
    class Program
    {
        static void Main(string[] args)
        {

            // Cedula con un enter text y numero telefonico
            Random rand = new Random();
            int numero = rand.Next();
            Console.WriteLine(numero);           



            // Genera índices aleatorios para nombres de cliente. EnterText

            Random rnd = new Random();
            string[] NamesClient = { "Frey Niviayo ", "Samuel Niviayo", "Leonel Messi", "Cristiano Ronaldo",
                          "Karin Benzema", "Radamel Falcao", "Albert Einstein", "Rafael Nadal",
                          "Bill gates", "John Lennon", "Alejandra", "Katty", "Sahory", "Maria",
                            "Narciza", "Leonela", "Juoaquina", "Olivia",
                            "Marta", "Tulia" };

            int mIndex = rnd.Next(NamesClient.Length);
            Console.WriteLine(NamesClient[mIndex]);


            // Genera direccion del cliente

            string[] DirClient = { "Cra 95 # 129C  60", "Carrera 3 # 18‑ 45 ", "Calle 24 N° 5-60", "Carrera 20 No. 37-54",
                          "Calle 109a N° 17-10 Sede Norte", "Carrera 1 Este No. 17 01", "Cr.15 # 82-87", "Cl.92 # 16-11",
                          "Calle 11 No. 4-14", "John Lennon", "Carrera 74 No. 82a-81.", "Carrera 6 No. 9-77", "Carrera 30 No. 48-51 Igac", "Carrera 8 No. 6-87", "Cl.70a # 10-68", "Calle 94 # 7-48", "Calle 48b sur No. 21-13",
                            "Calle 54 7-26", "Calle 10 No. 0 – 19 Este La Candelaria – Centro" };

            int mIndex1 = rnd.Next(DirClient.Length);
            Console.WriteLine(DirClient[mIndex1]);


            // Genera correp
            string[] EmaiClient = { "niviagio@gmail.com", "prueba1@test.com ", "caso1@test.com", "reclamos@hotmail.com", "noexisto@yakoo.com" };

            int mIndex2 = rnd.Next(EmaiClient.Length);
            Console.WriteLine(EmaiClient[mIndex2]);

            // Genera direccion del cliente
            byte[] bytes = new byte[3];
            rnd.NextBytes(bytes);
            for (int n = 0; n < 3; n++)
                Console.Write(bytes[n]);

            Console.ReadLine();


            /* Genera direccion 
            Random r = new Random();
            int aleatorio = r.Next(65, 91);
            string Texto = aleatorio.ToString();
            Texto = Convert.ToString(aleatorio);
            Console.WriteLine(Texto);*/




        }



    }
}
