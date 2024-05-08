using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuadrado
{
    internal class LadoCuadrado
    {
        public void Cuadrado()
        {
            decimal LCuadrado;
            decimal Perimetro;
            try
            {
                Console.WriteLine("Calculando el perimetro de un cuadrado");
                Console.WriteLine("---------------------------------------------------------");
                Console.WriteLine("Ingrese la longitud de uno de los lados del cuadrado: ");
                LCuadrado = decimal.Parse(Console.ReadLine());

                Perimetro = LCuadrado * 4;

                Console.WriteLine($"El perimetro del cuadrado es: {Perimetro}");
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           




        }

    }
}
