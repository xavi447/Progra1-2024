using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoprueba
{
    class Program
    {
        static void Main(string[] args)
        {
            //prioridad de los operadores aritmeticos
            // obtener la nota final de la materia de prograI
            Console.Write("lab1: ");
            double lab1 = double.Parse(Console.ReadLine());

            Console.Write("lab2: ");
            double lab2 = double.Parse(Console.ReadLine());

            Console.Write("parcial1: ");
            double parcial1 = double.Parse(Console.ReadLine());

            double c1 = lab1 * 30 / 100 + lab2 * 30 / 100 + parcial1 * 40 / 100;
            Console.WriteLine("la nota de c1 es: {0}", c1);

            //computo2
            Console.Write("lab1: ");
            double lab13 = double.Parse(Console.ReadLine());

            Console.Write("lab2: ");
            double lab4 = double.Parse(Console.ReadLine());

            Console.Write("parcial2: ");
            double parcial2 = double.Parse(Console.ReadLine());

            double c2 = lab13 * 30 / 100 + lab4 * 30 / 100 + parcial2 * 40 / 100;
            Console.WriteLine("la nota de c2 es: {0}", c2);
            // tarea de nota c3 y nota final.
            //pause
            Console.ReadLine();
        }
    }
}
