using System;
using EncryptionService;
using Xunit;

namespace EncryptionService.Test
{
    public class EncryptionManagerTests
    {
        [Fact]
        public void Encrypt_GivenAStringAndKey_ReturnsEncryptedKey()
        {
            //arrange
            EncryptionManager em = new EncryptionManager();
            //act
            var encrypted = em.Encrypt("hej", "bcdefghijklmnopqrstuvwxyza");
            //assert
            Assert.Equal("ifk", encrypted);
        }
        [Fact]
        public void Encrypt_EmptySrting_ReturnsEmptyString()
        {
            //arrange
            EncryptionManager em = new EncryptionManager();
            //act
            var encrypted = em.Encrypt(string.Empty, "bcdefghijklmnopqrstuvwxyza");
            //assert
            Assert.Equal(string.Empty, encrypted);
        }
        [Fact]
        public void Encrypt_KeyTooShort_ThrowsException()
        {
            //arrange
            EncryptionManager em = new EncryptionManager();
            //assert
            Assert.Throws<Exception>(() => em.Encrypt("hej", "abc"));
        }
        [Fact]
        public void Decrypt_GivenAStringAndKey_ReturnsEncryptedKey()
        {
            //arrange
            EncryptionManager em = new EncryptionManager();
            //act
            var decrypted = em.Decrypt("ifk", "bcdefghijklmnopqrstuvwxyza");
            //assert
            Assert.Equal("hej", decrypted);
        }
        [Fact]
        public void Decrypt_EmptySrting_ReturnsEmptyString()
        {
            //arrange
            EncryptionManager em = new EncryptionManager();
            //act
            var decrypted = em.Decrypt(string.Empty, "bcdefghijklmnopqrstuvwxyza");
            //assert
            Assert.Equal(string.Empty, decrypted);
        }
    }
}
