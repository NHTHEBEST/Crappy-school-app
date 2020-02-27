using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crappy_School_App
{
    class array3 : IBase
    {
        string _name = "student+age";
        public string Name { get { return _name; } }
        public void Begin(string[] args)
        {
            string[] names  = {"Noam", "Josh", "Conner", "Zac" };
            int[] ages      = {16, 16, 16, 16 };

            for (int a = 0, n = 0; a < ages.Length && n < names.Length; a++, n++)
            {
                Console.WriteLine("Name : {0}, Age : {1}", names[n], ages[a]);
            }
        }
    }
}
