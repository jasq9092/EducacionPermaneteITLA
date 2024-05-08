using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplo
{
    internal class Multi
    {
        public void Modulo()
        {
            int mul3 = 0;
            int mul5 = 0;
            int valor;
            int cant;
            int mix = 0;

            try
            {
                Console.WriteLine("Ingresa Cantidad numero a evaluar: ");
                cant = Convert.ToInt32(Console.ReadLine());

                for (int i = 1; i <= cant; i++)
                {
                    Console.WriteLine($"Ingrese el valor {i}: ");
                    valor = Convert.ToInt32(Console.ReadLine());
                    if(valor % 3 == 0 && valor % 5 == 0)
                    {
                        mul3 += 1;
                        mul5 += 1;
                        mix +=1;
                    }

                    else if (valor % 3 == 0)
                    {
                        mul3 += 1;
                    }

                    else if (valor % 5 == 0)
                    {
                        mul5 +=1;
                    }

                }
                    Console.WriteLine($"Multiplo de 3: {mul3}");
                    Console.WriteLine($"Multiplo de 5: {mul5}");
                    Console.WriteLine($"Numeros Mixtos: {mix}");
            }

            catch (Exception ex)
            {
                Console.WriteLine($"El programa dejo de funcionar por la siguiete razon: {ex.Message}");
            }
            


        }

    }
}
