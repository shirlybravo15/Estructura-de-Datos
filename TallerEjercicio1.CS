using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ejercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ruta = "C:\\Users\\shirl\\Downloads\\Shirly\\EjercicioE1.csv";
            using (StreamWriter sw = new StreamWriter(ruta))
            {
                sw.WriteLine("Nombre,Juego,Edad,Ciudad,Comida Favorita,Asignatura Fvaorita");
                sw.WriteLine("Katerine,Minecraft,20,Santa Marta,Pizza,Matematicas");
                sw.WriteLine("Luis,Futbol,22,Barranquilla,Hamburguesa,Informatica");
                sw.WriteLine("Maria,Robolox,18,Cartagena,Sushi,Biologia");
                sw.WriteLine("Carlos,Free Fire,21,Bogota,Salchipapa,Historia");
                sw.WriteLine("Sofia,Fornite,19,Medellin,Lasaña,Ingles");
                sw.WriteLine("Pedro,Call of Duty,23,Cali,Arroz de pollo,Educacion Fisica");
            }
            Console.WriteLine("Archivo creado exitosamente");
        }
    }
}
