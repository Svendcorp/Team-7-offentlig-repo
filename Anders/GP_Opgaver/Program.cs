using System;

namespace GP_Opgave1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Opgave 1
            Console.WriteLine("Opgave 1");

            int age = 25;
            float height = 1.75f;
            double weight = 70.5;
            char initial = 'A';
            string name = "Alice";
            bool isStudent = true;


            Console.WriteLine($"Age: {age}, Height: {height}, Weight: {weight}, Initial: {initial}, Name: {name}, Is Student: {isStudent}");
            Console.ReadLine();

            Console.WriteLine("\nOpgave 2");
            /* Opgave 2

            Fra Celsius til Fahrenheit:
            Fahrenheit(°F) = Celsius(°C) * (9 / 5) + 32

            Fra Fahrenheit til Celsius:
            Celsius(°C) = Fahrenheit(°F) - 32 * (5 / 9)
            */
            
            int degrees = 25;
            int degreesFahrenheit = ((degrees * 9) / 5) + 32;

            Console.WriteLine($"{degrees}°C is {degreesFahrenheit}°F");

            degrees = ((degreesFahrenheit - 32) * 5 / 9);

            Console.WriteLine($"{degreesFahrenheit}°F is {degrees}°C ");
            Console.ReadLine();

            // Opgave 3
            Console.WriteLine("\nOpgave 3");
            double bmi = weight / (height * height);
            Console.WriteLine($"Alice BMI: {bmi}");

            if (bmi < 18.5)
            {
                Console.WriteLine($"{name} er undervægtig.");
            }
            else if (bmi < 25)
            {
                Console.WriteLine($"{name} er normalvægtig.");
            }
            else if (bmi < 30)
            {
                Console.WriteLine($"{name} er overvægtig.");
            }
            else
            {
                Console.WriteLine($"{name} er svært overvægtig.");
            }

            Console.ReadLine();

            // Opgave 4
            Console.WriteLine("\nOpgave 4");
            int x = 10;
            int y = 5;

            int sum = x + y;
            int difference = x - y;
            int product = x * y;
            int quotient = x / y;
            int modulus = x % y;
            Console.WriteLine($"Sum: {sum}, Difference: {difference}, Product: {product}, Quotient: {quotient}, Remainder: {modulus}");

            Console.ReadKey();

            // Opgave 5
            Console.WriteLine("\nOpgave 5");
            double PI = 3.1415926535897931;

            Console.Write("Indtast cirklens radius: ");
            double radius = double.Parse(Console.ReadLine());
            double areal = Math.PI * radius * radius;
            double omkreds = 2 * Math.PI * radius;

            Console.WriteLine($"Arealet af cirklen er: {areal}");
            Console.WriteLine($"Omkredsen af cirklen er: {omkreds}");

            Console.ReadKey();

            // Opgave 6

            Console.WriteLine("\nOpgave 6");
            bool isLegal = age >= 18;
            Console.WriteLine($"Alice er myndig: {isLegal}");
            bool isTall = height > 1.70;
            Console.WriteLine($"Alice er højere end 1.70: {isTall}");

            // && (AND)
            bool isLegalAndStudent = isLegal && isStudent;
            Console.WriteLine($"Alice er myndig og studerende: {isLegalAndStudent}");

            // ||(OR):
            bool isLegalOrTaller = isLegal || isTall;
            Console.WriteLine($"Alice er myndig eller højere end 1.70: {isLegalOrTaller}");

            // !(NOT)
            bool isNotStudent = !isStudent;
            Console.WriteLine($"Alice er ikke studerende: {isNotStudent}");

            Console.ReadKey();

            // Opgave 7

            Console.WriteLine("\nOpgave 7");

            Console.WriteLine("Indtast et tal: ");
            double tal = double.Parse(Console.ReadLine());

            if (tal > 0)
            {
                Console.WriteLine("Det er et positivt tal.");
            }
            else if (tal < 0)
            {
                Console.WriteLine("Det er et negativt tal.");
            }
            else
            {
                Console.WriteLine("Dit tal er nul.");
            }

            Console.ReadKey();

            // Opgave 8
            Console.WriteLine("\nOpgave 8");
            Console.Write("Indtast en karakter (A, B, C, D, F): ");
            char karakter = char.Parse(Console.ReadLine());

            if (karakter == 'A' || karakter == 'B' || karakter == 'C' || karakter == 'D')
            {
                Console.WriteLine($"Karakteren er bestået.");
            }
            else
            {
                Console.WriteLine($"Karakteren er ikke bestået.");
            }

            Console.ReadKey();

            // Opgave 9

            Console.Write("Indtast et årstal: ");
            int year = int.Parse(Console.ReadLine());

            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine($"{year} er et skudår.");
            }
            else
            {
                Console.WriteLine($"{year} er ikke et skudår.");
            }

            Console.ReadKey();

            // Opgave 10
            Console.WriteLine("\nOpgave 10");
            Console.Write("Indtast et tal mellem 1 og 7: ");
            int dayNumber = int.Parse(Console.ReadLine());

            string weekDay;

            switch (dayNumber)
            {
                case 1:
                    weekDay = "Mandag";
                    break;
                case 2:
                    weekDay = "Tirsdag";
                    break;
                case 3:
                    weekDay = "Onsdag";
                    break;
                case 4:
                    weekDay = "Torsdag";
                    break;
                case 5:
                    weekDay = "Fredag";
                    break;
                case 6:
                    weekDay = "Lørdag";
                    break;
                case 7:
                    weekDay = "Søndag";
                    break;
                default:
                    weekDay = "Ugyldigt tal. Indtast et tal mellem 1 og 7.";
                    break;
            }

            Console.WriteLine($"Ugedagen er: {weekDay}");

            Console.ReadKey();

            // Opgave 11

            Console.WriteLine("\nOpgave 11");
            Console.Write("Indtast et tal mellem 1 og 12: ");
            int monthNumber = int.Parse(Console.ReadLine());

            string month;

            switch (monthNumber)
            {
                case 1:
                    month = "Januar";
                    break;
                case 2:
                    month = "Februar";
                    break;
                case 3:
                    month = "Marts";
                    break;
                case 4:
                    month = "April";
                    break;
                case 5:
                    month = "Maj";
                    break;
                case 6:
                    month = "Juni";
                    break;
                case 7:
                    month = "Juli";
                    break;
                case 8:
                    month = "August";
                    break;
                case 9:
                    month = "September";
                    break;
                case 10:
                    month = "Oktober";
                    break;
                case 11:
                    month = "November";
                    break;
                case 12:
                    month = "December";
                    break;
                default:
                    month = "Ugyldigt tal. Indtast et tal mellem 1 og 12.";
                    break;
            }

            Console.WriteLine($"Måneden er: {month}");

            Console.ReadKey();

            // Opgave 12

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();

            // Opgave 13
            /*
            int i = 1;
            while (i <= 10);
            {
                Console.WriteLine(i);
                i++;
            }

            // Opgave 14
            int i = 1;

            do
            {
                {
                    Console.WriteLine(i);
                    i++;
                }
            } while (i <= 10);

            Console.ReadKey();


            // Opgave 15

            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                sum += i;
            }

            Console.WriteLine(sum);
            Console.ReadKey();

            // Opgave 16 -- virker ikke helt som forventet
            int sum = 2;
            for (int i = 5; i > 0; i--)
            {
                Console.WriteLine(i);
                sum *= i;
                Console.WriteLine($"Summen er nu {sum}");
            }
            Console.WriteLine(sum);
            Console.ReadKey();
            */

        }
    }
}
