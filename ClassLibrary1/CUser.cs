using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
namespace VideoRentalStore
{
    /// <summary>
	/// Class of user 
	/// </summary>
    public class CUser
    {
        /// <summary>
		/// Initializes a new instance of the <see cref="CUser{T}"/>  class.
		/// </summary>
		/// <param><c>username</c> is name of user.
		/// </param>
        /// /// <param><c>password</c> is password of user.
		/// </param>
        public CUser(string username, string password)
        {
            UserName = username;
            Password = password;
        }
        /// <summary>
        /// Gets and sets the name of the user.  
        /// </summary>
        /// <value>The name of the user</value>
        public string UserName { get; set; }

        /// <summary>
        /// Gets and sets the password of the user.  
        /// </summary>
        /// <value>The password of the user</value>
        public string Password { get; set; }

        /// <summary>
        /// Gets the hash of  user name and password.  
        /// </summary>
        /// <value>The password of the user</value>
        public string Hash { get { return GetHashString(UserName + Password); } }

        /// <summary>
        /// This method get SHA256 hash from string .  
        /// </summary>
        /// <param><c>inputString</c>  string for convert to hash.
        /// </param>
        /// <returns>A byte array of hash string</returns>
        static byte[] GetHash(string inputString)
        {
            using (HashAlgorithm algorithm = SHA256.Create())
                return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
        }

        /// <summary>
        /// This method convert from hash to string .  
        /// </summary>
        /// <param><c>inputString</c>  string for convert to hash.
        /// </param>
        /// <returns>A hashed string</returns>
        public static string GetHashString(string inputString)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in GetHash(inputString))
                sb.Append(b.ToString("X2"));

            return sb.ToString();
        }
    }
}
