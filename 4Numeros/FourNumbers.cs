using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Numeros
{
    internal class FourNumbers
    {

        public void Numeros()
        {
            //int numbers;
            int suma =0;
            int producto = 0;

            try
            {
                Console.WriteLine("Ingrese los numeros a calcular");
                int[] number = new int[5];

                for (int i = 1; i < 5; i++)
                {
                    Console.WriteLine($"Ingrese el # {i}:");
                    number[i] = Convert.ToInt32(Console.ReadLine());

                    suma = number[1] + number[2];
                    producto = number[3] * number[4];
                }
                Console.WriteLine("----------------------------------------------------------");

                Console.WriteLine($"El resultado de la suma es: {suma}");
                Console.WriteLine($"El resultado de la multiplicacione es: {producto}");

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
