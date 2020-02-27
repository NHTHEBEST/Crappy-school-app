using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crappy_School_App
{
    interface IBase
    {
        void Begin(string[] args);

        string Name { get;  }
        
    }

    partial class Program
    {
        
        static void Main(string[] args)

        {
        start:
            Console.Clear();
            Console.WriteLine("ID, Name");
            for (int i = 0; i < progs.Length; i++)
            {
                Console.WriteLine("{0}, {1}", i, progs[i].Name);
            }
            Console.WriteLine();
            try
            {
                Console.Write("Enter Program ID: ");
                int id = int.Parse(Console.ReadLine());
                progs[id].Begin(args);
            } catch
            {
                Console.WriteLine("Invaled ID");
                goto start;
            }
            

            Console.WriteLine("Program Done Press R to restart Any Other to exit ...");
            if (Console.ReadKey().Key == ConsoleKey.R)
            {
                goto start;
            }
        }
    }
}
