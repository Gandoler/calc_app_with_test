
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        private Calculator calculator;

        private Mock<ICalculatorView> mockView;

        // Метод, который инициализирует тестируемый объект перед каждым тестом
        public UnitTest1()
        {
            calculator = new Calculator();
            mockView = new Mock<ICalculatorView>();

        }

        [Fact]
        public void Plus_ShouldAddCorrectly()
        {
            // Arrange
            calculator.Put_A(5);

            // Act
            calculator.plus(3);

            // Assert
            Assert.Equal(8, calculator.Get_A());
        }

        [Fact]
        public void Minus_ShouldSubtractCorrectly()
        {
            // Arrange
            calculator.Put_A(5);

            // Act
            calculator.minus(3);

            // Assert
            Assert.Equal(2, calculator.Get_A());
        }

        [Fact]
        public void Multiple_ShouldMultiplyCorrectly()
        {
            // Arrange
            calculator.Put_A(5);

            // Act
            calculator.multiple(2);

            // Assert
            Assert.Equal(10, calculator.Get_A());
        }

        [Fact]
        public void Divide_ShouldDivideCorrectly()
        {
            // Arrange
            calculator.Put_A(10);

            // Act
            calculator.divide(2);

            // Assert
            Assert.Equal(5, calculator.Get_A());
        }

        [Fact]
        public void Divide_ShouldThrowExceptionOnDivideByZero()
        {
            // Arrange
            calculator.Put_A(10);

            // Act & Assert
            Assert.Throws<DivideByZeroException>(() => calculator.divide(0));
        }

        [Fact]
        public void Clear_A_ShouldResetValue()
        {
            // Arrange
            calculator.Put_A(10);

            // Act
            calculator.Clear_A();

            // Assert
            Assert.Equal(0, calculator.Get_A());
        }

        [Fact]
        public void Clear_B_ShouldResetValue()
        {
            // Arrange
            calculator.Put_B(10);

            // Act
            calculator.Clear_B();

            // Assert
            Assert.Equal(0, calculator.Get_B());
        }




        [Fact]
        public void Plus_ShouldUpdateDisplayCorrectly()
        {
            // Arrange
            mockView.Setup(v => v.DisplayText).Returns("5");

            // Act
            calculator.Put_A(5);
            calculator.plus(3);

            // Assert
            Assert.Equal(8, calculator.Get_A());

            // Проверка, что был вызов метода отображения результата
            mockView.VerifySet(v => v.DisplayText = "8", Times.Once);
        }

        [Fact]
        public void Divide_ShouldThrowExceptionOnDivideByZeroAndShowError()
        {
            // Arrange
            mockView.Setup(v => v.DisplayText).Returns("10");

            // Act
            calculator.Put_A(10);
            var exception = Assert.Throws<DivideByZeroException>(() => calculator.divide(0));

            // Assert
            Assert.Equal("Attempted to divide by zero.", exception.Message);

            // Проверка, что ошибка отображена
            mockView.Verify(v => v.ShowError(It.IsAny<string>()), Times.Once);
        }
    }
}