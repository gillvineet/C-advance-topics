using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAdvance
{
    internal class Param
    {
        public  static void solve(params int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine(sum);
        }
        static void Main(string[] args)
        {
            solve(10, 20, 30, 40, 50);
        }
    }
}
