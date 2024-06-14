using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EmpleadosSueldos
{
    internal class Sueldo
    {
        public void SEmpleados()
        {
            
            int i = 0;
            int sueldo = 0;
            int cont1 = 0;
            int cont2 = 0;
            decimal SumaSueldos = 0;

            try
            {
                Console.WriteLine("Cantida de empleados a ingresar sueldo: ");
                sueldo= Convert.ToInt32(Console.ReadLine());

                decimal[] empleados = new decimal[sueldo];

                while(i < empleados.Length) 
                {
                    Console.Write($"Sueldo empleado # {i+1}: ");
                    empleados[i] = Convert.ToDecimal(Console.ReadLine());

                    if (empleados[i] >= 100 && empleados[i] <=300)
                    {
                        cont1++;
                    }
                    if (empleados[i] >=300)
                    {
                        cont2++;
                    }

                    SumaSueldos += empleados[i];

                    i++;

                }
                Console.WriteLine("--------------------------------------");
                Console.WriteLine($"Sueldos entre $100-$300: {cont1}");
                Console.WriteLine($"Sueldos por encima de los $300: {cont2}");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine($"Gastos en sueldos de personal de la empresa: {SumaSueldos}");


            }
            catch (Exception e) 
            {
                Console.WriteLine(e.Message);
            }

        }

    }
}
