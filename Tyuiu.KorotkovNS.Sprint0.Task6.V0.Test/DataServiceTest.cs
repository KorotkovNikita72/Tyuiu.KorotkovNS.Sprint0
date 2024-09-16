using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KorotkovNS.Sprint0.Task6.V0.Lib;

namespace Tyuiu.KorotkovNS.Sprint0.Task6.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedAdditionArrayVaid()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.AdditionArray(numbers);
            Assert.AreEqual(15, res);
        }
        [TestMethod]
        public void CheckedSubtractionArrayVaid()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.SubtractionArray(numbers);
            Assert.AreEqual(-15, res);
        }
        [TestMethod]
        public void CheckedMultiplicationArrayVaid()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.MultiplicationArray(numbers);
            Assert.AreEqual(120, res);
        }
    }
}
