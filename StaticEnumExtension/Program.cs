using Service;
using static Service.Account;

namespace StaticEnumExtension
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            Console.WriteLine("enter email");
            string ?email=Console.ReadLine();
            Console.WriteLine("enter password");
            string ?password=Console.ReadLine();
            Account account = new Account();
            account.Email = email;
            account.Password = password;
            account.Login(email, password, Roles.SuperAdmin);

            #endregion
            #region Task2
            //int num = 3;
            //Console.WriteLine(num.Factorial());
            #endregion
            #region Task3
            //string word = "Salam Kamran, Necesen KAMRAN.";
            //Console.WriteLine(word.MatchCount("Kamran"));
            #endregion
        }
    }
}
