using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventofCode5;

namespace AdventOfCodeTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetRowNumberTest()
        {
            var expected = 70;
            var actual = Program.GetRowNumber("BFFFBBFRRR");

            var expected2 = 14;
            var actual2 = Program.GetRowNumber("FFFBBBFRRR");

            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected2, actual2);
        }

        [TestMethod]
        public void GetColumnNumberTest()
        {
            var expected = 7;
            var actual = Program.GetColumnNumber("BFFFBBFRRR");

            var expected2 = 4;
            var actual2 = Program.GetColumnNumber("BBFFBBFRLL");

            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected2, actual2);
        }
    }
}
