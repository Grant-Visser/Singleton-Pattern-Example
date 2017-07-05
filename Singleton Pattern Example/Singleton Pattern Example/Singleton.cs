using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Pattern_Example
{
    //Good lord. This is not thread safe.
    class Singleton
    {
        private static Singleton uniqueSingleton;

        private Singleton()
        {
        }

        public static Singleton GetInstance()
        {
            if (uniqueSingleton == null)
            {
                uniqueSingleton= new Singleton();
            }
            return uniqueSingleton;
        }

        public string GetDescription()
        {
            return "I'm a singleton";
        }
    }
}
