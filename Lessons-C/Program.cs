using System;

namespace Lessons_C
{
    class Program
    {
        static void Main(string[] args)
        {
            int tipsPies, tipsIngredientsForPies;
            {
                Console.Write("Введи кол-во видов пирожков : ");
                tipsPies = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите кол-во требуемых ингредиентов : ");
                tipsIngredientsForPies = Convert.ToInt32(Console.ReadLine());
            }

            decimal[,] ingredientsQuantity = new decimal[tipsPies, tipsIngredientsForPies];
            decimal[,] costIngredients = new decimal[tipsIngredientsForPies, 1];
            decimal[] Pies = new decimal[tipsPies];
            decimal[,] costPie = new decimal[tipsPies, 1];

            for (int i = 0; i < ingredientsQuantity.GetLength(0); i++)
            {
                for (int j = 0; j < ingredientsQuantity.GetLength(1); j++)
                {
                    Console.Write($"Введите кол-во ингрендиентов №{j + 1} для пирожков №{i + 1}(кг) : ");
                    ingredientsQuantity[i, j] = Convert.ToDecimal(Console.ReadLine());
                }
            }

            for (int i = 0; i < costIngredients.GetLength(0); i++)
            {
                Console.Write($"Введи цену ингредиента №{i + 1} : ");
                costIngredients[i, 0] = Convert.ToDecimal(Console.ReadLine());
            }

            for (int i = 0; i < Pies.Length; i++)
            {
                Console.Write($"Введи кол-во пирожков №{i + 1} : ");
                Pies[i] = Convert.ToDecimal(Console.ReadLine());
            }


            for (int i = 0; i < ingredientsQuantity.GetLength(0); i++)
            {
                for (int j = 0; j < ingredientsQuantity.GetLength(1); j++)
                {
                    costPie[i, 0] += ingredientsQuantity[i, j] * costIngredients[j, 0];
                }
            }

            decimal allCostPies = 0;

            for (int i = 0; i < costPie.GetLength(0); i++)
            {
                allCostPies += Pies[i] * costPie[i, 0];
            }

            Console.WriteLine($"Общая стоимость пирожков : {allCostPies}");
            Console.ReadKey(); 
        }
            
    }
}
