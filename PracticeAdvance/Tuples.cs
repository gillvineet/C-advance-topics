using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAdvance
{
    internal class Tuples
    {
        public static (string name,bool isgiven)Display(string Name)
        {
            return (Name, true);
        }
        public static void Main(string[] args)
        {
            //var student = ("hi", 1, 1.55);
            //Console.WriteLine(student.Item1);
            //Console.WriteLine(student.Item2);
            //Console.WriteLine(student.Item3);


            //(string Name, int Age) Detail = ("vineet", 11);
            //(string Name, int Age) Detail1 = ("vineet", 11);
            //Console.WriteLine(Detail.Age);
            //Console.WriteLine(Detail.Name);
            //Detail.Age = 20;
            //Console.WriteLine(Detail.Age);
            //Console.WriteLine(Detail==Detail1);
           (String Name,bool isture)ok= Display("Gill");
            Console.WriteLine(ok.Name);


        }
    }
}
