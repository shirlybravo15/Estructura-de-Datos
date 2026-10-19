using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ruta = "C:\\Users\\shirl\\Downloads\\Shirly\\Inventario.csv";
            using (StreamWriter sw = new StreamWriter(ruta))
            {
                sw.WriteLine("ID,Producto,Cantidad,Precio");
                sw.WriteLine("P001,Leche,7,3800.00");
                sw.WriteLine("P002,Arroz,25,4500.00");
                sw.WriteLine("P003,Cafe,4,12000.00");
                sw.WriteLine("P004,Jabon,12,2500.00");
            }
            string[] lineas = File.ReadAllLines(ruta);
            for (int i = 1; i < lineas.Length; i++) 
            {
                string[] campos= lineas[i].Split(',');
                int Cantidad= int.Parse(campos[2]);
                if (Cantidad < 10)
                {
                    Console.WriteLine($"{campos[1]}- Cantidad: {Cantidad}");
                }

            }
        }
    }
}
