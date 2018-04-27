using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy
{
    public class journal {
        private readonly List<string> entries = new List<string>();
        private static int count = 0;
        public int AddEntery(string text) {
            entries.Add($"{++count}:{text}");
            return count;
        }
        public void RemoveEntery(int index) {
            entries.RemoveAt(index);
        }
        public override string ToString()
        {
            return string.Join(Environment.NewLine,entries);
        }
   
    }

    public class Persistence{
        public void SaveToFile(journal j, string filename,bool overwrite = false) {
            if (overwrite || File.Exists(filename)) {
                File.WriteAllText(filename, j.ToString());
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var j = new journal();
            j.AddEntery("Some string 1");
            j.AddEntery("Some string 2");

            Console.WriteLine(j);

            var p = new Persistence();
            string filename = @"journal.txt";
            p.SaveToFile(j,filename,true);
            Process.Start(filename);



            Console.WriteLine("Press <enter> to quit:");
            Console.Read();
        }
    }
}
