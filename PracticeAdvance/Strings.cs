using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAdvance
{
    internal class Strings
    {
        public static void Main(string[] args)
        {
            //Clone
            //string s = new string("hi i am vineet gill");
            //string v = (string)s.Clone();
            //Console.WriteLine(s);
            //Console.WriteLine(v);
            //char[] charArray= s.ToCharArray();
            //charArray[0]='a';
            //string Modified = new string(charArray);
            //Console.WriteLine(Modified);

            //Compare
            //string a = new string("vineet");
            //string b = new string("vineet");
            //Console.WriteLine(a.CompareTo(b));

            //Concat
            //string a = new string("vineet");
            //string b = new string("gill");
            //string c=string.Concat(a,b);   
            //Console.WriteLine(c);

            //contains
            //string a = new string("Vineet");
            //string b = new string("inee");
            //Console.WriteLine(a.Contains(b));

            //EndsWith
            //string a = new string("Vineet");
            //Console.WriteLine(a.EndsWith("eet"));

            //Equals
            //string a = new string("Vineet");
            //string b= new string("vineet");
            //Console.WriteLine(a.Equals(b));

            //Format
            //String interpolation

            //StringEnumerator
            //string a = new string("Vineet");
            //a.GetEnumerator().MoveNext();

            //Get Hashcode
            //string a = new string("Vineet");
            //Console.WriteLine(a.GetHashCode());

            //Index of
            //string a = new string("Vineet");
            //Console.WriteLine(a.IndexOf("neet"));

            //IndexofAny
            //string a = new string("Vineet");
            //Console.WriteLine(a.IndexOfAny(['a','e','i']));

            //Insert(int,string)
            //string a = new string("Vineet");
            //string b=a.Insert(3,"vineet");
            //Console.WriteLine(b);
            //IsNUllOrEmpty
            //string a = new string(" fgr ");
            ////Console.Write(String.IsNullOrEmpty(a));
            //Console.WriteLine(string.IsNullOrWhiteSpace(a));

            //join
            // char[] ch = { 'A', 'B', 'C', 'D', 'F', 'G', 'H' };
            //string a= String.Join("-",ch);
            // Console.WriteLine(a);

            //Last Index of
            //string a = new string("Vineet");
            //Console.WriteLine(a.LastIndexOf('e'));

            //Padof
            //string s1 = "GeeksForGeeks";

            //Console.WriteLine("Pad  2 :'{0}'", s1.PadLeft(2));
            //Console.WriteLine("Pad 13 :'{0}'", s1.PadLeft(13));
            //Console.WriteLine("Pad 20 :'{0}'", s1.PadLeft(20,'*'));

            //Remove()
            //string s1 = "GeeksForGeeks";
            //Console.WriteLine(s1.Remove(3,5));
            //Replace()
            //string s1 = "GeeksForGeeks";
            //Console.WriteLine(s1.Replace('s', 'G'));

            //Split
            //string s1 = "Geeks-For-Geeks";
            //string[] arr= s1.Split('-');
            //foreach (string s in arr)
            //{
            //    Console.WriteLine(s);
            //}
            //Start with
            //string s1 = "GeeksForGeeks";
            //Console.WriteLine(s1.StartsWith("Geeks"));

            //Substring()
            //string s1 = "GeeksForGeeks";
            //Console.WriteLine(s1.Substring(3, 5));

            //Tosrting
            //int a = 4;
            //string b=a.ToString();
            //Console.WriteLine(b);

            //TrimEnd()
            string s1 = "0000000****GeeksForGeeks0000**";
            char[] ch = { '0', '*'};
            Console.WriteLine(s1.TrimStart(ch));
            Console.WriteLine(s1.TrimEnd(ch));

        }
    }
}
