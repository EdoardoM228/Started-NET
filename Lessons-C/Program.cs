using System;

namespace Lessons_C
{
    class Program 
    { 
        static void Main(string[] args)
        {

            uint minutsInKvartal;
            {
                Console.Write("Кол-во минут за июль : ");
                uint minutsInIuni = Convert.ToUInt32(Console.ReadLine());

                Console.Write("Кол-во минут за июнь : ");
                uint minutsInIuli = Convert.ToUInt32(Console.ReadLine());

                Console.Write("Кол-во мигут за август : ");
                uint minutsInAugust = Convert.ToUInt32(Console.ReadLine());

                minutsInKvartal = minutsInIuni + minutsInIuli + minutsInAugust;
            }

            decimal priceInKvartal;
            {
                Console.Write("Введи цену минуты тарифа : ");
                decimal price = Convert.ToDecimal(Console.ReadLine());

                priceInKvartal = minutsInKvartal * price;
            }

            decimal nalogZaKvartal;
            {
                Console.Write("Введи налог государства :");
                decimal nalog = Convert.ToDecimal(Console.ReadLine());

                nalogZaKvartal = priceInKvartal / 100 * nalog;

            }

            Console.WriteLine($"Кол-во минут за квартал : {minutsInKvartal}");
            Console.Write($"Стоимость всех минут {priceInKvartal} и сумма налога {nalogZaKvartal}");
            
            
            
            
            
            Console.ReadKey();



        }
    }
}
