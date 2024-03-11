using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface IAccount
    {
        bool checkRole(Account.Roles role);
        public void login(string email, string password);
    }

}
