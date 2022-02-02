using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_
{
    class Task8
    {
        public void Dates()
        {
            Console.WriteLine("\n/////////////////////////////////////////////////// ---- TASK #9");
            string dateFromUser;
            Console.WriteLine("input the date (input format is dd.mm.yyyy hh:mm)");
            dateFromUser = Console.ReadLine();

            CultureInfo culture = CultureInfo.CreateSpecificCulture("en-US");
            DateTime dateValue;
            try
            {
                dateValue = DateTime.Parse(dateFromUser, culture);
                Console.WriteLine("   Converted '{0}' to {1}.",
                                  dateFromUser, dateValue.ToString("f", culture));
            }
            catch (FormatException)
            {
                Console.WriteLine("   Unable to convert '{0}' for culture {1}.",
                                  dateFromUser, culture.Name);
            }
        }
        }
}
