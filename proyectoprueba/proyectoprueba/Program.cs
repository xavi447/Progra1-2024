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



            string continuar = "s";
            while (continuar == "s")
            {

                Console.WriteLine("*** MENU ***");
                Console.WriteLine("1. Promedio Notas");
                Console.WriteLine("2. Promedio Serie Numeros");
                Console.WriteLine("3. Clasificacion edad");
                Console.WriteLine("4. Salir");
                Console.Write("Opcion: ");
                int opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1://if(opcion==1)
                        promedio();
                        break;
                    case 2: //if(opcion==2)
                        Serie();
                        break;
                    case 3://if(opcion==3)
                        clasificacionEdad();
                        break;
                    case 4://if(opcion==4)
                        continuar = "n";
                        break;
                    default://else
                        Console.WriteLine("opcion incorrecta \n\n");
                        break;
                }
                Console.Write("Desea continuar presione s, sino cualquier tecla.");
                continuar = Console.ReadLine();

            }
            
        }
            static void Serie()
            {
                int[] serie = new int[] { 5, 4, 6, 8, 9, 10 };
                int suma = 0;
                foreach (int num in serie)
                {
                    suma = suma + num;
                }
                double prom = suma / serie.Length;
                Console.WriteLine("la suma es: {0}, el promedio: {1}", suma, prom);

                //pausa
                Console.ReadLine();

            }
            static void clasificacionEdad()
            {
                Console.Write("Edad: ");
                int edad = int.Parse(Console.ReadLine());



                //pausa
                Console.ReadLine();
                if (edad < 0)
                {
                    Console.WriteLine("Edad incorrecta");
                }
                else if (edad <= 2)
                {
                    Console.WriteLine("Eres un bebe");
                }
                else if (edad <= 12)
                {
                    Console.WriteLine("Eres un niño");
                }
                else if (edad < 18)
                {
                    Console.WriteLine("Eres un adolecente");
                }
                else if (edad <= 65)
                {
                    Console.WriteLine("Bienvenido al mundo de la responsabilidad");
                }
                else if (edad <= 80)
                {
                    Console.WriteLine("Eres un adulto mayor");
                }
                else
                {
                    Console.WriteLine("Larga vida");
                }






            }
            static void promedio() {
                Console.WriteLine("ingrese las notas del computo 1");
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

                //computo 3
                Console.WriteLine("ingrese las notas del computo 3");
                Console.Write("lab1: ");
                double lab5 = double.Parse(Console.ReadLine());

                Console.Write("lab2: ");
                double lab6 = double.Parse(Console.ReadLine());

                Console.Write("parcial3: ");
                double parcial3 = double.Parse(Console.ReadLine());

                double c3 = lab5 * 30 / 100 + lab6 * 30 / 100 + parcial3 * 40 / 100;
                Console.WriteLine("la nota de c3 es: {0}", c3);
                // nota final
                double NF = c1 + c2 + c3;
                Console.WriteLine("la nota final de la materia es:{0} ", NF / 3);


            }
        }

    }


   
    


        

    
    
    

      