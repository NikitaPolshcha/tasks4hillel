using System;
using System.Collections.Generic;

namespace task_
{
    class Program
    {
        static void Main(string[] args)
        {
            task1();
            task2();
            task3();
            task4();
            task5();
            task6();
            Task7 task7 = new Task7();
            task7.FileRecord();
            Console.WriteLine("Want to display the data from file? (y/n):");
            char decision7;
            try
            {
                decision7 = Convert.ToChar(Console.ReadLine());
                switch (decision7)
                {
                    case 'y':
                    case 'Y':
                            {
                            task7.FileRead();
                            break;
                        }
                    case 'n':
                    case 'N':
                        {
                            break;
                        }

                            default:
                        Console.WriteLine("There is an exception..");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            task7.StringsCount();
            task7.WordsCount();
            task7.SymbolsCount();
            Task8 task8 = new Task8();
            task8.Dates();
            DerivedPoint task10 = new DerivedPoint();
            task10.Task10();
            Task11 task11 = new Task11();
            task11.Task11Method();


            Console.ReadKey();
        }
        static void task1()
        {
            Console.WriteLine("\n/////////////////////////////////////////////////// ---- TASK #1");
            Console.WriteLine("1 to 100");
            for (int i = 1; i < 101; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.Write($"{i} HelloWorld ");
                }
                else if (i % 3 == 0)
                {
                    Console.Write($"{i} Hello ");
                }
                else if (i % 5 == 0)
                {
                    Console.Write($"{i} World ");
                }
            }
        }
        static void task2()
        {
            Console.WriteLine("\n/////////////////////////////////////////////////// ---- TASK #2");
            Random random = new Random();
            int sum = 0;
            int[] array = new int[10];
            for (int i = 0; i < 10; i++)
            {
                array[i] = random.Next(11,21);
                sum += array[i];
                Console.Write($"[{i}] {array[i]} ");
            }
            double average = sum / 10;
            Console.WriteLine($"\nthe average is {average}");
        }
        static void task3()
        {
            Console.WriteLine("\n/////////////////////////////////////////////////// ---- TASK #3");
            Console.WriteLine($"ÍNPUT THE NUMBER BETWEEN 1 and {Int32.MaxValue}:");
            string data = Console.ReadLine();
            try
            {
                Convert.ToInt32(data);
            }
            catch (Exception)
            {
                Console.WriteLine("try again");
                task3();
            }

            try
            {
                if (Convert.ToInt32(data) == 0)
                {
                    Console.WriteLine("NO 0, error");
                    task3();

                }
                else if (Convert.ToInt32(data) < 0 || Convert.ToInt32(data) == Int32.MaxValue)
                {
                    Console.WriteLine("error");
                    task3();
                }
                else if (Convert.ToInt32(data) > 0 || Convert.ToInt32(data) != Int32.MaxValue)
                {
                    int number = Convert.ToInt32(data);
                    int counter = 0;
                    for (int i = 1; i < number + 1; i++)
                    {
                        if (number % i == 0)
                        {
                            counter++;
                            Console.WriteLine($"{i} is a divider of {number}");
                        }
                    }
                    Console.WriteLine($"There are {counter} deviders of {number}!");
                    if (counter == 1 || counter == 2)
                    {
                        Console.WriteLine(".. so the number is SIMPLE");
                    }
                }
            }
            catch (Exception)
            {

                Console.WriteLine("SMTH WENT WRONG");
                task3();
            }

            
           
        }
        static void task4()
        {
            Console.WriteLine("\n/////////////////////////////////////////////////// ---- TASK #4");
            string string1;
            Console.WriteLine("PLEASE, INPUT SMTH (max 3 symb):");
            string1 = Console.ReadLine();
            if (string1.Length > 3)
            {
                Console.WriteLine("there are more then 3 symbols. try again");
                task4();
            } else
            {
                Console.WriteLine($"ok, all the variants for \"{string1}\":");
                char[] chararray;
                chararray = string1.ToCharArray(0, string1.Length);
                char temp;
                
                int factorial = 1;   // значение факториала

                for (int i = 2; i <= string1.Length; i++) // цикл начинаем с 2, т.к. нет смысла начинать с 1
                {
                    factorial = factorial * i;
                }
                int counter = 0;
                string string2;
                do
                {
                    temp = chararray[0];
                    chararray[0] = chararray[string1.Length - 1];
                    chararray[string1.Length - 1] = temp;
                    string2 = new string (chararray);
                    Console.WriteLine(string2);
                    counter++;

                   temp = chararray[0+1];
                    chararray[0 + 1] = chararray[string1.Length - 1];
                    chararray[string1.Length - 1] = temp;
                    string2 = new string(chararray);
                    Console.WriteLine(string2);
                    counter++;
                }
                while (counter < factorial);
            }
        }

        static void task5()
        {
            Console.WriteLine("\n/////////////////////////////////////////////////// ---- TASK #5");
            int[] array = new int[30];
            for (int i = 0; i < 30; i++)
            {
                array[i] = i + 1;
                Console.Write($"({array[i]}) ");
            }
        }
        static void task6()
        {
            Console.WriteLine("\n/////////////////////////////////////////////////// ---- TASK #6");
            byte m = 10;
            byte n = 10;
            int[,] array = new int[m,n];
            Random random = new Random();
            Console.WriteLine("your unsorted array:");
            for (int i = 0; i < m; i++)
            { 
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = random.Next(0,101);
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
            for (int k = 0; k < n; k++) // shell sort (maybe idk)
            {
                int j;
                int step = array.Length / 2;
                while (step > 0)
                {
                    for (int i = 0; i < (n - step); i++)
                    {
                        j = i;
                        while ((j >= 0) && (array[k, j] > array[k, j + step]))
                        {
                            int temp = array[k, j];
                            array[k, j] = array[k, j + step];
                            array[k, j + step] = temp;
                            j -= step;
                        }
                    }
                    step = step / 2;
                }
                Console.WriteLine();
                for (int y = 0; y < m; y++)
                {
                     Console.Write(array[k, y] + " ");
                }

            }
        }
    }
}
