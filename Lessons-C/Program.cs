using System;

namespace Lessons_C
{
    class Program 
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Im coffee machine....");
            Console.WriteLine("How coffee size you need : 1=small 2=medium 3=large");
            Console.Write("Enter number or word : ");

            string sizeCoffee = Console.ReadLine();
            int priceCoffee = 0;

            switch (sizeCoffee)
            {
                case "1" :
                case "small":
                    priceCoffee += 25;
                    break;
                case "2" :
                case "medium" :
                    priceCoffee += 50;
                    break;
                case "3" :
                case "large":
                    priceCoffee += 75;
                    break;
                default :
                    Console.WriteLine("Invalid number...Try again");
                    break;
            }

            
            if (priceCoffee != 0)
            {
                Console.WriteLine($"Your coffee price is : {priceCoffee}");
            }

            // switch (priceCoffee)
            // {
            //  case 25:
            // case 50:
            // case 75:
            //   Console.WriteLine($"Your coffee price is : {priceCoffee}");
            //  break;
            // }


            Console.WriteLine("Hello Im downloader.....");
            Console.WriteLine("What operating system you have : 1=windows 2=linux 3=IOS");
            Console.Write("Enter your operating system : ");

            int operatingSystem = Convert.ToInt32(Console.ReadLine());


            switch (operatingSystem)
            {
                case 1 :
                    Console.WriteLine("Download started on WINDOWS");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case 2 :
                    Console.WriteLine("Download started on LINUX");
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case 3 :
                    Console.WriteLine("Download started on IOS");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                default :
                    Console.WriteLine("We dont support this is operating systems.....");
                    break;
            }





            Console.ReadKey();



        }
    }
}
