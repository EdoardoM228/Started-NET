using System;

namespace Lessons_C
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите план продаж : ");
            decimal plan = Convert.ToDecimal(Console.ReadLine());

            string[] nameArray;
            Console.Write("Введите имена продажников через запятую :");
            string name = Console.ReadLine();
            nameArray = name.Split(',');

            for (int i = 0; i < nameArray.Length; i++)
            {
                nameArray[i] = nameArray[i].Trim();
            }

            decimal[][] nameArrayJugged = new decimal [nameArray.Length][];
            for (int i = 0; i < nameArray.Length; i++)
            {
                Console.Write($"Введите суммы продаж которые совершил {nameArray[i]}: ");
                string sums = Console.ReadLine();
                string[] sumArray = sums.Split(',');
                nameArrayJugged[i] = new decimal[sumArray.Length];

                for (int j = 0; j < sumArray.Length; j++)
                {
                    string sum = sumArray[j].Trim();
                    nameArrayJugged[i][j] = Convert.ToDecimal(sum);
                }
            }

            decimal[] totalSumArray;
            totalSumArray = new decimal[nameArrayJugged.Length];

            for (int i = 0; i < totalSumArray.Length; i++)
            {
                decimal totalsum = 0;

                for (int j = 0; j < nameArrayJugged[i].Length; j++)
                {
                    totalsum += nameArrayJugged[i][j];
                }
                totalSumArray[i] = totalsum;
            }

            for (int i = 0; i < totalSumArray.Length; i++)
            {
                Console.Write($"{nameArray[i]} продал товара на сумму {totalSumArray[i]}");
                decimal persent;

                if (totalSumArray[i] < plan)
                {
                    persent = (plan - totalSumArray[i]) / (plan / 100);
                    Console.WriteLine($"План недовыполнен на {persent}");
                }
                else if (totalSumArray[i] == plan)
                {
                    Console.WriteLine("План выполнен на 100%");
                }
                else
                {
                    persent = (totalSumArray[i] - plan) / (plan / 100);
                    Console.WriteLine($"План перевыполнен на {persent}");
                }
            }
            
            for (int i = 0; i < nameArrayJugged.Length; i++)
            {
                Array.Sort(nameArrayJugged[i]);
                int lastIndex = nameArrayJugged[i].Length - 1;
                Console.WriteLine($"{nameArray[i]} : мин. продаж = {nameArrayJugged[i][0]} , макс. продажа = {nameArrayJugged[i][lastIndex]}");
            }

            Console.ReadKey();
        }

    }
}
