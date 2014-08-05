using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public static class Singleton
    {
        private static Singleton instance;
        private Singleton()
        {
            
        }

        public static Singleton CreateInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }
        
        public static void DoSomething()
        {
   
        }
    }
}
