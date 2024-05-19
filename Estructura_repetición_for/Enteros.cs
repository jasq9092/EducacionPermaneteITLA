using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_repetición_for
{
    internal class Enteros
    {
        public void NEnteros()
        {
            int[] VM = new int[5];
            int M_I = 0;
            try
            {
                for (int i = 0; i < VM.Length; i++)
                {
                    Console.Write($"Introducir el # {i}: ");
                    VM[i] = Convert.ToInt32(Console.ReadLine());

                    if (VM[i] >= 1000)
                    {
                        M_I = M_I + 1;
                    }

                }
                Console.WriteLine("------------------------------------------------------------");
                Console.WriteLine($"Numeros mayores o Iguales a 1,000: { M_I}");
            }

                catch(Exception ex)
            {
                Console.WriteLine($"Su sistema se ha detenido por la siguiente razon: {ex.Message}");
            }
           



        }

    }
}
