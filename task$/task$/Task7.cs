using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task_
{
    class Task7
    {
        
        public void FileRecord()
        {
            Console.WriteLine("\n/////////////////////////////////////////////////// ---- TASK #7");
            string path = @"C:\Task7File.txt";
            Console.WriteLine($"File was created. The path is {path}");

            string text;
            Console.WriteLine("\nInput some text");
            text = Console.ReadLine();
            try
            {
                using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
                {
                    sw.WriteLine(text);
                }

                Console.WriteLine("Record complete");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void FileRead()
        {
            Console.WriteLine("All the data in your file:\n");
            string path = @"C:\Task7File.txt";
            try
            {
                using (StreamReader dataFromFile = new StreamReader(path))
                {
                    Console.WriteLine(dataFromFile.ReadToEnd());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void StringsCount()
        {
            string path = @"C:\Task7File.txt";
            int stringsCount = System.IO.File.ReadAllLines(path).Length;
            Console.WriteLine($"There are {stringsCount} strings in file.");
        }
        public void WordsCount()
        {
            string path = @"C:\Task7File.txt";
            string s = "";
            string[] textArray;
            StreamReader sr = new StreamReader(path);

            while (sr.EndOfStream != true)
            {
                s += sr.ReadLine();
            }
            textArray = s.Split(' ');
            Console.WriteLine("words:");
            Console.WriteLine(textArray.Length);

            sr.Close();
        }
        public void SymbolsCount()
        {
            string path = @"C:\Task7File.txt";
            var txt = File.ReadAllText($"{path}");
            Console.WriteLine("symbols:");
            Console.WriteLine(txt.Length-2);
        }
        }
}
