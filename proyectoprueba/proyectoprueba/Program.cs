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
            //uso de matrices 
            int[] numeros = new int[]{2, 8, 9, 10, 1, 3};
           for (int i=0; i<numeros.Length; i++)
            {
                Console.WriteLine("Indice: {0}={1}", i, numeros[i]);
            }

            // pausa 
            Console.ReadKey();
        }

    }
}
   
    


        

    
    
    

      