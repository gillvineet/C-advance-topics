using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAdvance
{
    public class Add {

        public static void print<T>(T[]arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    
    }

    internal class GenericFunctions
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            string[] brr = { "ho", "by", "gy" };
            Add.print(arr);
            Add.print(brr);
        }
    }
}
