using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairDresser
{
    class Program
    {
        static void Main(string[] args)
        {
            Tools tools = new Tools();
            new HairDresser(0, 5, 1, tools).Start();
            new HairDresser(1, 0, 2, tools).Start();
            new HairDresser(2, 1, 3, tools).Start();
            new HairDresser(3, 2, 4, tools).Start();
            new HairDresser(4, 3, 5, tools).Start();
            new HairDresser(5, 4, 0, tools).Start();


            Console.ReadKey();
        }
    }
}
