using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorld;

namespace HelloWorldTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCreateMessage()
        {
            Assert.AreEqual("Hello World!", Program.CreateMessage("Hello World!"));
        }
    }
}
