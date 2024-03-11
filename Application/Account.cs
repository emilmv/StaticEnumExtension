namespace Service
{
    public class Account : IAccount
    {
        public Roles Role { get; set; }
        public string ?Email { get; set; }
        public string ?Password { get; set; }


        public bool checkRole(Roles role)
        {
            if (role == Roles.SuperAdmin) return true;
            else return false;
        }

        public void login(string email,string password)
        {
            if(email==Constants.correctMail&&password==Constants.correctPassword)
                Console.WriteLine(Constants.sucessfulLogin);
            else Console.WriteLine(Constants.failedAttempt);
        }

        public enum Roles
        {
            SuperAdmin,
            Admin,
            Member
        }
    }
}
