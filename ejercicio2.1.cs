using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capitulo_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Lados;
            int valorlados;
            int perimetro;


            Console.WriteLine("Introducir Cantidad de Lado del Poligono: ");
            string l = Console.ReadLine();
            Lados = int.Parse(l);

            Console.WriteLine("Valor de Lados: ");
            valorlados = int.Parse(Console.ReadLine());

            perimetro = Lados * valorlados;
            Console.Write("Perimetro: " + perimetro);

            Console.ReadKey();
        }
    }
}
