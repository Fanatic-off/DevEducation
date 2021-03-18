using NUnit.Framework;

namespace HomeWork.Tests
{
    public class Tests
    {

        [TestCase(1,2,9)]
        [TestCase(0,1,1)]
        [TestCase(5,6,61)]
        public void PrintSolvingTest(int a, int b, int expected)
        {
            int actual = (5 * a + b * b) / (b - a);

            Assert.AreEqual(expected, actual);
        }

        public void ChangeVariableTest(int a, int b, int expected)
        {
            
            
            Assert.AreEqual(expected, actual);
        }
    }
}