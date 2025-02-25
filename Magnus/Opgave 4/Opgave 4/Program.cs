using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum;
                double tal1;
                double tal2;
            double difference;
                double tal3;
                double tal4;
            double product;
                double tal5;
                double tal6;
            double quotient;
                double tal7;
                double tal8;
            double remainder;
                double tal9;
                double tal10;
            //_--------------------------------------------
            Console.WriteLine("Sum = to eller flere tal man lægger sammen.\nkom med to tal så lægger jeg dem sammen for dig");
            tal1 = Convert.ToInt32(Console.ReadLine());
            tal2 = Convert.ToInt32(Console.ReadLine());

            sum = tal1 + tal2;
            Console.WriteLine("summen af dine to tal er " + sum);


            //_--------------------------------------------
            Console.WriteLine("Difference = to eller flere tal man trækker fra hinanden.\nkom med to tal så trækker jeg dem fra hinanden for dig");
            tal3 = Convert.ToInt32(Console.ReadLine());
            tal4 = Convert.ToInt32(Console.ReadLine());

            difference = tal3 - tal4;
            Console.WriteLine("Differencen er " + difference);

            //_--------------------------------------------
            Console.WriteLine("Produkt = to eller flere tal man ganger med hinanden.\nkom med to tal så ganger jeg dem for dig");
            tal5 = Convert.ToInt32(Console.ReadLine());
            tal6 = Convert.ToInt32(Console.ReadLine());

            product = tal5 * tal6;
            Console.WriteLine("Produktet er " + product);

            //_--------------------------------------------
            Console.WriteLine("Quotient = to eller flere tal man dividerer med hinanden.\nkom med to tal så dividerer jeg dem for dig");
            tal7 = Convert.ToInt32(Console.ReadLine());
            tal8 = Convert.ToInt32(Console.ReadLine());

            quotient = tal7 / tal8;
            Console.WriteLine("Quotienten er " + quotient);

            //_--------------------------------------------
            Console.WriteLine("Rest = to eller flere tal man dividerer med hinanden, hvor der er en rest.\nkom med to tal så dividerer jeg dem for dig");
            tal9 = Convert.ToInt32(Console.ReadLine());
            tal10 = Convert.ToInt32(Console.ReadLine());

            remainder = tal9 % tal10;
            Console.WriteLine("Resten er " + remainder);
        }
    }
}
