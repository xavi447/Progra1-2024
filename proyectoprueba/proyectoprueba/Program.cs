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
            int[,] matriz = new int[,] {

                {2,8,6,7,5 },
                {7,9,1,6,3 }
            };
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 5; j++)
                    Console.Write("{0} ", matriz[i, j]);
                {
                    Console.WriteLine("\n");
                }
            }
            // pausa 
            Console.ReadKey();
        }

    }
}
   
    


        

    
    
    

      