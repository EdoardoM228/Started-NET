using System;

namespace Lessons_C
{
    class Program 
    { 
        static void Main(string[] args)
        {
            int augend, addend;
            Console.WriteLine("Введите первое слагаемое : ");
            string firstaugend = Console.ReadLine();

            Console.WriteLine("Введите второе слагаемое : ");
            string secondaddend = Console.ReadLine();

            augend = Convert.ToInt32(firstaugend);
            addend = Convert.ToInt32(secondaddend);

            int sum = augend + addend;

            string result = $"итог суммы : {augend} + {addend} = {sum}";
            Console.WriteLine(result);

            double interpolationExpression = 0.123456789_12345678;
            const int aligment = 30;

            Console.WriteLine($"8. R format : {interpolationExpression,-aligment:R} : End.");

            Console.WriteLine($"8. R format : {interpolationExpression,aligment:R} : End.");

            Console.WriteLine(@"C:\windows\notepad.exe");
            Console.WriteLine("C:\\winsows\\notepad.exe");
            
            Console.ReadKey();






        }
    }
}
