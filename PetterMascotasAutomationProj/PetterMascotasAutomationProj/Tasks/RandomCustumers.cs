using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetterMascotasAutomationProj.Tasks
{
    // This class has the methods that generate the random data.

    public class RandomCustumers
    {
        // Method that generates ID Card ramdom

        public static int IdsRandom()
        {            
            Random rand = new Random();
            int numero = rand.Next();
            return numero;

        }

        // Method that generates names ramdom
        public static string namesRandom()
        {
            Random rnd = new Random();
            string[] NamesClient = { "Frey Niviayo ", "Samuel Niviayo", "Leonel Messi", "Cristiano Ronaldo",
                          "Karin Benzema", "Radamel Falcao", "Albert Einstein", "Rafael Nadal",
                          "Bill gates", "John Lennon", "Alejandra", "Katty", "Sahory", "Maria",
                            "Narciza", "Leonela", "Juoaquina", "Olivia",
                            "Marta", "Tulia" };

            int mIndex = rnd.Next(NamesClient.Length);
            return NamesClient[mIndex]; 
        }


        // Method that generates Address ramdom
        public static string addressRandom()
        {
            Random rnd = new Random();
            string[] DirClient = { "Cra 95 # 129C  60", "Carrera 3 # 18‑ 45 ", "Calle 24 N° 5-60", "Carrera 20 No. 37-54",
                          "Calle 109a N° 17-10 Sede Norte", "Carrera 1 Este No. 17 01", "Cr.15 # 82-87", "Cl.92 # 16-11",
                          "Calle 11 No. 4-14", "John Lennon", "Carrera 74 No. 82a-81.", "Carrera 6 No. 9-77", "Carrera 30 No. 48-51 Igac", "Carrera 8 No. 6-87", "Cl.70a # 10-68", "Calle 94 # 7-48", "Calle 48b sur No. 21-13",
                            "Calle 54 7-26", "Calle 10 No. 0 – 19 Este La Candelaria – Centro" };

            int mIndex1 = rnd.Next(DirClient.Length);            
            return DirClient[mIndex1]; 
        }

        // Method that generates phone ramdom
        public static int phoneRandom()
        {            
            Random rand = new Random();
            int numero = rand.Next();
            return numero;
        }

        // Method that generates Email ramdom
        public static string emailRandom()
        {
            Random rnd = new Random();
            string[] EmaiClient = { "niviagio@gmail.com", "prueba1@test.com ", "caso1@test.com", "reclamos@hotmail.com", "noexisto@yakoo.com" };

            int mIndex2 = rnd.Next(EmaiClient.Length);            
            return EmaiClient[mIndex2];
        }        
    }
}
