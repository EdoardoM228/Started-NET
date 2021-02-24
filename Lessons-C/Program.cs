using System;

namespace Lessons_C
{
    class Program 
    { 
        static void Main(string[] args)
        {
            Console.Beep(786, 1000); // воспроизведение звука Console.Beep(int частота, int длительность)

            Console.ForegroundColor = ConsoleColor.DarkGreen; // Задаю параметр цвета букв (Темно-зеленный)
            Console.BackgroundColor = ConsoleColor.Yellow; //Задаю параметр цвета заднего фона (Желтый) 

            Console.WriteLine("Ya temno zelenii");
            Console.WriteLine("I ya toje YrAAAA");

            Console.ResetColor(); //Отменил прошлые параметры цвета 

            Console.WriteLine("Blin a ya belii");

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.BackgroundColor = ConsoleColor.Yellow;

            Console.Write("A net pokazalosi , ya ne belii");

            Console.ReadKey();



        }
    }
}
