using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Pattern_Example
{
    //Threadsafe
    class Singleton
    {
        private static Singleton uniqueSingleton;
        private static object syncRoot = new object();

        private Singleton()
        {
        }

        public static Singleton GetInstance()
        {
            if (uniqueSingleton == null)
            {
                lock (syncRoot)
                {
                    if (uniqueSingleton == null)
                    {
                        uniqueSingleton = new Singleton();
                    }
                }
            }
            return uniqueSingleton;
        }

        public string GetDescription()
        {
            return "I'm a threadsafe singleton";
        }
    }
}
