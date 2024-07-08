using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAdvance
{
    internal class Multithreading
    {
       public static void funct1()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("f1" + " " + i);
            }
        }
       public static void funct2()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("f2" +" "  +i);
                //if (i == 25)
                //{
                //    Thread.Sleep(8000);
                //}
            }
        }
        public static void funct3()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("f3" + " " + i);
            }
        }
        public static void Main(string[] args)
        {
            Thread t1 = new Thread(funct1);
            Thread t2 = new Thread(funct2);
            Thread t3 = new Thread(funct3);
            t1.Start();
            t2.Start();
            t3.Start();


        }
    }
}
