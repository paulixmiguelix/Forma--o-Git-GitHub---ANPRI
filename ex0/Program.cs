using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex0
{
    class Program
    {
        static void Main(string[] args)
        {//inicio

            //ex0
            //nome:Prof
            //04-10-2022
            double x = 5.0;
            Console.WriteLine(x);
            Console.WriteLine(7.0);
            Console.WriteLine("Bemvindo");

            Console.Write("Introduza um número:");
            x = Convert.ToDouble(Console.In.ReadLine());
            Console.WriteLine("O nº que introduziu foi:"+x);

            Console.In.ReadLine();// Para que o programa ñ encerre imediatamente







        }//fim
    }
}
