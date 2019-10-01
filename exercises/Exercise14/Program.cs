using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise14
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "This is Cohort 7 (seven)";
            int len = text.Length;
            int[] numbers = new int[len];
            for(int i = 0; i < len; i++)
            {
                Console.Write($"{text[i]} ");
                numbers[i] = (int)text[i];
            }
            Console.WriteLine();
            for (int i = 0; i < len; i++)
            {
                Console.Write($"{numbers[i]} ");
            }
            Console.WriteLine();
            int[] test = { 72, 101, 108, 108, 111, 32, 87, 111, 114, 108, 100, 33 };
            len = test.Length;
            for(int i = 0; i < len; i++)
            {
                Console.Write($"{(char) test[i]} ");
            }
            Console.WriteLine();
        }
    }
}
