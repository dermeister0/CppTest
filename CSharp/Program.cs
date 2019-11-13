using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new CppLibrary.Class1();
            Console.WriteLine(c.GetData());
        }
    }
}
