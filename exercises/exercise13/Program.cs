using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace exercise13
{
    class Program 
    {
        static void Main(string[] args)
        {
            int[] n1 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] n2 = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
            var arr1 = new[] { 3, 9, 2, 8, 6, 5 };
            int[] arr2 = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };
            string[] dayWeek = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            int[] nums = new int[] { 5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2 };
            string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };
            List<int> myList = new List<int>();
            List<int> intList = new List<int>(new int[] { 5, 7, 13, 24, 6, 9, 8, 7 });

            Console.WriteLine($"Question 1");
            Console.WriteLine($"The numbers which produce the remainder 0 after divided by 2 are:");
            n1.Where(x => x % 2 == 0).Select(x => x).ToList().ForEach(x => Console.WriteLine($"{x}"));

            Console.WriteLine($"\nQuestion 2");
            Console.WriteLine($"The numbers within the range of 1 to 11 are:");
            n2.Where(x => x > 0 && x < 12).Select(x => x).ToList().ForEach(x => Console.WriteLine($"{x}"));

            Console.WriteLine($"\nQuestion 3");
            Console.WriteLine($"The numbers with a square root is greater than 20 are:");
            arr1.Where(x => x * x > 20).Select(x => x).ToList().ForEach(x => Console.WriteLine($"{x} squared is {x * x}"));

            Console.WriteLine($"\nQuestion 4");
            Console.WriteLine($"The numbers and frequency in the array are:");
            arr2.Select(x => x).Distinct().ToList().ForEach(x => Console.WriteLine($"{x} appears {arr2.Count(d => d == x)} times"));

            Console.WriteLine($"\nQuestion 5");
            Console.WriteLine($"Enter a string to return the frequency of characters");
            char[] stringFreq = Console.ReadLine().ToCharArray();
            Console.WriteLine($"The frequency of the characters are:");
            stringFreq.Select(x => x).Distinct().ToList().ForEach(x => Console.WriteLine($"Character {x}: {stringFreq.Count(d => d == x)} times"));

            Console.WriteLine($"\nQuestion 6");
            Console.WriteLine($"The days of the week are:");
            dayWeek.Select(x => x).Distinct().ToList().ForEach(x => Console.WriteLine($"{x}"));

            Console.WriteLine($"\nQuestion 7");
            Console.WriteLine($"Number   Frequency   Number*Freq");
            nums.Select(x => x).Distinct().ToList().ForEach(x => Console.WriteLine($"{x}            {nums.Count(d => d == x)}            {x * nums.Count(d => d == x)}"));

            Console.WriteLine($"\nQuestion 8");
            cities.Where(x => x.StartsWith("C") && x.EndsWith("A")).Select(x => x).ToList().ForEach(x => Console.WriteLine($"The city starting with C and ending with A is: {x}"));

            Console.WriteLine($"\nQuestion 9");
            Console.Write($"Enter the number of integers you want to input: ");
            int iter = int.Parse(Console.ReadLine());
            int i = 1;
            while (i <= iter)
            {
                Console.Write($"Please enter integer number {i}: ");
                myList.Add(int.Parse(Console.ReadLine()));
                ++i;
            }
            Console.Write($"\nInput a value to find all numbers greater than in the list: ");
            int value = int.Parse(Console.ReadLine());
            myList.Where(x => x > value).Select(x => x).ToList().ForEach(x => Console.WriteLine($"{x} is greater than {value}"));

            Console.WriteLine($"\nQuestion 10");
            Console.WriteLine($"The members of the list are:");
            intList.ForEach(x => Console.WriteLine(x));
            Console.Write($"How many records do you want to display: ");
            int ammount = int.Parse(Console.ReadLine());
            Console.WriteLine($"The top {ammount} values from the list are:");
            intList.OrderByDescending(x => x).Select(x => x).Take(ammount).ToList().ForEach(x => Console.WriteLine($"{x}"));
        }
    }
}
