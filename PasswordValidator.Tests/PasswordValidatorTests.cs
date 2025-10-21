using Xunit;
using PasswordValidator;
using Assert = Xunit.Assert;

namespace PasswordValidator.Tests
{
    public class PasswordValidatorTests
    {
        [Fact]
        public void ValidatePassword_ValidPassword_ReturnsTrue()
        {
            // Arrange
            string validPassword = "Password123";

            // Act
            bool result = PasswordValidator.ValidatePassword(validPassword);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void ValidatePassword_TooShort_ReturnsFalse()
        {
            // Arrange
            string shortPassword = "Pass1";

            // Act
            bool result = PasswordValidator.ValidatePassword(shortPassword);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void ValidatePassword_NoDigits_ReturnsFalse()
        {
            // Arrange
            string noDigitPassword = "Password";

            // Act
            bool result = PasswordValidator.ValidatePassword(noDigitPassword);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void ValidatePassword_NoLetters_ReturnsFalse()
        {
            // Arrange
            string noLetterPassword = "12345678";

            // Act
            bool result = PasswordValidator.ValidatePassword(noLetterPassword);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void ValidatePassword_EmptyString_ReturnsFalse()
        {
            // Arrange
            string emptyPassword = "";

            // Act
            bool result = PasswordValidator.ValidatePassword(emptyPassword);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void ValidatePassword_Null_ReturnsFalse()
        {
            // Arrange
            string nullPassword = null;

            // Act
            bool result = PasswordValidator.ValidatePassword(nullPassword);

            // Assert
            Assert.False(result);
        }

        // “есты с использованием Theory дл€ параметризованного тестировани€
        [Theory]
        [InlineData("Pass1234", true)] // валидный пароль
        [InlineData("short1", false)] // слишком короткий
        [InlineData("NoDigitsHere", false)] // нет цифр
        [InlineData("12345678", false)] // нет букв
        [InlineData("", false)] // пуста€ строка
        public void ValidatePassword_ParameterizedTests(string password, bool expected)
        {
            // Act
            bool result = PasswordValidator.ValidatePassword(password);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}