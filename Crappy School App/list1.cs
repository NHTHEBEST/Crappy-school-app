using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crappy_School_App
{
    class list1 : IBase
    {
        string _name = "Lists 1";
        public string Name { get { return _name; } }
        public void Begin(string[] args)
        {
            Console.WriteLine("Enter numbers separted bt spaces end by pressing enter");
            string[] nums = Console.ReadLine().Split(' ');

            List<int> ints = new List<int>();
            foreach (string x in nums)
                try
                { ints.Add(int.Parse(x)); }
                catch { }

            int sum = 0;
            double avg = ints[0];

            foreach (int x in ints)
            {
                avg = (x+avg) / 2;
                sum += x;
            }

            Console.WriteLine("Sum = {1}, Avrage = {0}", avg,sum);
        }
    }
}
