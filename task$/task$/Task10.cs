using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_
{
    class Task10
    {
        protected int x;
        protected int y;

    }
    class DerivedPoint : Task10
    {
        public void Task10()
        {
            Console.WriteLine("\n/////////////////////////////////////////////////// ---- TASK #10");
            var dpoint = new DerivedPoint();

            // Direct access to protected members.
            // хз чё это но в документации микрософт это было
            dpoint.x = 10;
            dpoint.y = 15;
            Console.WriteLine($"x = {dpoint.x}, y = {dpoint.y}");
        }
    }
}

