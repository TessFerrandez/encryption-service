using System;

namespace EncryptionService
{
    public class EncryptionManager
    {
        public string Decrypt(string cipherText, string key)
        {
            char[] chars = new char[cipherText.Length];

            try
            {
                for (int i = 0; i < cipherText.Length; i++)
                {
                    if (cipherText[i] == ' ')
                    {
                        chars[i] = ' ';
                    }
                    else
                    {
                        int j = key.IndexOf(cipherText[i]) + 97;
                        chars[i] = (char)j;
                    }
                }    
            }
            catch(IndexOutOfRangeException ex)
            {
                throw new Exception("key must be longer than alphabet");
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return new string(chars);
        }
        public string Encrypt(string plainText, string key)
        {
            char[] chars = new char[plainText.Length];

            try
            {
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
            }
            catch (IndexOutOfRangeException ex)
            {
                throw new Exception("key must be longer than alphabet");
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return new string(chars);
        }
    }
}
