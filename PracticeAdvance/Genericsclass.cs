using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAdvance
{
    public class Change<T> {
    
        public T value;
        public Change(T value)
        {
            this.value = value;
        }
    }

    internal class Genericsclass
    {
        static void Main(string[] args)
        {
            Change<int>c = new Change<int>(1);
            Change<string> s = new Change<string>("hi");
            Console.WriteLine(s.value);
            Console.WriteLine(c.value);

        }
    }
}
