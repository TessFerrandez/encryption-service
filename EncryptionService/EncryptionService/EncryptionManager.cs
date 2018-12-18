namespace EncryptionService
{
    public class EncryptionManager
    {
        public string Decrypt(string cipherText, string key)
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
                    int j = key.IndexOf(cipherText[i]) - 97;
                    chars[i] = (char)j;
                }
            }

            return new string(chars);
        }
        public string Encrypt(string plainText, string key)
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
                    chars[i] = key[j];
                }
            }

            return new string(chars);
        }
    }
}
