using System;
using System.IO;

namespace TC8_Operaciones
{
    class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                Console.WriteLine("Introduce el valor a:");
                // Transformar a float lo que se introduzca en la consola
                float a = float.Parse(Console.ReadLine());

                Console.WriteLine("Introduce el valor b:");
                float b = float.Parse(Console.ReadLine());

                // float a = 10f;
                // float b = 2f;

                float result = a / b;
                Console.WriteLine($"{a} / {b} = {result} ");

                using(StreamWriter sw = new StreamWriter("operacion.tx"))
                {
                    sw.WriteLine($"{a} / {b} = {result}");
                }
            }
            catch(SystemException)
            {
                // Si ocurre una excepcion en el try, se ejecuta el código en este catch
                Console.WriteLine("Error: Porfavor introduce números válidos");
                throw;
            }


        }
    }
}
