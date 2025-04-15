using Incubadora.Project.Domain.Infrastructure.Service;
using System.Security.Cryptography;
using System.Text;

namespace Incubadora.Project.Infrastructure.Service
{
    public class CryptographyService : ICryptographyService
    {
        private static readonly byte[] key = Encoding.ASCII.GetBytes("myyfirsttkeyyrandom32bytesssssss");
        private static readonly byte[] iv = Encoding.ASCII.GetBytes("myysecond16bytes");

        public string Cryptograph(string password)
        {
            using Aes aesAlg = Aes.Create();
            aesAlg.Key = key;
            aesAlg.IV = iv;
            aesAlg.Mode = CipherMode.CBC;
            aesAlg.Padding = PaddingMode.PKCS7;

            ICryptoTransform encryptor = aesAlg.CreateEncryptor();

            using MemoryStream msEncrypt = new();
            using CryptoStream csEncrypt = new(msEncrypt, encryptor, CryptoStreamMode.Write);
            using (StreamWriter swEncrypt = new(csEncrypt))
            {
                swEncrypt.Write(password);
            }

            return Convert.ToBase64String(msEncrypt.ToArray());
        }

        public string Descryptograph(string password)
        {
            using Aes aesAlg = Aes.Create();
            aesAlg.Key = key;
            aesAlg.IV = iv;
            aesAlg.Mode = CipherMode.CBC;
            aesAlg.Padding = PaddingMode.PKCS7;

            ICryptoTransform decryptor = aesAlg.CreateDecryptor();

            // Tenta converter a string de Base64
            byte[] buffer = Convert.FromBase64String(password);

            using MemoryStream msDecrypt = new(buffer);
            using CryptoStream csDecrypt = new(msDecrypt, decryptor, CryptoStreamMode.Read);
            using StreamReader srDecrypt = new(csDecrypt);

            return srDecrypt.ReadToEnd();
        }
    }
}
