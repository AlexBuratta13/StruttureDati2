using System;
using System.Collections.Generic;
using System.IO;

namespace StruttureDati2
{
    class Program
    {
        private const string file = @"file.txt";
        private const string file1 = @"file1.txt";
        static void Main(string[] args)
        {
            HashSet<int> numeri = new HashSet<int>();
            using (StreamReader rfile = new StreamReader(file))
            {
                string line;
                while ((line = rfile.ReadLine()) != null)
                {
                    int n = int.Parse(line);
                    numeri.Add(n);
                }
            }
            using (StreamWriter swfile = new StreamWriter(file1, false))
            {
                foreach (int d in numeri)
                swfile.WriteLine(d);
            }
        }
    }
}
