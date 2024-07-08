using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAdvance
{
    internal class FileStreamClas
    {
        public static void Main(string[] args)
        {
            //string path = "D:\\myFile.txt";
            //FileStream file=new FileStream(path, FileMode.Create,FileAccess.Write);
            //file.WriteByte(65);
            //file.Close();

            //Append data
            string path = "D:\\myFile.txt";
            FileStream file = new FileStream(path, FileMode.Append, FileAccess.Write);
           //  file.Appe
        }
    }
}
