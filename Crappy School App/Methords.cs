using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crappy_School_App
{
    class Methords : IBase
    {
        string _name = "Methords";
        public string Name { get { return _name; } }
        public void Begin(string[] args)
        {
            Console.Write("Enter text to count spaces in");
            Console.WriteLine("The Number Of spaces is {0}", NumSpace(Console.ReadLine()));
            Console.WriteLine("");
            Console.Write("Enter numbers separated by space to add together");
            string[] data = Console.ReadLine().Split(' ');
            int[] stuff = new int[data.Length];
            int i = 0;
            foreach (string x in data)
            {
                stuff[i] = int.Parse(x);
                i++;
            }
            Console.WriteLine("The sum Of elemets is {0}", SunofArray(stuff));
            Console.WriteLine("");
            Console.Write("Enter a number");
            int b = int.Parse(Console.ReadLine());

            Console.Write("to the power of");
            uint e = uint.Parse(Console.ReadLine());

            Console.WriteLine("Resalut = {0}", power(b, e));


        }
        /// <summary>
        /// Write a program in C# Sharp to create a function to input a string and count number of spaces are in the string.
        /// </summary>
        /// <param name="input">String to count spaces in</param>
        /// <returns>number of spaces in the provided string</returns>
        int NumSpace(string input)
        {
            int i = 0;
            foreach (char x in input)
                if (x == ' ')
                    i++;
            return i;
        }
        /// <summary>
        /// Write a program in C# Sharp to calculate the sum of elements in an array.
        /// </summary>
        /// <param name="numbers">Array of ints to sum</param>
        /// <returns>the sum of all elements in array</returns>
        int SunofArray(int[] numbers)
        {
            int total = 0;
            foreach (int x in numbers)
                total += x;
            return total;
        }
        /// <summary>
        /// Write a program in C# Sharp to create a function to calculate the result of raising an integer number to another.e.g. 32 = 9
        /// </summary>
        /// <param name="number">the base</param>
        /// <param name="exponent">to the power of</param>
        /// <returns>=</returns>
        int power(int number, uint exponent)
        {
            int total = number;
            for (uint i = 1; i < exponent; i++)
            {
                total = total * number;
            }
            if (exponent == 0)
                total = 1;
            return total;
        }
    }
}
