using NUnit.Framework;

namespace HomeWork.Tests
{
    public class CircleTests
    {
        [TestCase(1, 3, 1)]
        [TestCase(2, 4, 16)]
        [TestCase(5, 0, 1)]
        public void PrintExtentInputNumberTest(int a, int b, int expected)
        {
            int actual = Сircle.PrintExtentInputNumber(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase()]
        public void PrintNumberDividedByInputTest(int a, int expected)
        {
            //int actual = ;

            //Assert.AreEqual(expected, actual);
        }

        [TestCase()]
        public void PrintGreatestDivisorTest(int a, int expected)
        {
            //int actual = 

            //Assert.AreEqual(expected, actual);
        }




    }
}
