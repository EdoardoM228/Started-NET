using System;

namespace Lessons_C
{
    class Program 
    { 
        static void Main(string[] args)
        {
            byte a = 255; //struc Int32
            sbyte b = -128; //struc Int32
            ushort c = 65535; //struc Int32
            short d = -32768; //struc Int32

            uint e = 4294967295; //struc UInt32
            int f = -2147483648; //struc UInt32

            ulong g = 18446744073709551615; //struc UInt64
            long h = -9223372036854775808; //struc UInt64

            float i = (float)-1.12345; //произвел явный кастинг(опасный) из float в double
            double j = -1.12345; //struc double
            decimal k = -1.12345M; // поставил суффикс M для создание литерала decimal

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);

            Console.WriteLine(e);
            Console.WriteLine(f);

            Console.WriteLine(g);
            Console.WriteLine(h);

            Console.WriteLine(i);
            Console.WriteLine(j);
            Console.WriteLine(k);




            Console.ReadKey();



        }
    }
}
