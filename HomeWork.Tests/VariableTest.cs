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
            int actual = Variable.PrintSolving(ref a, ref b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, 1)]
        [TestCase(4, 10)]
        [TestCase(-5, 20)]
        public void ChangeVariableTest(ref int a, ref int b)
        {
            Variable.ChangeVariable(ref a, ref b);

            int actualA = a;
            int actualB = b;

            int expectedA = b;
            int expectedB = a;

            Assert.AreEqual(expectedA, actualB);
            Assert.AreEqual(expectedB, actualB);
        }

        [TestCase(10, 2, 5, 0)]
        public void PrintRemaiderOfDivision(int a, int b, int expectedDivision, int expectedRemains)
        {
            int actualDivision = a / b;
            int actualRemains = a % b;

            Assert.AreEqual(expectedDivision, actualDivision);
            Assert.AreEqual(expectedRemains, actualRemains);

        }

        [TestCase(1, 2, 3, 1)]
        [TestCase(2, 4, 7, 1)]
        [TestCase(3, 22, 55, 11)]
        public void PrintSolvingLinearEquationTest(int a, int b, int c, int expected)
        {
            int actual = Variable.PrintSolvingLinearEquation(a, b, c);

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