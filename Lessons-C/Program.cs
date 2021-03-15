using System;

namespace Lessons_C
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] months = { "January", "February", "March" };
            string[] tiles = { "Copper", "iron", "aluminum" };
            string[] distributors = { "World of Mine", "Miners Guild" };
            decimal[,,] array = new decimal[distributors.Length, tiles.Length, months.Length];

            for (int i = 0; i < array.GetLength(0); i++)
                for (int j = 0; j < array.GetLength(1); j++)
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        Console.Write($"{distributors[i]} продал плитки {tiles[j]} за {months[k]} : ");
                        array[i, j, k] = Convert.ToDecimal(Console.ReadLine());
                    }

            while (true)
            {
                Console.Write("Введи название дистрибьютора : ");
                string nameOfDistributor = Console.ReadLine();
                Console.Write("Введи название плитки : ");
                string nameOfTile = Console.ReadLine();
                int indexOfDistributor = Array.IndexOf(distributors, nameOfDistributor);
                int indexOfTile = Array.IndexOf(tiles, nameOfTile);

                decimal numberOfTiles = 0;
                int k;
                for (k = 0; k < array.GetLength(2); k++) 
                {
                    numberOfTiles += array[indexOfDistributor, indexOfTile, k];
                }
                Console.WriteLine($"{nameOfDistributor} продал {nameOfTile} в количестве {numberOfTiles} шт. за квартал");
                Console.WriteLine("\n Нажмите клавишу Enter для продолжения....");
            }

            Console.ReadKey(); 
        }
            
    }
}
