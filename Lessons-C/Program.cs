using System;

namespace Lessons_C
{
    class Program 
    { 
        static void Main(string[] args)
        {

            decimal plitkaKoliscestvo, plitkaCena;
            {
                Console.WriteLine("Введите кол-во плитки : ");
                plitkaKoliscestvo = Convert.ToUInt32(Console.ReadLine());
                Console.WriteLine("Введите Цену плитки : ");
                plitkaCena = Convert.ToUInt32(Console.ReadLine());

            }

            decimal fullPriceTale;
            {
                fullPriceTale = plitkaCena * plitkaKoliscestvo;
            }

            bool discount = plitkaKoliscestvo >= 100;
            decimal priceDiscount;

            if (discount)
            {
                const decimal DISCOUNT = 10; // %
                priceDiscount = fullPriceTale / 100 * DISCOUNT;
            }
            else
            {
                priceDiscount = 0; 
            }

            decimal totalPriceTale;
            {
                totalPriceTale = fullPriceTale - priceDiscount;
            }

            Console.WriteLine($"Общая стоимость : {fullPriceTale}");
            Console.WriteLine($"Сумма скидки : {priceDiscount}");
            Console.WriteLine($"Сумма к оплате : {totalPriceTale}");
            
            Console.ReadKey();



        }
    }
}
