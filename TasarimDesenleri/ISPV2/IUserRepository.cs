using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPV2
{
    public interface IUserRepository
    {
        List<string> GetUserList();
        int GetUserId(string Username);
        List<int> GetUserRoles(string Username);

        bool GetUserLogin(string Username,string password);
    }
}
