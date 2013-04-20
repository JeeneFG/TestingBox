using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box(1, 2, 3);
            Console.WriteLine(box);
            Console.ReadKey();
        }
    }
}
