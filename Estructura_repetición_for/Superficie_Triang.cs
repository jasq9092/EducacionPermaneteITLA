using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_repetición_for
{
    internal class Superficie_Triang
    {
        public void Triangulo()
        {

            try
            {
                decimal par1 = 0;
                decimal par2 = 0;
                decimal par3 = 0;
                int cant = 0;

                decimal[] Base = new decimal[3];
                decimal[] Altura = new decimal[3];

                for (int i = 0; i < Base.Length; i++)
                {
                    Console.WriteLine($"Introduzca la base #{i}: ");
                    Base[i] = Convert.ToDecimal(Console.ReadLine());
                   
                    Console.WriteLine($"Introduzca la Altura #{i}: ");
                    Altura[i] = Convert.ToDecimal(Console.ReadLine());                        
                    
                }

               

                par1 = Base[0] * Altura[0] / 2;
                par2 = Base[1] * Altura[1] / 2;
                par3 = Base[2] * Altura[2] / 2;




                if (par1 > 12)
                {
                    cant++;
                }
                if (par2 > 12 )
                {
                    cant ++;
                }
                if (par3 > 12)
                {
                    cant++;
                }

                Console.WriteLine($"Superficies mayores a 12: {cant}");


                Console.WriteLine($"Datos del tringulo 1: Base:{Base[0]}, Altura: {Altura[0]}, Superficie: {par1}");
                Console.WriteLine($"Datos del tringulo 2: Base:{Base[1]}, Altura: {Altura[1]}, Superficie: {par2}");
                Console.WriteLine($"Datos del tringulo 3: Base:{Base[2]}, Altura: {Altura[2]}, Superficie: {par3}");
            }

            catch (Exception ex) 
            { 
            
            Console.WriteLine(ex.Message);
            }
            
        }

    }
}
