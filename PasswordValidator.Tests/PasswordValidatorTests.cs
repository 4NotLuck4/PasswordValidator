using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PasswordValidator.Tests
{
    [TestClass]
    public class PasswordValidatorTests
    {
        [TestMethod]
        public void ValidatePassword_ValidPassword_ReturnsTrue()
        {
            // Arrange
            string validPassword = "Password123";

            // Act
            bool result = PasswordValidator.ValidatePassword(validPassword);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ValidatePassword_TooShort_ReturnsFalse()
        {
            // Arrange
            string shortPassword = "Pass1";

            // Act
            bool result = PasswordValidator.ValidatePassword(shortPassword);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ValidatePassword_NoDigits_ReturnsFalse()
        {
            // Arrange
            string noDigitPassword = "Password";

            // Act
            bool result = PasswordValidator.ValidatePassword(noDigitPassword);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ValidatePassword_NoLetters_ReturnsFalse()
        {
            // Arrange
            string noLetterPassword = "12345678";

            // Act
            bool result = PasswordValidator.ValidatePassword(noLetterPassword);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ValidatePassword_EmptyString_ReturnsFalse()
        {
            // Arrange
            string emptyPassword = "";

            // Act
            bool result = PasswordValidator.ValidatePassword(emptyPassword);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ValidatePassword_Null_ReturnsFalse()
        {
            // Arrange
            string nullPassword = null;

            // Act
            bool result = PasswordValidator.ValidatePassword(nullPassword);

            // Assert
            Assert.IsFalse(result);
        }
    }
}