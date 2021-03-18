using NUnit.Framework;

namespace HomeWork.Tests
{
    public class Tests
    {

        [TestCase(1,2,9)]
        [TestCase(0,1,1)]
        [TestCase(5,6,61)]
        public void printSolvingTest(int A1, int B1, int expected)
        {
            int actual = (5 * A1 + B1 * B1) / (B1 - A1);

            Assert.AreEqual(expected, actual);
        }
    }
}