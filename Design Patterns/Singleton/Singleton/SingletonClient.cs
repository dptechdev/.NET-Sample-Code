using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    [TestFixture]
    class SingletonClient
    {
        [Test]
        public void UseSingleton()
        {
            Singleton s1 = Singleton.CreateInstance();
            Singleton s2 = Singleton.CreateInstance();
            Assert.AreSame(s1, s2);
           
        }
    }
}
