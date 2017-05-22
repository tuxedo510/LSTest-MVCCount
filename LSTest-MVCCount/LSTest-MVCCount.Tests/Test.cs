using LSTest_MVCCount.CountService;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSTest_MVCCount.Tests
{
    [TestClass]
    public class Test
    {

        [TestMethod]
        public void IncreaseCount_ByOne()
        {
            var context = new TestCountContext();
            var service = new CounterService(context);
            var count = service.IncreaseCount();
            Assert.AreEqual(count, 1);
            count = service.IncreaseCount();
            Assert.AreEqual(count, 2);
        }

        [TestMethod]
        public void IncreaseCount_TestReset()
        {
            var context = new TestCountContext();
            var service = new CounterService(context);
            var reset = service.ResetCount();
            Assert.AreEqual(reset, 0);
        }

        [TestMethod]
        public void IncreaseCount_NotSurpassTen()
        {
            var context = new TestCountContext();
            var service = new CounterService(context);
            var count = service.IncreaseCount();
            Assert.AreEqual(count, 1);
            count = service.IncreaseCount();
            Assert.AreEqual(count, 2);
            count = service.IncreaseCount();
            Assert.AreEqual(count, 3);
            count = service.IncreaseCount();
            Assert.AreEqual(count, 4);
            count = service.IncreaseCount();
            Assert.AreEqual(count, 5);
            count = service.IncreaseCount();
            Assert.AreEqual(count, 6);
            count = service.IncreaseCount();
            Assert.AreEqual(count, 7);
            count = service.IncreaseCount();
            Assert.AreEqual(count, 8);
            count = service.IncreaseCount();
            Assert.AreEqual(count, 9);
            count = service.IncreaseCount();
            Assert.AreEqual(count, 10);
            count = service.IncreaseCount();
            Assert.AreEqual(count, 10);
        }
    }
}
