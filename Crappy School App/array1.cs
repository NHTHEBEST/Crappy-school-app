using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crappy_School_App
{
    class array1:IBase
    {
        string _name = "20 array";
        public string Name { get { return _name; } }
        public void Begin(string[] args)
        {
            /*
             * Write a program, which creates an array of 20 elements of type integer and initialises
             * each of the elements with a value equals to the index of the element multiplied by 5.
             * Print the elements to the console.
             */
            int[] array = new int[20];
            for (int i = 0; i<20; i++)
            {
                array[i] = i * 5;
            }

            foreach (int x in array)
            {
                Console.WriteLine(x);
            }
        }
    }
}
