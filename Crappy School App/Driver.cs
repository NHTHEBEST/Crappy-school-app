using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crappy_School_App
{
    class Driver: IBase
    {
        string _name = "Driving Age";
        public string Name { get { return _name; } }
        public void Begin(string[] args)
        {
            Console.Write("Enter Age: ");
            int age = int.Parse(Console.ReadLine());

            if (age > 18)
            {
                Console.WriteLine("You can drive");
            }
            else
            {
                Console.WriteLine("You can not drive");
            }
        }
    }
}
