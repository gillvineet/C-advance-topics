using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAdvance
{
    internal class String_builder
    {
        static void Main(string[] args)
        {
            StringBuilder s=  new StringBuilder("Vineet");
            s.Append("Gill");
            s.AppendLine("Cse");
            s.Append("hi");
            s.AppendFormat("{0:C}",25);
         
            s.Insert(15, "Gillboy");
            s.Remove(15,10);
            s.Replace("hi","gill");
            
            Console.WriteLine(s);
        }
    }
}
