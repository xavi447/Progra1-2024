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
            //estructuras de control 
            //1 if. pedir l usuario ingresar su edad si es mayor de edad que le diga bienvenido
            Console.Write("Edad: ");
            int edad = int.Parse(Console.ReadLine());

            if (edad >= 18)
            {
                Console.WriteLine("Bienvenidos al mundo de las esponsabilidades");
            }
            else
                Console.WriteLine("Eres un adolecente disfruta de la vida");

            //pausa
            Console.ReadLine();
        }
    }
}
