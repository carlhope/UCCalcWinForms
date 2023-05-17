using Microsoft.VisualStudio.TestTools.UnitTesting;
using UCCalcWinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCCalcWinForms.Tests
{
    [TestClass()]
    public class Class1Tests
    {
        [TestMethod()]
        public void CalcUCTest()
        {
            Class1 dave = new Class1();
            decimal result = dave.CalcUC(1000M, 400M, true, true, false, true, false);
            Assert.AreEqual(365.05M, result);
        }

        [TestMethod()]
        public void CalcUCTests()
        {
            Class1 dave = new Class1();
            decimal result = dave.CalcUC(1000M, 400M, true, true, false, true, false);
            Assert.AreEqual(565.05M, result);
        }
    }
}