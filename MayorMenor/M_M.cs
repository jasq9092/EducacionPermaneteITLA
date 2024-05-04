using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayorMenor
{
    internal class M_M
    {

        public void MayorMenor()
        {
            decimal num1;
            int num2;
            decimal div = 0m;

            Console.WriteLine("Ingrese el 1er Numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el 2do Numero: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            try
            {
                if (num1 > num2)
                {
                    Console.WriteLine($"La suma es:{num1 + num2} ");
                    Console.WriteLine($"Diferencia:{num1 - num2} ");
                }
                else
                {
                    Console.WriteLine($"El producto es: {num1 * num2}");

                    div = Convert.ToDecimal(num1 / num2);
                    Console.WriteLine($"La divicion es: {div}");

                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
          
        }

    }
}
