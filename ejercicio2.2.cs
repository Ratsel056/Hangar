using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            double Grado;
            double r = 0.0174533;

            Console.WriteLine("Valor en Grado: ");
            Grado = double.Parse(Console.ReadLine());

            Console.WriteLine("Resultado en Radianes: " + r * Grado);

            Console.ReadKey();
        }
    }
}
