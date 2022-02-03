using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
namespace VideoRentalStore
{
    public class CUser
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        public string Hash { get { return GetHashString(UserName + Password); } }
        public CUser(string username, string password)
        {
            UserName = username;
            Password = password;
        }

        static byte[] GetHash(string inputString)
        {
            using (HashAlgorithm algorithm = SHA256.Create())
                return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
        }

        public static string GetHashString(string inputString)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in GetHash(inputString))
                sb.Append(b.ToString("X2"));

            return sb.ToString();
        }
    }
}
