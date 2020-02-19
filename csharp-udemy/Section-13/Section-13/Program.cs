using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization;

namespace Section_13
{
    class Program
    {
        public void Ex1()
        {
            string f1 = @"input.txt";
            // string f2 = @"output.txt";

            FileStream fs = null;
            StreamReader sr = null;

            try
            {
                fs = new FileStream(f1, FileMode.Open);
                sr = new StreamReader(fs);

                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
                if (fs != null) fs.Close();
            }
        }

        public void Ex2()
        {
            string f1 = @"input1.txt";

            try
            {
                using (FileStream fs = new FileStream(f1, FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            Console.WriteLine(line);
                        }
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }

        public void Ex3()
        {
            string f1 = @"input.txt";
            string f2 = @"output.txt";

            try
            {
                using (FileStream fs = new FileStream(f1, FileMode.Open))
                {
                    using (FileStream fs1 = new FileStream(f2, FileMode.Create))
                    {
                        using (StreamReader sr = new StreamReader(fs))
                        {
                            using (StreamWriter sw = new StreamWriter(fs1))
                            {
                                while (!sr.EndOfStream)
                                {
                                    string line = sr.ReadLine();
                                    sw.WriteLine(line);
                                }
                            }
                        }
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }

        public void Ex4()
        {
            string dir = @"/home/bernardo";

            try
            {
                IEnumerable<string> folders = Directory.EnumerateDirectories(dir, "*.*", SearchOption.TopDirectoryOnly);
                Console.WriteLine("FOLDERS: ");
                foreach (string x in folders)
                {
                    Console.WriteLine(x);
                }

                Console.WriteLine();

                var files = Directory.EnumerateFiles(dir, "*.*", SearchOption.TopDirectoryOnly);
                Console.WriteLine("FILES:");
                foreach (string x in files)
                {
                    Console.WriteLine(x);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }

        public void Ex5()
        {
            string path = @"/home/bernardo/.profile";

            Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
            Console.WriteLine("PathSeparator: " + Path.PathSeparator);
            Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path));
            Console.WriteLine("GetFileName: " + Path.GetFileName(path));
            Console.WriteLine("GetExtension: " + Path.GetExtension(path));
            Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("GetTempPath: " + Path.GetTempPath());
        }

        static void Main(string[] args)
        {
            string input = "itens.csv";
            string output = "summary.csv";
            string path = "/home/bernardo/Desktop/csharp-udemy/Section-13/Section-13/out";

            try
            {
                string[] lines = File.ReadAllLines(input);

                if (!Directory.Exists(path)) Directory.CreateDirectory(path);

                using (FileStream fs = new FileStream(path + "/" + output, FileMode.Create))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        foreach (string line in lines)
                        {
                            string[] info = line.Split(',');

                            string name = info[0];
                            double total = double.Parse(info[1], CultureInfo.InvariantCulture) * (double)int.Parse(info[2]);

                            sw.WriteLine(name + "," + total.ToString("F2", CultureInfo.InvariantCulture));
                        }
                    }
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}
