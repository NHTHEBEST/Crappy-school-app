using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crappy_School_App
{
    class Homework : IBase
    {
        string _name = "HomeWork";
        public string Name { get { return _name; } }
        enum Shape
        {
            Square = 0,
            Rectangle = 1,
            Circle = 2
        }
        public void Begin(string[] args)
        {
            Shape shape = (Shape)getNumber("Choese a shape\nSquare [0], Rectangle [1], Circle [2] : ", 0, 2);
            Action[] shapes = { Square, Reqtangle, Circle};
            shapes[(int)shape]();
            Console.WriteLine("Program Done Press R to restart Any Other to continue ...");
            if (Console.ReadKey().Key == ConsoleKey.R)
            {
                Begin(args);
            }
        }


        void Square()
        {
            int width = getNumber("Width = ", 0, 150);
            Console.WriteLine("Area = {0}, Perimeter = {1}", width*width, width*4);
        }

        void Reqtangle()
        {
            int width = getNumber("Width = ", 0, 150);
            int Hight = getNumber("Hight = ", 0, 150);
            Console.WriteLine("Area = {0}, Perimeter = {1}", width * Hight, Hight * 2 +width * 2);
        }

        void Circle()
        {
            int Raidus = getNumber("Raidus = ", 0, 150);
            Console.WriteLine("Area = {1}, Circumference = {0}", 2*Math.PI*Raidus, Math.PI * Raidus*Raidus);
        }

        int getNumber(string prompt, int lowest, int highest)
        {
            Console.Write(prompt);
            try
            {
                int x = int.Parse(Console.ReadLine());
                if (x <= highest && x >= lowest)
                    return x;
            }
            catch { }
            Console.WriteLine("Enter a valid number!");
            return getNumber(prompt, lowest, highest);
        }
    }
}
