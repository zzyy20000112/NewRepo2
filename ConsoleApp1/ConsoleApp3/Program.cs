using System;

namespace Homework2
{
    class Homework2_1
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= x; i++)
            {
                if (x % i == 0) Console.WriteLine(i + " ");
            }
            Console.ReadLine();
        }
    }
}