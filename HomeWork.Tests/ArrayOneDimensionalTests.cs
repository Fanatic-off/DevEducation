using NUnit.Framework;

namespace HomeWork.Tests
{
    public class ArrayOneDimensionalTests
    {
        [TestCase()]
        public void FindMinElementTest(int[] a, int expected)
        {
            int actual = ArrayOneDimensional.FindMinElement(a);

            Assert.AreEqual(expected, actual);
        }
    }
}
