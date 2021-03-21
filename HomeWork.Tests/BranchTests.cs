using NUnit.Framework;

namespace HomeWork.Tests
{
    public class BranchTests
    {
        [TestCase(2, 1, 3)]
        [TestCase(2, 2, 4)]
        [TestCase(2, 4, -2)]
        public void CalculateTwoPointsTest(int a, int b, int expected)
        {
            int actual = Branch.CalculateTwoPoints(a, b);

            Assert.AreEqual(expected, actual);
        }

        public void PrintQuartersByTwoPointsTest()
        {

        }


    }
}
