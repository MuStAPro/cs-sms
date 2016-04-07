using System;
using System.Linq;

namespace SMSSender
{
    class Crypto
    {
        public static string Encrypt(string _settings)
        {
            char[] settingsChars = _settings.ToCharArray();
            for (int i = 0; i < settingsChars.Count(); i++)
            {
                settingsChars[i] = (char)((Convert.ToInt32(settingsChars[i]) << 2) * 20);
            }

            string result = "";

            for (int i = 0; i < settingsChars.Length; i++)
            {
                result = result + settingsChars[i];
            }

            return result;
        }

        public static string Decrypt(string _settings)
        {
            string decryptedString = "";
            char[] settingsChars = _settings.ToCharArray();
            for (int i = 0; i < settingsChars.Count(); i++)
            {
                settingsChars[i] = (char)((Convert.ToInt32(settingsChars[i]) >> 2) / 20);
            }

            for (int i = 0; i < settingsChars.Length; i++)
            {
                decryptedString = decryptedString + settingsChars[i];
            }
            return decryptedString;
        }
    }
}
