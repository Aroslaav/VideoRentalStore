using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace VideoRentalStore
{
    public class CAuthentication
    {
        static List<CUser> Users = new List<CUser>() { new CUser("admin", "1"), new CUser("user1", "2") };

        public CAuthentication()
        {
           
        }

        public static bool Login(string username, string hash)
        {
            List<CUser> users = Users.Where(u => u.UserName == username && u.Hash == hash).ToList<CUser>();
            CUser us= new CUser("admin", "1");
            return (users.Count() >0);
        }
    }
}
