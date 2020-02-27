using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crappy_School_App
{
    class _1_N: IBase
    {
        string _name = "0-N not 3,7";
        public string Name { get { return _name; } }
        /// <summary>
        /// get inpute from 0 to n
        /// </summary>
        /// <param name="args">command line args</param>
        public void Begin(string[] args)
        {
            Console.Write("Enetr a Number : ");
            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i <= N; i++)
                if((i%7 != 0) || (i%3!=0))
                    Console.WriteLine(i);
        }
    }
}
