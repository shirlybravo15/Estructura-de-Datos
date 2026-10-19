using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicioo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ruta = "C:\\Users\\shirl\\Downloads\\Shirly\\Ventas.txt";
            using (StreamWriter sw = new StreamWriter(ruta))
            {
                sw.WriteLine("Leche:15");
                sw.WriteLine("Arroz:25");
                sw.WriteLine("Cafe:10");
                sw.WriteLine("Jabon:8");
                sw.WriteLine("Leche:5");
                sw.WriteLine("Cafe:12");
                sw.WriteLine("Arroz:7");
            }
            string[] lineas = File.ReadAllLines(ruta);
            int total = 0;
            string productoMasVendido = "";
            int cantidadMaxima = 0;
            foreach (string line in lineas) 
            {
                string[] campos = line.Split(':');

                string producto = campos[0];
                int cantidad = int.Parse(campos[1]);

                total += cantidad;

                if (cantidad > cantidadMaxima) 
                {
                    cantidadMaxima=cantidad;
                    productoMasVendido=producto;
                }
            }

            Console.WriteLine("Total de unidades vendidas: " + total);
            Console.WriteLine("Producto mas vendido: " + productoMasVendido);
            Console.WriteLine("Cantidad: " + cantidadMaxima);
        }
    }
}
