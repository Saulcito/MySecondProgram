using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySecondProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 3; 
            int b = 4;
            double result;
            result = ((Math.Pow(a + b, 2) - (Math.Pow(a, 2) + 2 * a * b)) / Math.Pow(b, 2));
            Console.WriteLine("result = {0}", result);
            Console.ReadKey();
        }
    }
}
