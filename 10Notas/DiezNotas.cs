using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10Notas
{
    internal class DiezNotas
    {
        public void Notas()
        {
            int nt = 0;
            int i = 0;
            int mayor = 0;
            int menor = 0;

            try
            {
                Console.WriteLine("¿Cuantas notas va a ingresar? ");
                nt = Convert.ToInt32(Console.ReadLine());
                int[] notas = new int[nt];

                while (i < notas.Length)
                {
                    Console.Write($"Ingrese la nota {i + 1}: ");
                    notas[i] = Convert.ToInt32(Console.ReadLine());

                    if (notas[i] >= 7)
                    {
                        mayor++;

                    }
                    else
                    {
                        menor++;
                    }

                    i++;
                }
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine($"Notas mayores o iguales a 7: {mayor}");
                Console.WriteLine($"Notas menores a 7: {menor}");

            }
            catch (Exception e) 
            {
                Console.WriteLine("El sistema se detuvo por la siguiente razon: "+e.Message);            
            }
           

        }
    }
}
