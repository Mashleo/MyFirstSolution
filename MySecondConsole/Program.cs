using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySecondConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.141592653;
            decimal e = 1.414213562373095048M;

            Console.WriteLine("Константа Пи = " + pi);
            Console.WriteLine("Константа Пифагора = " + e);
            Console.WriteLine("Константа Пи которая встроеная в С# = " + Math.PI);
        }
    }
}
