using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode2;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsPasswordValidTest()
        {
            var actualTrue = Program.IsPasswordValid("1-3 g: gbcgweg");
            var actualFalse = Program.IsPasswordValid("4-7 p: ppbpgapdstuff");

            Assert.IsTrue(actualTrue);
            Assert.IsFalse(actualFalse);
            Assert.ThrowsException<FormatException>(() => Program.IsPasswordValid("lmao Yeeeeet"));
        }
    }
}
