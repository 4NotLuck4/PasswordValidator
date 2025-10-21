using System.Linq;

namespace PasswordValidator
{
    public static class PasswordValidator
    {
        public static bool ValidatePassword(string password)
        {
            // 5.1 - Базовая валидация
            if (string.IsNullOrEmpty(password) || password.Length < 8)
                return false;

            if (!password.Any(char.IsDigit))
                return false;

            if (!password.Any(c => (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z')))
                return false;

            return true;
        }

        // 5.6 - Усовершенствованная валидация
        public static bool ValidatePasswordEnhanced(string password)
        {
            if (string.IsNullOrEmpty(password) || password.Length < 8)
                return false;

            if (!password.Any(char.IsDigit))
                return false;

            if (!password.Any(c => (c >= 'A' && c <= 'Z'))) // Верхний регистр
                return false;

            if (!password.Any(c => (c >= 'a' && c <= 'z'))) // Нижний регистр
                return false;

            if (!password.Any(c => !char.IsLetterOrDigit(c))) // Спецсимвол
                return false;

            return true;
        }
    }
}