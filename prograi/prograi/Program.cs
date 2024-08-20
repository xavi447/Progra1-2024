﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prograi
{
    class Program
    {
        static void Main(string[] args)
            //uso de funciones
        {
            Console.Write("Ingrese la serie de numeros separados por comas: ");
            String serie = Console.ReadLine();
            String [] numeros = serie.Split(',');
            
            Console.WriteLine("La media aritmetica es: {0}, y la desviacion tipica es: {1}; y la medida armonica es: {2}", media(numeros), tipica(numeros), armonica(numeros));

            Console.ReadLine();
        }
        static double media(string[] serie)
        {
            double media = 0;
            foreach (string num in serie)
            {
                media += int.Parse(num);
            }
            return media / serie.Length;
        }
        static double tipica(string[] serie)
        {
            double tipica = 0,
                     m = media(serie);
            foreach (string num in serie)
            {
                tipica += Math.Pow(int.Parse(num) - m, 2);
            }
            tipica = Math.Sqrt(tipica / serie.Length);
            return Math.Round(tipica);
        }
        static double armonica (string [] serie) {
            double armonica = 0;
            foreach (string num in serie)
            {
                armonica += 1 / int.Parse(num);
            }
            armonica = serie.Length / armonica;
            return Math.Round(armonica);
        }
    }
}
        
        
    
