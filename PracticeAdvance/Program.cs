namespace PracticeAdvance
{
    public class Practice
    {

        public Practice(string name)
        {
            Name = name;
        }

        public string Name { get; init; }
    }

    internal class Program
    {
        
        static void Main(string[] args)
        {
            Practice p=new Practice("vineet");
            
            Console.WriteLine(p.Name);
        }
    }
}
