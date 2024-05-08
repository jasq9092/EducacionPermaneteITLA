using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumaPromedio
{
    internal class Suma_Promedio
    {

        public void Promedio()
        {
            double suma = 0;
            double promedio = 0;

            try
            {
                int[] sumando = new int[5];

                for (int i = 1; i < sumando.Length; i++)
                {
                    Console.WriteLine($"Ingrese el # {i}");
                    sumando[i] = Convert.ToInt32(Console.ReadLine());

                    suma = sumando[1] + sumando[2] + sumando[3] + sumando[4];
                    promedio = suma / 4;
                }

                Console.WriteLine($"La suma es: {suma}");
                Console.WriteLine($"El promedio es: {promedio}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           


        }
    }
}
