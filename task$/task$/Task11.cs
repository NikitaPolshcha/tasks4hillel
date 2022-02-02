using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_
{
    class Task11
    {
      public class Data
        {
            public string _name;
            public int _id;
            public Data(string Name, int id)
            {
                _name = Name;
                _id = id;
            }
        }
        public void Task11Method()
        {
            Console.WriteLine("\n/////////////////////////////////////////////////// ---- TASK #11");
            List<Data> SomeData = new List<Data>();
            Random random = new Random();
            Console.WriteLine("Input how many elements you would like to add to the list:");
            string quantity;
            quantity = Console.ReadLine();
            int number;
            bool success = int.TryParse(quantity, out number);
            if (success)
            {
                for (int i = 0; i < Convert.ToInt32(quantity); i++)
                {
                    Console.WriteLine($"Input the name of the element {i}:");
                    SomeData.Add(new Data(Console.ReadLine(), random.Next(0, 10)));
                }
            }
            
            foreach (var Data in SomeData)
            {
                Console.WriteLine($"name: {Data._name} id: {Data._id}");
            }
            // ниже должен быть поиск повторяющихся элементов но я хз как Data._id перебирать именно, а не Data полностью(((
            /*
            int temp;
            int counter;
            foreach (var Data in SomeData)
            {
                temp = Data._id;
                foreach (var Data._id in SomeData)
                {

                }
            }
            */

        }
        


        }
}
