using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculandoSueldo
{
    internal class Sueldo
    {
        public void CalculandoSueldo() {
            int HorasTrabajadas;
            int CostoHoras;
            int Sueldo;
            decimal Itbs = 0.18m;
            decimal ItbsSueldo;
            try
            {
                Console.WriteLine("Ingrese las horas trabajas: ");
                HorasTrabajadas = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el costo de las horas: ");
                CostoHoras = Convert.ToInt32(Console.ReadLine());


                Sueldo = HorasTrabajadas * CostoHoras;

                if (Sueldo > 5000)
                {
                    Console.WriteLine("-------------------------Detalles-----------------------------------");
                    Console.WriteLine("Su sueldo es: " + Sueldo);
                    ItbsSueldo = Sueldo * Itbs;
                    Console.WriteLine("Impuestos a pagar: " + ItbsSueldo);
                    Console.WriteLine($"Su sueldo neto es: {Sueldo - ItbsSueldo}");


                }
                else {

                    Console.WriteLine("-------------------------Detalles-----------------------------------");

                    Console.WriteLine("El sueldo es: " + Sueldo);

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Su programa se detuvo por la siguiente razon: "+ex.Message);
            }
            


        }


    }
}
