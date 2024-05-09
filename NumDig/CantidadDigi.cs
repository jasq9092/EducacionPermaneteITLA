using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumDig
{
    internal class CantidadDigi
    {
        public void cantidad()
        {
            int numero;
            try
            {
                Console.WriteLine("Ingrese un numero entero: ");
                numero = Convert.ToInt32(Console.ReadLine());

                int CantidadD = ContandoNumero(numero);
                Console.WriteLine($"La cantidad de digitos es: {CantidadD}");
            }
            catch(Exception ex)
            {
                Console.WriteLine("El Programa se detuvo por la siguiente razon: "+ex.Message);
            }
            

            

        }

        public int ContandoNumero(int numero)
        {
            return numero.ToString().Length;
        }

    }
}
