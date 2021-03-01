using System;

namespace Lessons_C
{
    class Program 
    { 
        static void Main(string[] args)
        {
            bool x = true, y = false;
            int age, salary, minage = 21, maxage = 55, minsalary = 1500; 

            Console.WriteLine($"Первое значение {x} = {!x}, второе значение {y} = {!y}");

            bool notx = !x, noty = !y;

            Console.WriteLine($"Первое значение {x} = {notx}, второе значение {y} = {noty}");

            age = Convert.ToInt32(Console.ReadLine());
            salary = Convert.ToInt32(Console.ReadLine());

            bool credit = salary >= minsalary & age >= minage & age <= maxage;

            Console.WriteLine($"Ввывод акредетирования : {credit}");

            int firstnumber = 0, secondnumber = 0;

            bool normalcongiiukcia = true & false & (firstnumber++ > 0);
            Console.WriteLine($"Firstnumber : {firstnumber}");

            bool corotcozamknutaiacongiucia = true && false && (secondnumber++ > 0);
            Console.WriteLine($"Secondnumber : {secondnumber}");





            Console.ReadKey();






        }
    }
}
