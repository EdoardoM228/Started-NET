using System;

namespace Lessons_C
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                Console.Write("Введите кол-во элементов в массиве : ");
                int sizeArray = Convert.ToInt32(Console.ReadLine());
                int[] array = new int[sizeArray];
                int index = 0;

                while (index < array.Length)
                {
                    array[index] = index;
                    Console.Write($"{array[index]}, ");
                    index++;
                }

                Console.Write("\nВведите значение нового элемента массива : ");
                int newElementArray = Convert.ToInt32(Console.ReadLine());

                Array.Resize(ref array, array.Length + 1);
                array[array.Length - 1] = newElementArray;

                index = 0;

                while (index < array.Length)
                {
                    Console.Write($"{array[index]}, ");
                    index++;
                }                 


                Console.Write("\nВведи размер массива: ");
                int n = Convert.ToInt32(Console.ReadLine());
                int[] array2 = new int[100];
                index = 0;

                Console.Write("\nВведи значение в массив: ");
                while (index < n)
                {
                    array2[index] = Convert.ToInt32(Console.ReadLine());
                    index++;
                }

                Console.WriteLine($"Сумма 0-его значения и 1 значения массива { array2[0] + array2[1]}");


                Console.ReadKey();


                 
            }
            
        }
    }
}