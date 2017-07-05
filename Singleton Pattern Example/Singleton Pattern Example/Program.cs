using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Pattern_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton testSingleton = Singleton.GetInstance();
            Console.Out.WriteLine(testSingleton.GetDescription());
            Console.Out.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
