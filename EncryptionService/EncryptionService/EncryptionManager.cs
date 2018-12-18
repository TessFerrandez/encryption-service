namespace EncryptionService
{
    public class EncryptionManager
    {
        public static string Key { get; } = "jfkgotmyvhspcandxlrwebquiz";

        public static string Decrypt(string cipherText)
        {
            char[] chars = new char[cipherText.Length];

            for (int i = 0; i < cipherText.Length; i++)
            {
                if (cipherText[i] == ' ')
                {
                    chars[i] = ' ';
                }
                else
                {
                    int j = Key.IndexOf(cipherText[i]) - 97;
                    chars[i] = (char)j;
                }
            }

            return new string(chars);
        }
        public static string Encrypt(string plainText)
        {
            char[] chars = new char[plainText.Length];

            for (int i = 0; i < plainText.Length; i++)
            {
                if (plainText[i] == ' ')
                {
                    chars[i] = ' ';
                }
                else
                {
                    int j = plainText[i] - 97;
                    chars[i] = Key[j];
                }
            }

            return new string(chars);
        }
    }
}
