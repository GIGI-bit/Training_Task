using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public static class Practics
    {
        public static bool IsPalindrome<T>(T value)
        {
            string valueStr = value.ToString();

            int length = valueStr.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (valueStr[i] != valueStr[length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }
        public static void SecondLargeArray(int[] ary)
        {
            int firstMax = ary.Min();
            int secondMax = ary.Min();
            foreach (var item in ary)
            {
                if (item > firstMax)
                {
                    secondMax = firstMax;
                    firstMax = item;
                }
                else if (item > secondMax && item != firstMax)
                {

                    secondMax = item;
                }


            }
            if (secondMax == int.MinValue)
            {
                Console.WriteLine("No Second Largest Number");


            }
            else { Console.WriteLine("Second Largest is " + secondMax); }

        }

       public static int FibonacciNum(int number)
        {
            if (number <= 0) return 0;
            if (number == 1) return 1;
            return FibonacciNum(number - 1) + FibonacciNum(number - 2);
        }


        public static void FindUnique(string name)
        {
            Console.WriteLine("Unique Letters are ");
            int count = 0;
            char letter = ' ';
            for (global::System.Int32 i = 0; i < name.Length; i++)
            {

                //for (global::System.Int32 j = 0; j < name.Length; j++)
                //{
                count = name.Count(p => p.Equals(name[i]));

                letter = name[i];

                //}
                if (count == 1)
                {
                    Console.WriteLine(letter);
                }
            }



        }



    }
   

}
