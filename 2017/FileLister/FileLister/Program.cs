using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileLister
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] files;
            string path;
            Console.WriteLine("Enter folder path to list contents.");
            Console.Write("Path: ");
            path = Console.ReadLine();
            files = Directory.GetFiles(path);
            using (StreamWriter sw = new StreamWriter(path + "\\Files.csv"))
            {
                foreach (string f in files)
                {

                    string name = Path.GetFileName(f);
                    if (!name.Contains("AlbumArt"))
                        {
                            Console.WriteLine(name);
                            sw.WriteLine(name);
                        }
                }
            }
            Console.ReadLine();
        }
    }
}
