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

        }
    }
}