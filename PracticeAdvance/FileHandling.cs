using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PracticeAdvance
{
    internal class FileHandling
    {
        public static void Main(string[] args)
        {
            //string path = "D:\\myfile.txt";
            //if (File.Exists(path))
            //{
            //    Console.WriteLine("file exist");
            //    string data=File.ReadAllText(path);
            //    Console.WriteLine(data);
            //}
            //else
            //{
            //    Console.WriteLine("not exist");
            //}

            //Copy

            //string path1= "D:\\myfile1.txt";
            //File.Copy(path, path1);
            //string data1=File.ReadAllText(path1);
            //Console.WriteLine(data1);



            //DirectoryInfoClass

            //string path = "D:\\My Directory";
            //DirectoryInfo dir = new DirectoryInfo(path);
            //dir.Create();
            //Console.WriteLine( "directory created");

            //Sub directory
            //dir.CreateSubdirectory("My Subdirectory");

            //Move to
            //string path2 = "D:\\MyFOlder";
            //dir.MoveTo(path2);

            //Delete directory
            string path = "D:\\MyFOlder";
            DirectoryInfo dir = new DirectoryInfo(path);
            dir.Delete(true);

        }
    }
}
