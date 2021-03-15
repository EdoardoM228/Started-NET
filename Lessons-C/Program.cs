using System;

namespace Lessons_C
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] months = { "January", "February", "March" };
            string[] ore = { "Copper", "iron", "aluminum" };
            string[] distributors = { "World of Mine", "Miners Guild" };
            string[] countries = { "Germany", "Russia" };
            decimal[,,,] array = new decimal[countries.Length, distributors.Length, ore.Length, months.Length];

            for (int i = 0; i < array.GetLength(0); i++)
                for (int j = 0; j < array.GetLength(1); j++)
                    for (int k = 0; k < array.GetLength(2); k++)
                        for (int l = 0; l < array.GetLength(3); l++)
                    {
                        Console.Write($"{distributors[j]} продал руды {ore[k]} за {months[l]} в {countries[i]}: ");
                        array[i, j, k, l] = Convert.ToDecimal(Console.ReadLine());
                    }

            while (true)
            {
                Console.Write("Введи название дистрибьютора : ");
                string nameOfDistributor = Console.ReadLine();
                Console.Write("Введи название руды : ");
                string nameOfOre = Console.ReadLine();
                int indexOfDistributor = Array.IndexOf(distributors, nameOfDistributor);
                int indexOfOre = Array.IndexOf(ore, nameOfOre);

                decimal numberOfTiles = 0;
                int k, l;
                for (l = 0; l < array.GetLength(0); l++)
                {
                    for (k = 0; k < array.GetLength(3); k++)
                    {
                        numberOfTiles += array[l, indexOfDistributor, indexOfOre, k];
                    }
                }
                Console.WriteLine($"{nameOfDistributor} продал {nameOfOre} в количестве {numberOfTiles} шт. за квартал");
                Console.WriteLine("\n Нажмите клавишу Enter для продолжения....");
            }

            Console.ReadKey(); 
        }
            
    }
}
