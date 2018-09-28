using System;

namespace Homework2
{
    class Homework2_2
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int[] array = new int[100];
            for (int k = 0; k < 100; k++)
            {
                array[k] = 0;
            }

            int i = 0;
            int j = 0;

            int count = 0;
            int sum = 0;

            string x = null;
            while (i < input.Length)
            {
                if (input[i] != ' ')
                {
                    x = x + input[i];
                }
                else
                {
                    array[j] = Convert.ToInt32(x);
                    j++;
                    count++;
                    x = null;
                }
                i++;
            }
            array[j] = Convert.ToInt32(x);
            j++;
            count++;

            int max = 0;
            int min = array[0];

            for (i = 0; i < count; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
                if (array[i] > max)
                {
                    max = array[i];
                }
                sum += array[i];
            }
            Console.Write(1.0 * sum / count + " " + sum + " " + min + " " + max);
            Console.ReadLine();
        }
    }
}