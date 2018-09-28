using System;

namespace Homework2
{
    class Homework2_3
    {
        static void Main(string[] args)
        {
            for (int i = 2; i <= 100; i++)
            {
                bool isPrime = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime) Console.Write(i + " ");
            }
            Console.ReadLine();
        }
    }
}