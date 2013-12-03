using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a console application. How fancy!");
            // Comments are very easy to use

            // C# has neat aliases for its built-in variable types
            // int is shorthand for System.Int32
            bool yes = true;
            if (yes)
            {
                Console.WriteLine(yes + ", indubitably.");
            }

            for (int i = 0; i < 5; i ++)
            {
                Console.WriteLine("Loops!");
            }
        }
    }
}
