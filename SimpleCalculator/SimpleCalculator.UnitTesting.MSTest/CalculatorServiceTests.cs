namespace SimpleCalculator.UnitTesting.MSTest
{
    [TestClass]
    public class CalculatorServiceTests
    {
        private readonly CalculatorService sut = new CalculatorService();

        [TestMethod]
        public void Add_WithPositiveNumbers_ReturnsCorrectSum()
        {
            var result = sut.Add(1, 1);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Add_WithNegativeNumbers_ReturnsCorrectSum()
        {
            var result = sut.Add(-1, -1);
            Assert.AreEqual(-2, result);
        }

        [TestMethod]
        public void Subtract_WithPositiveNumbers_ReturnsCorrectDifference()
        {
            var result = sut.Subtract(1, 1);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Subtract_WithNegativeNumbers_ReturnsCorrectDifference()
        {
            var result = sut.Subtract(-1, -1);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Multiply_WithPositiveNumbers_ReturnsSameCorrectPositiveProduct()
        {
            var result = sut.Multiply(1, 2);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Multiply_WithPositiveNumbersReversed_ReturnsSameCorrectPositiveProduct()
        {
            var result = sut.Multiply(2, 1);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Multiply_WithNegativeNumbers_ReturnsSameCorrectPositiveProduct()
        {

        }

    }
}