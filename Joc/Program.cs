using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joc
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcio;
            Console.WriteLine("Introdueix el numero del joc!");
            Console.WriteLine();
            Console.WriteLine("***** 1 - CS         - *****");
            Console.WriteLine("***** 2 - TETRIS     - *****");
            Console.WriteLine("***** 3 - SALIR      - *****");
            Console.WriteLine("***** 4 - BUSCAMINES - *****")
            opcio = int.Parse(Console.ReadLine());
            Console.WriteLine();
            switch (opcio)
            {
                case 1:
                    Console.WriteLine("HOLA CMAN!");
                    break;

                case 2:
                    Console.WriteLine("HOLA AMANTE DEl TETRIS!");
                    break;

                case 3:
                    Console.WriteLine("HASTA LUEGO MARICARMEN!");
                    break;
                
                case 4:
                    Console.WriteLine("HOLAA BUSCAMINERO!!")
            }
        }
    }
}
