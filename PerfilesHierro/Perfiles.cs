using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfilesHierro
{
    internal class Perfiles
    {

        public void Hierro()
        {
            int size = 0;
            int i = 0;
            decimal per1= 1.20m;
            decimal per2= 1.30m;
            int cantidad = 0;
;
            try
            {
                Console.WriteLine("Ingrese la cantidad de perfiles a procesar: ");
                size = Convert.ToInt32(Console.ReadLine());
                decimal[] perfiles = new decimal[size];

                
                while (i < perfiles.Length)
                {
                    Console.WriteLine($"Ingrese el perfil #{i+1}: ");
                    perfiles[i] = Convert.ToDecimal(Console.ReadLine());

                    if (perfiles[i] >= per1 && perfiles[i] <= per2)
                    {
                        cantidad++;
                    }
                    i++;
                  
                }
                        Console.WriteLine($"Piezas Aptas: {cantidad}");

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
           


        }
    }
}
