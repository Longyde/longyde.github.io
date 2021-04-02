using System;

namespace probl2
{
    class Program
    {
        static void Main(string[] args)
        {
            start:
            Console.WriteLine("Eneter two numbers to divide(we recommend NOT by zero): ");
            int firstArg = Convert.ToInt32(Console.ReadLine());
            int secondArg = Convert.ToInt32(Console.ReadLine());
            try
            {
                Swappa.accept(ref firstArg, ref secondArg);
            }
            catch (DivideByZeroException)
            {

                Console.WriteLine("Told you not to divide by Zero.");
                goto start;
            }
            
        }
    }
    class Swappa
    {
        public static int accept(ref int a, ref int b)
        {
            
            if (b == 0)
            {
                throw new DivideByZeroException();
            }
            return a / b;

        }
    }
}
