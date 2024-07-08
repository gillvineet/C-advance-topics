using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAdvance
{
    internal class Methods
    {
        //public  static void print(params int[] numbers)
        //{
        //    for (int i = 0; i < numbers.Length; i++)
        //    {
        //        Console.WriteLine(numbers[i]);
        //    }

        //}
        public static void print(int a=10,int b=default)
        {
            Console.WriteLine(a+b);
        }
        static void Main(string[] args)
        {
            print(5,10);
        }
    }
}
