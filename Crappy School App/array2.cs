using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crappy_School_App
{
    class array2:IBase
    {
        string _name = "sum avg 5";
        public string Name { get { return _name; } }
        public void Begin(string[] args)
        {
            int[] array = new int[5];

            for ( int i = 0; i < 5; i++)
            {
                Console.Write("Enter number : ");
                array[i] = int.Parse(Console.ReadLine());
            }

            int total = 0, avg = array[0];
            foreach(int x in array)
            {
                total = total + x;
                avg = (avg + x) / 2;
            }

            Console.WriteLine("Sum = {0}, Avg = {1}", total, avg);

        }
    }
}
