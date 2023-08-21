using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{


    public class MySingleton
    {
        private static MySingleton _instance = null;
        private static readonly object padlock = new object();
        private static int Counter = 0;

        private MySingleton()
        {
            Counter++;
            Console.WriteLine("Counter Vlue" + Counter.ToString());

        }

        public static MySingleton GetInstance()
        {

            lock (padlock)
            {
                if (_instance == null)
                {
                    _instance = new MySingleton();
                }

                return _instance;
            }
        }

    }
}