using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPV2
{
    public class UserRepository : IUserRepository
    {
        public List<string> GetUserList()
        {
            Console.WriteLine("User List");
            return new List<string>();
        }

        public int GetUserId(string Username)
        {
            Console.WriteLine("User");
            return 0;
        }

        public List<int> GetUserRoles(string Username)
        {
            Console.WriteLine("User Roles");
            return new List<int>();
        }

        public bool GetUserLogin(string Username, string password)
        {

            if (Username == "elektroengin" && password == "deneme")
            {
                Console.WriteLine("Giriş başarılı");
                return true;
            }
            else
            {
                Console.WriteLine("Giriş başarsız");
                return false;
            }

        }
    }
}
