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
            List<Children> kids = new List<Children>();
            kids.Add(new Children("Luke", new DateTime(2019, 1, 1)));
            kids.Add(new Children("Lola", new DateTime(2020, 1, 1)));
            kids.Add(new Children("Amelia", new DateTime(2022, 1, 1)));
            decimal result = UCCalculation.CalcUC(1000M, 400M, true, true, false, true, kids);
            Assert.AreEqual(1446.18M, result);
        }

        [TestMethod()]
        public void CalcUCTests()
        {
            List<Children> kids = new List<Children>();
            kids.Add(new Children("Josh", new DateTime(2009,1,1)));
            decimal result = UCCalculation.CalcUC(1000M, 400M, true, true, false, true, kids);
            Assert.AreEqual(1222.02M, result);
        }
    }
}