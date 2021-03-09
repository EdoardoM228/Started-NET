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

            decimal priceDiscount;
            {
                decimal discountpersentage;
                {
                    bool discountFor20Pct, discountFor50Pct;
                    {
                        const decimal DISCOUNT_FOR_50_PCT = 1000;
                        const decimal DISCOUNT_FOR_20_PCT = 500;
                        discountFor20Pct = plitkaKoliscestvo >= DISCOUNT_FOR_20_PCT && plitkaKoliscestvo < DISCOUNT_FOR_50_PCT;
                        discountFor50Pct = plitkaKoliscestvo >= 1000;

                        if (discountFor20Pct)
                        {
                            discountpersentage = 20;
                        }
                        else
                        {
                            if (discountFor50Pct)
                            {
                                discountpersentage = 50;
                            }
                            else
                            {
                                discountpersentage = 0;
                            }
                        }
                    }
                    priceDiscount = fullPriceTale / 100 * discountpersentage;
                }

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
