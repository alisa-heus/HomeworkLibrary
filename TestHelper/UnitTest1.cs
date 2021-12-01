using NUnit.Framework;
using HomeworkLibrary;

namespace TestHelper
{
    public class Tests
    {
        [Test]
        public void CalculateDivision_IfBIsNotZero_ShouldCalculateDivision()
        {
            double A = 8;
            double B = 2;
            (double, double) expected = (4, 0);
            (double, double) actualResult = Helper.CalculateDivision(A, B);
            Assert.AreEqual(expected, actualResult);
        }

        [TestCase(2, 3, 8)]
        [TestCase(3, 0, 1)]
        
        public void AToPowerB_IfBIsNotNegative_ShouldCalculatePower(int A, int B, int expected)
        {
            int actual = Helper.AtoPowerB(A, B);
            Assert.AreEqual(expected, actual);
        }
    }
}