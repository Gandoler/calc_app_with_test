using NUnit.Framework;

using calc_app;
using Moq;

namespace calc_app
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        [TearDown]
       

        [Test]
        public void TestPlusOperation()
        {
            // Arrange
            _calculator.Put_A(5);

            // Act
            _calculator.plus(3);

            // Assert
            Assert.AreEqual(8, _calculator.Get_A());
        }

        [Test]
        public void TestMinusOperation()
        {
            // Arrange
            _calculator.Put_A(10);

            // Act
            _calculator.minus(4);

            // Assert
            Assert.AreEqual(6, _calculator.Get_A());
        }

        [Test]
        public void TestMultipleOperation()
        {
            // Arrange
            _calculator.Put_A(4);

            // Act
            _calculator.multiple(3);

            // Assert
            Assert.AreEqual(12, _calculator.Get_A());
        }

        [Test]
        public void TestDivideOperation()
        {
            // Arrange
            _calculator.Put_A(10);

            // Act
            _calculator.divide(2);

            // Assert
            Assert.AreEqual(5, _calculator.Get_A());
        }

        [Test]
        public void TestDivideByZero_ThrowsException()
        {
            // Arrange
            _calculator.Put_A(10);

            // Act & Assert
            Assert.Throws<DivideByZeroException>(() => _calculator.divide(0));
        }


        
    }

   
    
}
