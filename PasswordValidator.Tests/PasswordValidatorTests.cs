using Xunit;

namespace PasswordValidator.Tests
{
    public class PasswordValidatorTests
    {
        // 5.2 - Тесты для базовой валидации
        [Fact]
        public void ValidatePassword_ValidPassword_ReturnsTrue()
        {
            var result = PasswordValidator.ValidatePassword("Password123");
            Assert.True(result);
        }

        [Fact]
        public void ValidatePassword_TooShort_ReturnsFalse()
        {
            var result = PasswordValidator.ValidatePassword("Pass1");
            Assert.False(result);
        }

        [Fact]
        public void ValidatePassword_NoDigits_ReturnsFalse()
        {
            var result = PasswordValidator.ValidatePassword("Password");
            Assert.False(result);
        }

        [Fact]
        public void ValidatePassword_NoLetters_ReturnsFalse()
        {
            var result = PasswordValidator.ValidatePassword("12345678");
            Assert.False(result);
        }

        [Theory]
        [InlineData("Pass1234", true)]
        [InlineData("short1", false)]
        [InlineData("NoDigits", false)]
        [InlineData("12345678", false)]
        [InlineData("", false)]
        [InlineData(null, false)]
        public void ValidatePassword_ParameterizedTests(string password, bool expected)
        {
            var result = PasswordValidator.ValidatePassword(password);
            Assert.Equal(expected, result);
        }

        // 5.6 - Тесты для усовершенствованной валидации
        [Fact]
        public void ValidatePasswordEnhanced_ValidPassword_ReturnsTrue()
        {
            var result = PasswordValidator.ValidatePasswordEnhanced("Password123!");
            Assert.True(result);
        }

        [Fact]
        public void ValidatePasswordEnhanced_NoUpperCase_ReturnsFalse()
        {
            var result = PasswordValidator.ValidatePasswordEnhanced("password123!");
            Assert.False(result);
        }

        [Fact]
        public void ValidatePasswordEnhanced_NoLowerCase_ReturnsFalse()
        {
            var result = PasswordValidator.ValidatePasswordEnhanced("PASSWORD123!");
            Assert.False(result);
        }

        [Fact]
        public void ValidatePasswordEnhanced_NoSpecialChar_ReturnsFalse()
        {
            var result = PasswordValidator.ValidatePasswordEnhanced("Password123");
            Assert.False(result);
        }

        [Theory]
        [InlineData("Pass123!", true)]
        [InlineData("password123!", false)]
        [InlineData("PASSWORD123!", false)]
        [InlineData("Password123", false)]
        [InlineData("Short1!", false)]
        public void ValidatePasswordEnhanced_ParameterizedTests(string password, bool expected)
        {
            var result = PasswordValidator.ValidatePasswordEnhanced(password);
            Assert.Equal(expected, result);
        }
    }
}