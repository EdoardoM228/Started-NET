using System;

namespace Lessons_C
{
    class Program 
    { 
        static void Main(string[] args)
        {
             float T_mo, T_tu, T_we, T_th, T_fr, T_sa, T_su, T_sum, T_avg;
             int sevendays = 7;

             T_mo = Convert.ToSingle(Console.ReadLine());
             T_tu = Convert.ToSingle(Console.ReadLine());
             T_we = Convert.ToSingle(Console.ReadLine());
             T_th = Convert.ToSingle(Console.ReadLine());
             T_fr = Convert.ToSingle(Console.ReadLine());
             T_sa = Convert.ToSingle(Console.ReadLine());
             T_su = Convert.ToSingle(Console.ReadLine());
             
             T_sum = T_mo + T_tu + T_we + T_th + T_fr + T_sa + T_su;
             T_avg = T_sum / sevendays;


            Console.WriteLine(T_sum);
            Console.WriteLine(T_avg);

            Console.ReadKey();






        }
    }
}
