using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace VideoRentalStore
{
    /// <summary>
    ///     Authentication class
    /// </summary>
    public class CAuthentication
    {
        /// <summary>Contains a list of <see cref="CUser"/> "/>">.</summary>
        static List<CUser> Users = new List<CUser>() { new CUser("admin", "1"), new CUser("user1", "2") };

        /// <summary>
        /// Initializes a new instance of the <see cref="CAuthentication"/> class.
        /// </summary>
        public CAuthentication()
        {
           
        }

        /// <summary>
        /// This method method checks user login.  
        /// </summary>
        /// <param><c>username</c> is name of user.
        /// </param>
        /// <param><c>hash</c> is SHA256 hash of user name and password.
        /// </param>
        /// <example>For example:
        /// <code>
        /// string name="admin"
        /// string password="2"
        /// bool success = CAuthentication.Login("admin", CUser.GetHashString(name+password));
        /// </code>
        /// results in <c>success</c>'s having the value true if success.
        /// </example>
        /// <returns>True if name and password exist</returns>
        public static bool Login(string username, string hash)
        {
            List<CUser> users = Users.Where(u => u.UserName == username && u.Hash == hash).ToList<CUser>();
            CUser us= new CUser("admin", "1");
            return (users.Count() >0);
        }
    }
}
