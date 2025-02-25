using System;

namespace Grundlæggende_programmering_repetitions_opgaver_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            {// Opgave 
                Console.WriteLine("Age:");
                String strAge = Console.ReadLine();
                int intAge = int.Parse(strAge);


                Console.WriteLine("Height:");
                String strHeight = Console.ReadLine();
                double doubleHeight = double.Parse(strHeight);
                Math.Round(doubleHeight, 2);


                Console.WriteLine("Weight:");
                String strWeight = Console.ReadLine();
                double doubleWeight = double.Parse(strHeight);
                Math.Round(doubleWeight, 1);


                Console.WriteLine("Name:");
                String strName = Console.ReadLine();
                string strInitial = strName.Substring(0, 1);


                Console.WriteLine("Student Y/N:");
                String strStudent = Console.ReadLine();
                String strStudentBool;

                if  (strStudent == "Y")
                {
                    strStudentBool = "True";
                }
                else if (strStudent == "N")
                {
                    strStudentBool = "False";
                }
                else
                {
                    Console.WriteLine("Indtast Y (Ja) eller N (Nej)");
                    return;
                }

                Console.WriteLine("Age: " + intAge + ", Height: " + doubleHeight + ", Weight:" + doubleWeight + ", Initital: " + strInitial + ", Name: " + strName + ", Is student: " + strStudentBool);
                
            }*/
            /*
            {// Opgave 2
                
                Console.WriteLine("Indtast enhed F/C");
                String strEnhed = Console.ReadLine();



                if (strEnhed == "F")
                {
                    Console.WriteLine("Indtast temperatur");
                    String strF = Console.ReadLine();
                    int intF = int.Parse(strF);

                    int intC = intF - 32 * (5/9);

                    Console.WriteLine(intC + "C" + " is " + intF + "F");
                    Console.WriteLine(intF + "f" + " is " + intC + "C");



                }
                else if (strEnhed == "C")
                {
                    Console.WriteLine("Indtast temperatur");
                    String strC = Console.ReadLine();
                    int intC = int.Parse(strC);

                    int intF = intC * (9/5) + 32;

                    Console.WriteLine(intC + "C" + " is " + intF + "F");
                    Console.WriteLine(intF + "f" + " is " + intC + "C");

                }
                else
                {
                    Console.WriteLine("Indtast C (Celcius) eller F (Fahrenheit)");
                    return;
              
                }*/


            // Opgave 3 
            /*
                Console.WriteLine("Vægt i kg:");
                String strVægt = Console.ReadLine();
                double doubleVægt = double.Parse(strVægt);

                Console.WriteLine("Højde i m:");
                String strHøjde = Console.ReadLine();
                double doubleHøjde = double.Parse(strHøjde);

                double BMI = doubleVægt/(doubleHøjde*doubleHøjde);
                
            Console.WriteLine(BMI);
            */

            // Opgave 4

            /*
            Console.WriteLine("Indtast to tal");
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            double Sum = x + y;

            double Difference = x - y;

            double Product = x * y;

            double Quotient = x / y;

            double Remainder = x % y;

     

            Console.WriteLine("Sum: " + Sum + ",  Difference: " + Difference + ", Product: " + Product + ", Quotient: " + Quotient + ", Remainder: " + Remainder);
            */

            // Opgave 5
            /*
            Console.WriteLine("Indtast radius");
            double Radius = double.Parse(Console.ReadLine());

            double Area = Math.PI + Math.Sqrt(Radius);
            double Circumference = 2 * Math.PI * Radius;

            Console.WriteLine("Area: " + Area + ", Circumference: " + Circumference);

            */


            // Opgave 6
            /*
            int Alder = 40;

            string Equal;
            string NotEqual;
            
            string Greater;
            string Less;

            string GreaterOrEqual;
            string LessOrEquial;

            double Indtast = double.Parse(Console.ReadLine());

            Console.WriteLine("Indtast tal til at sammenligne");

            if (Indtast == Alder)
            {
                Console.Write("Is Equal: True, Is Not Equal: False, ");
            }
            else
            {
                Console.Write("Is Equal: False, Is Not Equal: True, ");
            }


            if (Indtast == Alder)
            {
                Console.Write("Is Greater: True, Is Less: False, ");
            }
            else
            {
                Console.Write("Is Greater: False, Is Less: True, ");
            }


            if (Indtast >= Alder)
            {
                Console.Write("Is Greater Or Equal: True, Is Less OR Equal: False");
            }
            else
            {
                Console.Write("Is Greater Or Equal: False, Is Less OR Equal: True");
            }
            */

            //Opgave 7
            /*
            
            double Tal = double.Parse(Console.ReadLine());

            if (0 < Tal)
            {
                Console.WriteLine("Tallet er positivt");
            }
            else if (0 > Tal)
            {
                Console.WriteLine("Tallet er negativt");
            }
            else
            {
                Console.WriteLine("Tallet er 0");
            }
            */

            //Opgave 8

            /*

            Console.WriteLine("Indtast Karakter");
            Char Bogstav = Char.Parse(Console.ReadLine());



            switch (Bogstav)
            {
                case 'A':
                    Console.WriteLine("Du har bestået A");
                    break;

                case 'B':
                    Console.WriteLine("Du har bestået B");
                    break;

                case 'C':
                    Console.WriteLine("Du har bestået C");
                    break;

                case 'D':
                    Console.WriteLine("Du har bestået D");
                    break;

                case 'E':
                    Console.WriteLine("Du har bestået E");
                    break;

                case 'F':
                    Console.WriteLine("Du har bestået F");
                    break;

            */

            //Opgave 10

            /*

            int Tal = int.Parse(Console.ReadLine());
            Console.WriteLine("Indtast uge dag 1-7");

            switch (Tal)
            {
                case 1:
                    Console.WriteLine("Mandag");
                    break;

                case 2:
                    Console.WriteLine("Tirsdag");
                    break;

                case 3:
                    Console.WriteLine("Onsdag");
                    break;

                case 4:
                    Console.WriteLine("Torsdag");
                    break;

                case 5:
                    Console.WriteLine("Fredag");
                    break;

                case 6:
                    Console.WriteLine("Lørdag");
                    break;

                case 7:
                    Console.WriteLine("Søndag");
                    break;

            */

            //Opgave 11
            /*
            Console.WriteLine("Indtast måneds nummer");
            int Tal = int.Parse(Console.ReadLine());

            switch (Tal)
            {
                case 1:
                    Console.WriteLine("Januar");
                    break;

                case 2:
                    Console.WriteLine("Februar");
                    break;

                case 3:
                    Console.WriteLine("Marts");
                    break;

                case 4:
                    Console.WriteLine("April");
                    break;

                case 5:
                    Console.WriteLine("Maj");
                    break;

                case 6:
                    Console.WriteLine("Juni");
                    break;

                case 7:
                    Console.WriteLine("Juli");
                    break;

                case 8:
                    Console.WriteLine("August");
                    break;

                case 9:
                    Console.WriteLine("September");
                    break;

                case 10:
                    Console.WriteLine("October");
                    break;

                case 11:
                    Console.WriteLine("November");
                    break;

                case 12:
                    Console.WriteLine("December");
                    break;

                default:
                    Console.WriteLine("Gør bedre"); 
                    return;
            }
            
            */


            //Opgave 12
            /*
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            */

            /*
            //Opgave 13
            
            int i = 0;
            while (i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }
            */


            //Opgave 14
            //Do while loop, bliver brugt for at sikre at koden køre mindt 1 gang.
            /*
            int i = 1;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i <= 10);
            */


            //Opgave 15
            /*
            int sum = 0;

            for (int i = 1; i <= 10; i++)
            {
                sum += i;
            }

            Console.WriteLine(sum);
            */

            //Opgave 16
            /*
            int sum = 1;
 

            for (int i = 5; i > 1; i--)
            {
                Console.WriteLine(i);
                sum *= i;
            }

            Console.WriteLine(sum);
            */


            //Opgave 17

            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            static double addition(double x, double y)
            {
                return x + y;
            }























        }
    }
}