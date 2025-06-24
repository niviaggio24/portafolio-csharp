using Ionic.Zip;
using System;
using System.IO; //Se importa libreria para 

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Los argumentos de una aplicación de consola se obtienen de la siguiente manera: https://www.it-swarm.dev/es/c%23/argumentos-de-la-aplicacion-de-consola-como-se-pasan-los-argumentos-al-metodo-main/972902896/
            
            string argumento1 = args[0];
            Console.WriteLine();
            Console.WriteLine(argumento1);

            // 2. Recuerde que para consultar archivos de una carpeta se usa DIrectory del namespace System.IO:

            string[] files = Directory.GetFiles(argumento1);  // Se llama al metodo obtener archivos de la ruta guardada en el argumento que es C:\ArchivosPDF           


            // 3.Para comprimir se instalo el nuget DotNetZip y se importa la libreria Ionic.Zip https://www.youtube.com/watch?v=BD4BZ3rlFcY            
            //*******************************************************************************************************************************//
            /*
              using (ZipFile zip = new ZipFile())
              {
                zip.Password = "pass";  // para que funciones es necesario primero utilizar el metodo password
                zip.AddFile(@"C:\\ArchivosPDF2\\PXChange.xml");
                zip.Save(@"C:\\ArchivosPDF2\\Zipped.zip");               
              }                
             */
            //*******************************************************************************************************************************//

            Console.WriteLine();
            Console.WriteLine("listado de archivos en el directorio");
            Console.WriteLine();

            // Se crea el for para iterar todos los archivos que se encuentren en la carpeta y por cada uno le asigna la clave y lo agrega al archivos comprimido .
            //*******************************************************************************************************************************//
            /*
            using (ZipFile zip = new ZipFile())
            {
                for (int n = 0; n < files.Length; n++)
                 
                {
                    zip.Password = "pass";                    
                    Console.WriteLine(files[n]);
                    zip.AddFile(files[n]);
                }

                zip.Save("C:\\ArchivosPDF2\\Comprimido.zip");

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Sus Archivos secuestrados");                
            */

            // Se intenta con el foreach dado que es mas limpio para iterar. 
            //*******************************************************************************************************************************//
            
            using (ZipFile zip = new ZipFile())
            {
               foreach (var item in files)  // Itera arreglo de archivs
                 
                {
                    zip.Password = "123456";
                    Console.WriteLine(item);
                    zip.AddFile(item);
                }

                // Comprime archivos
                zip.Save("C:\\ArchivosPDF2\\Comprimido.zip");
                Console.WriteLine(); //Espacio en blanco
                Console.WriteLine(); //Espacio en blanco
                Console.WriteLine("Sus Archivos secuestrados"); //Imprime mensaje
            }
        }
    }
}


















































// Ahora para aplicar conceptos de POO y principios solic;

// 1. Se creo la clase METODOFILES
// 2. Se creo interfaz IMETODOFILES por estandar se coloca la I 
// 3. A las clases que implementen  de esa interdaz 
// 4. Con los dos puntos y llamando a la interfaz en la clase METODOFILES, le estoy diciendo que implemente esa interfaz.  ejemplo public class MetodosFiles : IMetodosFiles
// 5. En la clase program abriamos la carpeta y sacabamos los nombres archivos lo pasamos a la clase METODOSFILES
// 6. Despues creo la interfaz llamada Imanagefiles pero quien va a resolver o implementar la logica de esa interfaz es la clase METODO FILES

// LUEGO MAS ADELANTE PODRIA DECIR QUE NO QUIERO UTILIZAR la clase METODOSFILES PORQUE NO ES LO SUFICIENTEMENTE COMPLETA y CREO OTRA CLASE LLAMADA METODOFILES2 que tambien implemneta la interface  IMETODOSFILES
/// ENTONCES SE CAMBIO Y SIGUE FUNCIONANDO COMO ESTABA   (ESTA ES LA IDEA DE LAS INTERFACES)

///  CUANDO UNO TIENE MUCHOS PROYECTOS Y HAY CIERTOS PROYECTOS QUE SE ESPECIALIZAN EN OTRAS COSAS. Por ejemplo no tengo mi proyecto de consola sino mi proyecto de consola. La idea de este proyecto web es que centre
///  en manejo de la intefaces, la paginas , los stilos. entoncs hay otro proyecto donde se manejan todos los calculos y otras cosas le dicen BUSiness logic debajo de este proyecto se creo otro que su funcion es 
///  accder a la base de datos por ejemplo con nombre de DALL. Entonces el PROYECTO WEB Intancia Al PROYECTO BUSINESS LOGIG y Este proyecot de BUSINESS logiv Instancia al proyecto DALl que es de la base de datos.

///  la idea de la inyeccion de dependencias por ejemplo el proyecto DALL es muy explicito hacia el motor de base de datos. Entonxs yo tengo un motor de base de datos de ORACLE entocns el proyecto DALL debe estar
///  muy optimizado para pegarle al todo el oracle, ENTOCS si despues ya no tengo la base de datos en ORACLE SIno quiero pasarme a SQLSERVER el DALL se especializa, es decir me toca desarrollar todo un DALL
///  que se especialice en un motor de base datos sql o mysql, El punto es que cada vez que dese cambiar la BD me toca desarrolla un DALL. POR lo cual eso es un cambio refuerte para toda la aplicacion entocns
///  con la INYECCION DE dependencias Por un lado quitar ese fuerte acomplamiento. por un lado yo quiero quitar mi motor de base de datos por otro 




// 2. por estandar debe tener el mismo nombre
/// se creao una interfaz llamada I managerfiles filesuna clase que implementa esta interfaz
/// aca se implemneto los metodos de esta interfaz
/// 
// abrri la carperta sacar todos losnombre se pasaron a la clase metodosfiles
// Ahora voy a declarar una interfaz llamada manage files pero quien va implementar la logica de esta interfaz es la




