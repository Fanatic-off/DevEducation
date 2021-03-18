using NUnit.Framework;

namespace HomeWork.Tests
{
    public class VariableTest
    {

        [TestCase(1, 2, 9)]
        [TestCase(0, 1, 1)]
        [TestCase(5, 6, 61)]
        public void PrintSolvingTest(int a, int b, int expected)
        {
            int actual = (5 * a + b * b) / (b - a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, 1, true)]
        [TestCase(4, 10, true)]
        [TestCase(-5, 20, true)]
        public void ChangeVariableTest(int a, int b, bool expected)
        {
            bool actual = false;

            int tmp1 = a;
            int tmp2 = b;
            
            int tmp = a;
            a = b;
            b = tmp;

            if ((tmp1 == b) && (tmp2 == a))
            {
                actual = true;
            }

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 2, 3, 1)]
        [TestCase(2, 4, 7, 1)]
        [TestCase(3, 22, 55, 11)]
        public void PrintSolvingLinearEquationTest(int a, int b, int c, int expected)
        {
            int actual = (c - b) / a;

            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, 3, 1, 2, 1, 1, true)]
        [TestCase(5, 5, 1, 2, 0.75, 1.25, true)]
        [TestCase(7, 2, 3, 1, 0.25, 0.25, true)]
        public void PrintEquationLineOverTwoPointsTest(double x1, double y1, double x2, double y2, double A, double B, bool expected)
        {
            bool actual = false;

            if (((y1 - y2) / (x1 - x2) == A) && ((y2 - ((y1 - y2) / (x1 - x2)) * x2) == B))
            {
                actual = true;
            }

            Assert.AreEqual(expected, actual);
        }
    }
}