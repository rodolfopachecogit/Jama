using System.Text;

namespace JamaAutomationFramework.Utilities
{
    public static class StringUtils
    {
        /// <summary>
        /// Generates a random string of the specified length using alphanumeric characters.
        /// </summary>
        /// <param name="length">The length of the random string to generate.</param>
        /// <returns>A random alphanumeric string.</returns>
        public static string GenerateRandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var random = new Random();
            var stringBuilder = new StringBuilder();

            for (int i = 0; i < length; i++)
            {
                var index = random.Next(chars.Length);
                stringBuilder.Append(chars[index]);
            }

            return stringBuilder.ToString();
        }
    }
}
