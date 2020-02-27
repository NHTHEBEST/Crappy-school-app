using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crappy_School_App
{
    class NumberSort : IBase
    {
        string _name = "Number Sort";
        public string Name { get { return _name; } }
        public void Begin(string[] args)
        {
            List<int> list = new List<int>();
            Console.Write("Enter A Number: ");
            list.Add(int.Parse(Console.ReadLine()));

            Console.Write("Enter Another Number: ");
            list.Add(int.Parse(Console.ReadLine()));

            Console.Write("and Another Number: ");
            list.Add(int.Parse(Console.ReadLine()));

            list.Sort();
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }

        }

    }
}
