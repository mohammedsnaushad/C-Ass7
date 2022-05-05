using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace filehandling
{
    internal class FileIOassmnt_
    {
        class Assignmen1
        {
            static void Main(string[] args)
            {
                string path = @"C:\Users\LENOVO\Demo.txt";

                using (FileStream file = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    using (StreamReader reader = new StreamReader(file))
                    {
                        //string line = reader.ReadLine();
                        string line = "";
                        while ((line = reader.ReadLine()) != null)
                        {
                            Console.WriteLine(line);
                        }
                    }

                }
                string path1 = @"C:\Users\LENOVO\File";
                DirectoryInfo dir = new DirectoryInfo(path1);
                DirectoryInfo[] dirs = dir.GetDirectories();
                foreach (var item in dirs)
                {
                    Console.WriteLine(item.GetFiles().Length);
                }
                Console.ReadLine();


            }
        }
    }
}