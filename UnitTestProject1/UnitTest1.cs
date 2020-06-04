using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ConsoleApp523.WorkingDay dd = new ConsoleApp523.WorkingDay();
            List<ConsoleApp523.WorkingDay> l = new List<ConsoleApp523.WorkingDay>();
            for (int i = 0; i < 10; i++)
            {
                ConsoleApp523.WorkingDay di = new ConsoleApp523.WorkingDay();
                di.Name = "Name" + i;
                di.Address = "Ad" + i;
                di.Date = DateTime.ParseExact("21.03.202" + i, "dd.MM.yyyy", null);
                di.BookInCount = i;
                di.BookOutCount = 10 - i;
                l.Add(di);
            }
            int res = dd.PairReturned(l);
            Assert.AreEqual(res, 0);

        }
    }
}
