using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notas
{
    internal class PromNota
    {
        public void Nota_Promedio()
        {
            double Promedio = 0;
            double total = 0;
            try
            {
                double[] note = new double[4];

                for (int i = 1; i < note.Length; i++)
                {
                    Console.WriteLine($"Ingrese nota {i}:");
                    note[i] = Convert.ToDouble(Console.ReadLine());

                    total = note[1] + note[2] + note[3];
                    Promedio = total / 3;
                }
                if (Promedio >= 7)
                {
                    Console.WriteLine($"Su promedio es {Promedio} por lo tanto ha sido Promovido");
                }
                else
                {
                    Console.WriteLine("Reprobado");
                }
            }
            catch(Exception ex)
            { 
            Console.WriteLine(ex.Message);
            }
            
        }
    }
}
