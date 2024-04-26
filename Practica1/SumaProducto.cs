using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    internal class SumaProducto
    {

        public void Calculando()
        {
            int num1;
            int num2;
            int suma;
            int producto;

            Console.WriteLine("Este programa realiza la suma y la multiplicacion de dos numeros ingresados por pantalla");
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("Ingrese un numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            suma = num1 + num2;
            Console.WriteLine("La suma de los numeros es: "+ suma);

            producto = num1 * num2;
            Console.WriteLine("El producto de los numeros es: " + producto);



        }



    }
}
