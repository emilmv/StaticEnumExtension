using static Service.Account;

namespace Service
{
    public interface IAccount
    {
        public void Login(string email, string password, Roles role);
    }

}
