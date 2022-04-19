using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            TaskList taskList = new TaskList("Новый список задач");
            Assert.AreEqual("Новый список задач", taskList.GetName());
        }
    }
}
