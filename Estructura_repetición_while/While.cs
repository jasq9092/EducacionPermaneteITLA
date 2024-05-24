using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_repetición_while
{
    internal class While
    {
        public void repeating()
        {
            int[] promedio = new int[10];
            int i = 0;
            int suma = 0;
            int prome = 0;
            try
            {
                while (i < promedio.Length)
                {
                    Console.Write($"Ingrese el #{i}: ");
                    promedio[i] = Convert.ToInt32(Console.ReadLine());

                    suma = promedio[0] + promedio[1] + promedio[2] + promedio[3] + promedio[4] +
                         promedio[5] + promedio[6] + promedio[7] + promedio[8] + promedio[9];
                    prome = suma / 10;
                    i++;
                }
                Console.WriteLine();
                Console.WriteLine($"La suma es: {suma}");
                Console.WriteLine($"El Promedio es: {prome}");

            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            
            }
            

        }
    }
}
