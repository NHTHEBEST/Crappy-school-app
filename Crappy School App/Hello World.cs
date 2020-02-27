using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crappy_School_App
{
    class Hello_World : IBase
    {
        string _name = "Hello World";
        public string Name { get { return _name; } }
        public void Begin(string[] args)
        {
            Console.WriteLine("Hellow World");
        }
    }
}
