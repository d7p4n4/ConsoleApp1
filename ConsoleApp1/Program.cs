using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = "First line" + Environment.NewLine;
            File.WriteAllText(Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName), text);
            Console.WriteLine(Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName));
            Console.WriteLine(File.Exists(Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "/WriteFile.txt"));
        }
    }
}
