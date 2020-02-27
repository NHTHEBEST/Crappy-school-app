using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crappy_School_App
{
    class L_B: IBase
    {
        string _name = "Small to Big";
        public string Name { get { return _name; } }
        public void Begin(string[] args)
        {
            Console.Write("How manny numbers : ");
            int ints = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            for (int i = 0; i<ints; i++)
            {
                Console.Write("Number {0} = ",i+1);
                list.Add(int.Parse(Console.ReadLine()));
            }
            list.Sort();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
