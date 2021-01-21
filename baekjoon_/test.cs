using System;

namespace baekjoon
{
    class Program
    {
        static int Uq(int p0, int p1)
        {
            while (true)
            {
                if (p1 == 0) return p0;
                var p2 = p0;
                p0 = p1;
                p1 = p2 % p1;
            }
        }

        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            for (var x = 0; x < int.Parse(input); x += 1)
            {
                var input_temp = Console.ReadLine();
                var arrInput = input_temp.Split();
                var a = int.Parse(arrInput[0]) > int.Parse(arrInput[1]) ? int.Parse(arrInput[0]) : int.Parse(arrInput[1]);
                var b = int.Parse(arrInput[0]) > int.Parse(arrInput[1]) ? int.Parse(arrInput[1]) : int.Parse(arrInput[0]);
                var re = Uq(a, b);
                Console.WriteLine(a / re * b);
            }
        }
    }
}