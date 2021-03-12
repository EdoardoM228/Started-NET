using System;

namespace Lessons_C
{
    class Program 
    { 
        static void Main(string[] args)
        {

            while (true)
            {
                string sizeCoffee;
                bool correctNumber;

                do
                {
                    Console.WriteLine("Hello Im coffee machine....");
                    Console.WriteLine("How coffee size you need : 1=small 2=medium 3=large");
                    Console.Write("Enter number or word : ");
                    sizeCoffee = Console.ReadLine();
                    switch (sizeCoffee)
                    {
                        case "1":
                        case "2":
                        case "3":
                            correctNumber = false;
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"Вы ввели неверный символ : {sizeCoffee}");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            correctNumber = true;
                            break;
                    }
                }
                while (correctNumber);



                int priceCoffee = 0;

                switch (sizeCoffee)
                {
                    case "1":
                    case "small":
                        priceCoffee += 25;
                        break;
                    case "2":
                    case "medium":
                        priceCoffee += 50;
                        break;
                    case "3":
                    case "large":
                        priceCoffee += 75;
                        break;
                    default:
                        Console.WriteLine("Invalid number...Try again");
                        break;
                }


                if (priceCoffee != 0)
                {
                    Console.WriteLine($"Your coffee price is : {priceCoffee}");
                }

                // switch (priceCoffee)
                // {
                // case 25:
                // case 50:
                // case 75:
                //   Console.WriteLine($"Your coffee price is : {priceCoffee}");
                //  break;
                // }

                Console.WriteLine("Нажмите Enter после завершения заказа.");
                Console.ReadKey();


            }
        }
    }
}
