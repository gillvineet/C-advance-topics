using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAdvance
{
    public  partial class Name {

        private  string name="vineet";
        private   int id=10;
        //partial method
        public partial void display();
        

    }

    public partial class Name
    {
        public  partial void display()
        {
            Console.WriteLine("{0} and {1}",name,id);
        }
    }


    internal class PartialClass
    {
        public static void Main(string[] args)
        {
            Name name = new Name();
            name.display();

        }
    }
}
