using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using HelloAzure;

namespace TestHello
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CzyZwracaDobryNapis()
        {
            string napis = "Hello World!";
            Assert.AreEqual(Program.ZwrocNapis(napis), napis);     
        }
    }
}
