using System;
using System.Linq;

namespace PasswordValidator
{
    public static class PasswordValidator
    {
        public static bool ValidatePassword(string password)
        {
            // Проверка длины пароля
            if (string.IsNullOrEmpty(password) || password.Length < 8)
                return false;

            // Проверка наличия цифры
            if (!password.Any(char.IsDigit))
                return false;

            // Проверка наличия латинского символа
            if (!password.Any(c => (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z')))
                return false;

            return true;
        }
    }
}