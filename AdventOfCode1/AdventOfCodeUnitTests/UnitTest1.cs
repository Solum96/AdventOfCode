using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode1;
using System;
using System.Text;

namespace AdventOfCodeUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Find2020Test()
        {
            var p = new Program();

            var indata = new[] { 2000, 40, 30, 900, 1337, 20, 10, 10 };
            var expected = new[] { 2000, 15, 5 };
            var actual = p.Find2020(indata);

            Assert.AreEqual(expected.Length, actual.Length);
            foreach (var item in expected)
            {
                Assert.AreEqual(item, actual[Array.IndexOf(expected, item)]);
            }
            Assert.AreEqual(actual[0] + actual[1] + actual[2], 2020);
        }

        [TestMethod]
        public void CleanInputDataTest()
        {
            var p = new Program();

            var inputData = new StringBuilder("100 " + Environment.NewLine + "200 " + Environment.NewLine + "300 ").ToString();
            var expected = new[] { 100, 200, 300 };
            var actual = p.CleanInputData(inputData);

            Assert.AreEqual(expected.Length, actual.Length);
            foreach (var item in expected)
            {
                Assert.AreEqual(item, actual[Array.IndexOf(expected, item)]);
            }
        }
    }
}
