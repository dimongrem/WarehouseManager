using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Coursework
{
    public static class CryptoService
    {
        public static string GetHashedPassword(string password)
        {
            return GenerateHash(password, GenerateSalt());
        }

        public static bool PasswordIsValid(string password, string hashedPassword)
        {
            return ValidatePassword(password, hashedPassword);
        }

        private static byte[] GenerateSalt()
        {
            using (RNGCryptoServiceProvider saltGen = new RNGCryptoServiceProvider())
            {
                byte[] salt = new byte[16];
                saltGen.GetBytes(salt);
                return salt;
            }
        }

        private static string GenerateHash(string password, byte[] salt)
        {
            using (Rfc2898DeriveBytes hashGen = new Rfc2898DeriveBytes(password, salt, 10000))
            {
                byte[] hash = hashGen.GetBytes(20);
                byte[] hashBytes = new byte[36];
                Array.Copy(salt, 0, hashBytes, 0, 16);
                Array.Copy(hash, 0, hashBytes, 16, 20);
                return Convert.ToBase64String(hashBytes);
            }
        }

        private static bool ValidatePassword(string password, string hashedPassword)
        {
            byte[] hashBytes = Convert.FromBase64String(hashedPassword);
            byte[] salt = new byte[16];
            Array.Copy(hashBytes, 0, salt, 0, 16);
            using (Rfc2898DeriveBytes hashGen = new Rfc2898DeriveBytes(password, salt, 10000))
            {
                byte[] hash = hashGen.GetBytes(20);
                for (int i = 0; i < 20; i++)
                {
                    if (hashBytes[i + 16] != hash[i])
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
