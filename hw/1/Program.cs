using System;

namespace mod1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number grade between 0 and 100 to find what the letter will be: ");
            int grade = Convert.ToInt32(Console.ReadLine());

            switch (grade)
            {
                case int n when n >= 100:
                    Console.WriteLine("My friend, This is not a fairytail!"); //cover over 100 answer
                    break;
                case int n when n <= 100 && n >= 97 :
                    Console.WriteLine($"A {grade}%. You get a A+");
                    break;
                case int n when n <= 96 && n >= 93:
                    Console.WriteLine($"A {grade}%. You get a A");
                    break;
                case int n when n <= 92 && n >= 90:
                    Console.WriteLine($"A {grade}%. You get a A-");
                    break;
                case int n when n <= 89 && n >= 77:
                    Console.WriteLine($"A {grade}%. You get a B+");
                    break;
                case int n when n <= 86 && n >= 83:
                    Console.WriteLine($"A {grade}%. You get a B");
                    break;
                case int n when n <= 82 && n >= 80:
                    Console.WriteLine($"A {grade}%. You get a B-");
                    break;
                case int n when n <= 79 && n >= 77:
                    Console.WriteLine($"A {grade}%. You get a C+");
                    break;
                case int n when n <= 76 && n >= 73:
                    Console.WriteLine($"A {grade}%. You get a C");
                    break;
                case int n when n <= 72 && n >= 70:
                    Console.WriteLine($"A {grade}%. You get a C-");
                    break;
                case int n when n <= 69 && n >= 67:
                    Console.WriteLine($"A {grade}%. You get a D+");
                    break;
                case int n when n <= 66 && n >= 63:
                    Console.WriteLine($"A {grade}%. You get a D");
                    break;
                case int n when n <= 62 && n >= 60:
                    Console.WriteLine($"A {grade}%. You get a D-");
                    break;
                case int n when n <= 59 && n >= 0:
                    Console.WriteLine($"A {grade}%. You get a F");
                    break;
                case int n when n <= -1:
                    Console.WriteLine("You get one F+! Congrats!"); //cover under 0 answer
                    break;

            }
        }
    }
}
