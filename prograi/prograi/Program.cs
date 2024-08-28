using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace prograi
{
    class Program
    {
        static void Main(string[] args)
        {
            string continuar = "s";
            while (continuar == "s")
            {
                Console.WriteLine("***Menu de Opciones***");
                Console.WriteLine("Opcion 1: Impuesto a las actividades economicas");
                Console.WriteLine("Opcion 2: conversor de superficie");
                int opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Impuesto();
                        break;
                    case 2:
                        Superficie();
                        break;


                }

                Console.ReadLine();
            }
        }
        static void Impuesto()
        {
            Console.WriteLine("impuesto de actividad economica");
            decimal actividad = Convert.ToDecimal(Console.ReadLine());
            decimal rango = 1000.01m;
            decimal valor = 1000m;
            decimal adicional = 3m;
            decimal precio = 3m;
            decimal monto;

            decimal diferencia = actividad - rango;
            monto = (diferencia / valor) * adicional + precio;

            Console.WriteLine("l valor economico de la actividad economica es: $" + actividad);
            Console.WriteLine("monto a pagar es: $" + monto.ToString("f2"));
            Console.ReadLine();
              
                
            


        }
        static void Superficie()
        {
            string[] areas = { "Pie cuadrado", "Vara cuadrada", "Yarda Cuadrada", "Metro cuadrado", "Tareas", "Manzana", "Hectarea" };
            double[] medida = { 1, 0.132, 0.11, 0.09, 0.000147, 0.000014, 0.0000092 };

            while (true)
            {
                Console.WriteLine("Elija la moneda que desea convertir");
                for (int i = 0; i < areas.Length; i++)
                    Console.WriteLine($"{i + 1}. {areas[i]}");
                int inicio = int.Parse(Console.ReadLine() ?? "0") - 1;
                if (inicio < 0 || inicio >= areas.Length)
                {
                    Console.WriteLine("Opcion no validad");
                    continue;
                }

                Console.WriteLine("elegistes la opcion {0} ahora elige a que unidad de area la quieres convertir:", inicio + 1);
                for (int i = 0; i < areas.Length; i++)
                    Console.WriteLine($"{i + 1}. {areas[i]}");
                int salida = int.Parse(Console.ReadLine() ?? "0") - 1;
                if (salida < 0 || salida >= areas.Length)
                {
                    Console.WriteLine("Opcion no valida");
                    continue;
                }

                Console.WriteLine("Ingresa la cantidad: ");
                double cantidad = double.Parse(Console.ReadLine());

                double resultado = cantidad * (medida[salida] / medida[inicio]);
                Console.WriteLine($"{cantidad} {areas[inicio]} = {resultado} {areas[salida]}");
                Console.ReadLine();
            }
        }


    }


}



    
