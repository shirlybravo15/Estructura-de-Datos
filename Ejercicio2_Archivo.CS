using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ruta = "C:\\Users\\Sala-1\\Desktop\\Shirly\\InformaciónEstudiantes.csv";
             if (File.Exists(ruta)) 
            {
                string[] lineas= File.ReadAllLines(ruta);
                foreach (string line in lineas)
                {
                    string[] campos = line.Split(',');
                    Console.WriteLine($"Nombre: {campos[0]}, Nota: {campos[6]}");
                }
                    
            }
            using (StreamWriter sw = new StreamWriter("C:\\Users\\Sala-1\\Desktop\\Shirly\\InformaciónEstudiantes.csv", append: true)) 
            {
                sw.WriteLine("Eliana, Lopez, 22, 5, Biologia, Quimica, Segundo semestre");
            }
           
        }
         
    }
}
