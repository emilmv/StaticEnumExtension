namespace Service
{
    public interface IAccount
    {
        public bool checkRole(Account.Roles role);
        public bool login(string email, string password);
    }

}
