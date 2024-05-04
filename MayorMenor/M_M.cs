using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayorMenor
{
    internal class M_M
    {

        public void MayorMenor()
        {
            decimal num1;
            int num2;
            decimal div = 0m;
            int Opcion = 0;

            Console.WriteLine("Elija una de las opciones:");
            Console.WriteLine("Opcion 1 Mayor y Menor");
            Console.WriteLine("Opcion 2 Promedio de notas");
            Console.WriteLine("Opcion 3 Promedio de notas");
            Opcion= Convert.ToInt32(Console.ReadLine());

            switch (Opcion)
            {
                case 1:
                    try
                    {
                        Console.WriteLine("Ingrese el 1er Numero: ");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el 2do Numero: ");
                        num2 = Convert.ToInt32(Console.ReadLine());
                       

                        if (num1 > num2)
                        {
                            Console.WriteLine($"La suma es:{num1 + num2} ");
                            Console.WriteLine($"Diferencia:{num1 - num2} ");
                        }
                        else
                        {
                            Console.WriteLine($"El producto es: {num1 * num2}");

                            div = Convert.ToDecimal(num1 / num2);
                            Console.WriteLine($"La divicion es: {div}");

                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                break;

                    case 2:
                    
                    
                    Console.WriteLine("1ra Nota: ");
                    double not1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("2da Nota: ");
                    double not2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("3ra Nota: ");
                    double not3 = Convert.ToInt32(Console.ReadLine());

                    double Promedio = (not1 + not2 + not3)/3;

                    if(Promedio >= 7)
                    {
                        Console.WriteLine("Promovido");
                    }else
                    {
                        Console.WriteLine("Se quemo");
                    }


                    break;
                    case 3:
                    Console.WriteLine("1ra Nota: ");
                    decimal n1 = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("2da Nota: ");
                    decimal n2 = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("3ra Nota: ");
                    decimal n3 = Convert.ToDecimal(Console.ReadLine());

                    decimal Promedio2 = (n1 + n2 + n3) / 3;

                    if (Promedio2 >= 7)
                    {
                        Console.WriteLine("Promovido");
                    }
                    else if (Promedio2 >= 4 && Promedio2 < 7)
                    {
                        Console.WriteLine("Regular");
                    }
                    else if(Promedio2 <4)
                    {
                        Console.WriteLine("Reprobado");
                    }

                    break;

            }
            
            
          
        }

    }
}
