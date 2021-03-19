using System;

namespace Lessons_C
{
    class Program
    {
        static int NumbersFibonacciCycle(int number)
        {
            int n1 = 0, n2 = 1, n3 = 0;

            for (int i = 0; i < number; i++)
            {
                n3 = n1 + n2;
                n1 = n2;
                n2 = n3;
            }
            return n3;
        }

        static int NumbersFibonacci(int number)
        {
            if (number < 2)
            {
                return number;
            }
            else
            {
                return NumbersFibonacci(number - 1) + NumbersFibonacci(number - 2);
            }
        }



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
            string agree;
            do
            {
                Console.Write("Введи число ,которого хочешь узнать факториал : ");
                int factor = Convert.ToInt32(Console.ReadLine());
                Console.Write($"{factor}! = {Factorial(factor)}");

                Console.WriteLine("\nХодите получить число фибоначчи ?");
                agree = Console.ReadLine();
                Console.ReadKey();
            } while (agree == "No");

            Console.Write("Какое число Фибоначчи хочешь узнать : ");
            int fibonacci = Convert.ToInt32(Console.ReadLine());
            int sumFibonacci;
            for (int i = 0; i < fibonacci; i++)
            {
                sumFibonacci = NumbersFibonacciCycle(i);
                Console.Write($"{sumFibonacci}, ");
            }

        }


    }
}
