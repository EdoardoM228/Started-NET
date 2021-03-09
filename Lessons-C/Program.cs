using System;

namespace Lessons_C
{
    class Program 
    { 
        static void Main(string[] args)
        {
            string countryCode = "Азербайджан 994 ,Молдова 373, Армения 374, Россия 7, Беларусь 375, Таджикистан 992, Казахстан 7,"+
            " Туркменистан 993 , Кыргызстан 996, Украина 380, Латвия 371, Узбекистан 998, Литва 370, Эстония 372";
            decimal plitkaKoliscestvo, plitkaCena;

            Console.WriteLine(countryCode);
           
            {
                Console.WriteLine("Введите телефонный код страны : ");
                countryCode = Console.ReadLine();
                Console.WriteLine("Введите кол-во плитки : ");
                plitkaKoliscestvo = Convert.ToUInt32(Console.ReadLine());
                Console.WriteLine("Введите Цену плитки : ");
                plitkaCena = Convert.ToUInt32(Console.ReadLine());

            }

            decimal rate;
            {
                const string AZEGBAINJAN_CODE = "994", ARMENIA_CODE = "374", BELARUS_CODE = "375", KAZAKHSTAN_CODE = "007", KYRGYZSTAN_CODE = "996",
                             LATVIA_CODE = "371", LITHUANIA_CODE = "370", MOLDOVA_CODE = "373", RUSSIA_CODE = "007", TAJIKISTAN_CODE = "992",
                             TURKMENISTAN_CODE = "993", UZBEKISTAN_CODE = "998", UKRAINE_CODE = "380", ESTONIA_CODE = "372";
               
                if (countryCode == AZEGBAINJAN_CODE)
                {
                    const decimal AZEGBAINJAN_RATE = 1.07m;
                    rate = AZEGBAINJAN_RATE;
                }
                else if (countryCode == ARMENIA_CODE)
                {
                    const decimal ARMENIA_RATE = 0.95m;
                    rate = ARMENIA_RATE;
                }
                else if (countryCode == BELARUS_CODE)
                {
                    const decimal BELARUS_RATE = 1;
                    rate = BELARUS_RATE;
                }
                else if (countryCode == KAZAKHSTAN_CODE)
                {
                    const decimal KAZAKHSTAN_RATE = 0.79m;
                    rate = KAZAKHSTAN_RATE;
                }
                else if (countryCode == KYRGYZSTAN_CODE)
                {
                    const decimal KYRGYSTAN_RATE = 0.83m;
                    rate = KYRGYSTAN_RATE;
                }
                else if (countryCode == LATVIA_CODE)
                {
                    const decimal LATVIA_RATE = 1.12m;
                    rate = LATVIA_RATE;
                }
                else if (countryCode == LITHUANIA_CODE)
                {
                    const decimal LITHUANIA_RATE = 1.12m;
                    rate = LITHUANIA_RATE;
                }
                else if (countryCode == MOLDOVA_CODE)
                {
                    const decimal MOLDOVA_RATE = 0.97m;
                    rate = MOLDOVA_RATE;
                }
                else if (countryCode == RUSSIA_CODE)
                {
                    const decimal RUSSIA_RATE = 1;
                    rate = RUSSIA_RATE;
                }
                else if (countryCode == TAJIKISTAN_CODE)
                {
                    const decimal TAJIKISTAN_RATE = 0.76m;
                    rate = TAJIKISTAN_RATE;
                }
                else if (countryCode == TURKMENISTAN_CODE)
                {
                    const decimal TURKMENISTAN_RATE = 0.81m;
                    rate = TURKMENISTAN_RATE;
                }    
                else if (countryCode == UZBEKISTAN_CODE)
                {
                    const decimal UZBEKISTAN_RATE = 0.98m;
                    rate = UZBEKISTAN_RATE;
                }
                else if (countryCode == UKRAINE_CODE)
                {
                    const decimal UKRAINE_RATE = 1m;
                    rate = UKRAINE_RATE;
                }
                else if (countryCode == ESTONIA_CODE)
                {
                    const decimal ESTONIA_RATE = 1.12m;
                    rate = ESTONIA_RATE;
                }
                else
                {
                   rate = 0;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Вы ввели не существующий код : {countryCode}!");
                }
            }
           
            decimal cenaPlitkiWithRate = plitkaCena * rate;
            decimal fullPriceTale = cenaPlitkiWithRate * plitkaKoliscestvo;
            
                
            

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
                        else if (discountFor50Pct)
                        {
                            discountpersentage = 50;
                        }
                        else
                        {
                            discountpersentage = 0;
                        }
                   
                    }
                    priceDiscount = fullPriceTale / 100 * discountpersentage;
                }

            }
            decimal totalPriceTale;
            {
                totalPriceTale = fullPriceTale - priceDiscount;
            }

            Console.WriteLine($"Цена с коэффициентом : {cenaPlitkiWithRate}  руб.");
            Console.WriteLine($"Общая стоимость : {fullPriceTale}  руб.");
            Console.WriteLine($"Сумма скидки : {priceDiscount} руб.");
            Console.WriteLine($"Сумма к оплате : {totalPriceTale} руб.");
            
            Console.ReadKey();



        }
    }
}
