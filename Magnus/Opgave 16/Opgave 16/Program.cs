using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5! fakulten er 5*4*3*2*1 = 120

            int sum = 1;
            for (int i = 5; i > 0; i--)
            {
                Console.WriteLine(i);
                sum *= i;
                
            }
            Console.WriteLine(sum);
        }
    }
}
