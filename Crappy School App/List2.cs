using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crappy_School_App
{
    class List2 : IBase
    {
        string _name = "rm -";
        public string Name { get { return _name; } }
        public void Begin(string[] args)
        {
            Console.WriteLine("Enter numbers separted bt spaces end by pressing enter (p.s. enetr som negitaves)");
            string[] nums = Console.ReadLine().Split(' ');

            List<int> ints = new List<int>();
            foreach (string x in nums)
                try
                {
                    int tmp = int.Parse(x);
                    if(tmp>0)
                    ints.Add(tmp); }
                catch { }

            foreach ( int x in ints)
            {
                Console.WriteLine(x);
            }
            
        }
    }
}
