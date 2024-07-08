using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAdvance
{
    internal class Exceptionhandling
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 0;
            //try
            //{
            //    int c = a / b;

            //}
            //catch(Exception e) 
            //{
            //    Console.WriteLine(e.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("code exectued sucesfully");
            //}
            //Our own through
            int age = 15;
            try
            {
                if (age >= 18) Console.WriteLine("you can vote");
                else
                {
                    throw new Exception("you can not vote");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}
