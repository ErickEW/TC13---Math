using System;

namespace TC13_Math
{
    class Program
    {
        static void Main(string[] args)
        {
           double num1, num2, resultado;
           int num;

           Console.WriteLine("inserte el numero a elevar");
           num1 = Convert.ToDouble(Console.ReadLine());

           Console.WriteLine("inserte la potencia a la que desea elevar el numero");
           num2 = Convert.ToDouble(Console.ReadLine());

           resultado = Math.Pow(num1, num2);

           Console.WriteLine("El resutado es "+ resultado);
           
           if (resultado >= 0)
           {
               Console.WriteLine("Es +");
           }
           else
           {
               Console.WriteLine("Es -");
           }


           Console.WriteLine("Escribe el numero que le deseas sacar raíz");
           num = Convert.ToInt32(Console.ReadLine());

           Math.Sqrt(num);

           Console.WriteLine("La raíz es "+ Math.Sqrt(num));

           if (resultado > num)
           {
               Console.WriteLine("{0} es mayor que {1}", resultado, Math.Sqrt(num));
           }
           else if (resultado < num)
           {
               Console.WriteLine("{0} es mayor que {1}", Math.Sqrt(num), resultado);
           }

           Console.ReadKey();

        }
    }
}
//To Do: -A partir de dos números, determinar qué número es más grande sin importar el signo (ej. -5 es mayor que 4 en este punto)
//-Quitar los decimales de un número
//-Redondear el siguiente número: 8.55