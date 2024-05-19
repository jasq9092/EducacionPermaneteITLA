using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_repetición_for
{
    internal class TablaMult
    {
        public void Tabla()
        {
            for(int i = 1; i <= 50; i++) 
            {
                int resul = 5 * i;
                Console.WriteLine($"5 X {i} = {resul}");
            
            }

        }

    }
}
