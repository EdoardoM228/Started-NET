using System;

namespace Lessons_C
{
    class Program 
    { 
        static void Main(string[] args)
        {
            Console.WriteLine(Math.Pow(3, 4)); // возведение числа в степень

            Console.WriteLine(Math.Sqrt(36)); // Нахождение числа из корня 

            Console.WriteLine(Math.Log(36, 6)); // Нахождение опказателся степени 

            string firstword, secondword, text;
            int augend, addend;

           firstword = Console.ReadLine();
           secondword = Console.ReadLine(); 

           text = firstword + ' ' + secondword;
           text += '!';

           Console.WriteLine(text);

            /*Первый метод решения через сразу ввод чисел 

          //  Console.WriteLine("Введите первое слагаемое : ");
           //  augend = Convert.ToInt32(Console.ReadLine());

          //  Console.WriteLine("Введите второе слагаеоме : ");
          //   addend = Convert.ToInt32(Console.ReadLine());

           // int sum = augend + addend;

           // Console.WriteLine(augend + "+" + addend + "=" +sum);

            */

            Console.WriteLine("Введите первое слагаемое : ");
            string firstaugend = Console.ReadLine();

            Console.WriteLine("Введите второе слагаемое : ");
            string secondaddend = Console.ReadLine();

            augend = Convert.ToInt32(firstaugend);
            addend = Convert.ToInt32(secondaddend);

            int sum = augend + addend;

            string result = string.Format("Итог суммы : {0} + {1} = {2}", augend, addend, sum);
            Console.WriteLine(result);

            /* Второй способ через конвертацию из string в Int32 */


            Console.ReadKey();






        }
    }
}
