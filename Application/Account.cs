namespace Service
{
    public class Account : IAccount
    {
        public Roles Role { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }


        public void Login(string email, string password, Roles role)
        {
            if (email == Constants.correctMail && password == Constants.correctPassword)
            {
                if (role == Roles.SuperAdmin)
                {
                    Console.WriteLine(Constants.sucessfulLogin);
                }
                else
                {
                    Console.WriteLine(Constants.noPermission);
                }
            }
            else
            {
                Console.WriteLine(Constants.failedAttempt);
            }

        }
        private bool CheckRole(Roles role)
        {
            if (role == Roles.SuperAdmin) return true;
            return false;
        }


        public enum Roles
        {
            SuperAdmin,
            Admin,
            Member
        }
    }
}
