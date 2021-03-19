using System;

namespace Lessons_C
{
    class Program
    {
      
        static int Factorial(int number)
        {
            int fact = 1;

            for (int factor = 2; factor <= number; factor++)
            {
                fact = fact * factor;
            }
            return fact;
        }
        
        
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Введи число ,которого хочешь узнать факториал : ");
                int factor = Convert.ToInt32(Console.ReadLine());
                Console.Write($"{factor}! = {Factorial(factor)}");

                Console.WriteLine("\nНажми любую клавишу для повторения");
                Console.ReadKey();
            }
        }

    }
}
