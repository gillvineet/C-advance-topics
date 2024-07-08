using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAdvance
{
    public class Extension {
     
        public void func1()
        {
            Console.WriteLine("hi i am func1");
        }
        public void func2()
        {
            Console.WriteLine("hi i am funcn2");
        }
    
    
    }

    internal class ExtensionMethod
    {
        public static void Main(string[] args)
        {
            Extension method = new Extension();
            method.func1();
            method.func2();
            method.fun3();
            Console.ReadKey();

        }
    }
}
