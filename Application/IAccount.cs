using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface IAccount
    {
        public bool checkRole(Account.Roles role);
        public bool login(string email, string password);
    }

}
