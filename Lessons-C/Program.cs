using System;

namespace Lessons_C
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lessons = { "Chemistry", "Russian language", "English language", "Geography" };
            int[] marksChemistry = { 8, 7, 9, 7, 8, 9 };
            int[] marksRussianLanguage = { 9, 9, 7, 8, 6, 9 };
            int[] marksEnglishLanguage = { 8, 8, 7, 8, 9 };
            int[] marksGeography = { 7, 7, 7, 9, 9, 8 };
            string agree = "null";
            double mediumMark = 0;


            //addMarks
            while (true)
            {

                Console.Write("Введи урок : ");
                string nameOfLesson = Console.ReadLine();
                int indexOfLesson = Array.IndexOf(lessons, nameOfLesson);
                Console.Write("Вы хотите добавить(add) оценки или посмотреть(see) : ");
                string choose = Console.ReadLine();
                if (choose == "add")
                {
                    do
                    {
                        switch (nameOfLesson)
                        {
                            case "Chemistry":
                                Console.Write($"Добавь оценку к химии : ");
                                int newMarkChemistry = Convert.ToInt32(Console.ReadLine());
                                Array.Resize(ref marksChemistry, marksChemistry.Length + 1);
                                marksChemistry[marksChemistry.Length - 1] = newMarkChemistry;
                                foreach (int i in marksChemistry)
                                    Console.Write($"{i} ");
                                Console.WriteLine();
                                Console.WriteLine("Вы еще хотите добавить оценки?");
                                agree = Console.ReadLine();
                                break;

                            case "Russian language":
                                Console.Write($"Добавь оценку к русскому языку : ");
                                int newMarkRussianLanguage = Convert.ToInt32(Console.ReadLine());
                                Array.Resize(ref marksRussianLanguage, marksRussianLanguage.Length + 1);
                                marksRussianLanguage[marksRussianLanguage.Length - 1] = newMarkRussianLanguage;
                                foreach (int i in marksRussianLanguage)
                                    Console.Write($"{i} ");
                                Console.WriteLine();
                                Console.WriteLine("Вы еще хотите добавить оценки?");
                                agree = Console.ReadLine();
                                break;
                            case "English language":
                                Console.Write($"Добавь оценку к английскому языку : ");
                                int newMarkEnglishLanguage = Convert.ToInt32(Console.ReadLine());
                                Array.Resize(ref marksEnglishLanguage, newMarkEnglishLanguage + 1);
                                marksEnglishLanguage[marksEnglishLanguage.Length - 1] = newMarkEnglishLanguage;
                                foreach (int i in marksEnglishLanguage)
                                    Console.Write($"{i} ");
                                Console.WriteLine();
                                Console.WriteLine("Вы еще хотите добавить оценки?");
                                agree = Console.ReadLine();
                                break;
                            case "Geography":
                                Console.Write($"Добавь оценку к географии : ");
                                int newMarkGeography = Convert.ToInt32(Console.ReadLine());
                                Array.Resize(ref marksGeography, marksGeography.Length + 1);
                                marksGeography[marksGeography.Length - 1] = newMarkGeography;
                                foreach (int i in marksGeography)
                                    Console.Write($"{i} ");
                                Console.WriteLine();
                                Console.WriteLine("Вы еще хотите добавить оценки?");
                                agree = Console.ReadLine();
                                break;
                            default:
                                Console.WriteLine("Нету данного урока");
                                break;
                        }
                    } while (agree == "Yes");
                }
                else if (choose == "see")
                {

                    switch (indexOfLesson)
                    {
                        case 0:
                            Console.Write($"Оценки по химии : ");
                            foreach (int i in marksChemistry)
                                Console.Write($"{i}, ");
                            Console.WriteLine();
                            break;
                        case 1:
                            Console.Write($"Оценки по русскому языку : ");
                            foreach (int i in marksRussianLanguage)
                                Console.Write($"{i}, ");
                            Console.WriteLine();
                            break;
                        case 2:
                            Console.Write($"Оценки по английскому языку : ");
                            foreach (int i in marksEnglishLanguage)
                                Console.Write($"{i}, ");
                            Console.WriteLine();
                            break;
                        case 3:
                            Console.Write($"Оценки по географии : ");
                            foreach (int i in marksGeography)
                                Console.Write($"{i}, ");
                            Console.WriteLine();
                            break;
                        default:
                            Console.WriteLine("Нету данного урока ");
                            break;

                    }
                }
                else
                {
                    Console.WriteLine("Неверная команда, попробуйте еще раз");
                }

                //markMedium
                Console.WriteLine("Хочешь узнать свой средний бал : ");
                string chooseMediumMark = Console.ReadLine();
                if (chooseMediumMark == "Yes")
                {
                    switch (nameOfLesson)
                    {
                        case "Chemistry":
                            for (int i = 0; i < marksChemistry.Length; i++)
                            {
                                mediumMark += marksChemistry[i];
                            }
                            mediumMark = mediumMark / marksChemistry.Length;
                            Console.WriteLine($"Cредний бал по химии : {mediumMark}");
                            break;
                        case "Russian language":
                            for (int i = 0; i < marksRussianLanguage.Length; i++)
                            {
                                mediumMark += marksRussianLanguage[i];
                            }
                            mediumMark = mediumMark / marksRussianLanguage.Length;
                            Console.WriteLine($"Cредний бал по русскому языку : {mediumMark}");
                            break;
                        case "English language":
                            for (int i = 0; i < marksEnglishLanguage.Length; i++)
                            {
                                mediumMark += marksEnglishLanguage[i];
                            }
                            mediumMark = mediumMark / marksEnglishLanguage.Length;
                            Console.WriteLine($"Cредний бал по английскому языку : {mediumMark}");
                            break;
                        case "Geography":
                            for (int i = 0; i < marksGeography.Length; i++)
                            {
                                mediumMark += marksGeography[i];
                            }
                            mediumMark = mediumMark / marksGeography.Length;
                            Console.WriteLine($"Cредний бал по географии : {mediumMark}");
                            break;
                    }
                }
            }

            Console.ReadKey();
        }

    }
}
