using System;

namespace HometasksCsOOPEncapsulationAccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter username and password:");
            string userName = Console.ReadLine();
            string password = Console.ReadLine();

            User user = new User(userName)
            {
                UserName = userName,
                Password = password
            };

            Console.WriteLine($"Username: {user.UserName}, Password: {user.Password}");

            string str = "Hel4o";
            Console.WriteLine(user.HasLower(str));
            Console.WriteLine(user.HasUpper(str));
            Console.WriteLine(user.HasDigit(str));
        }
    }
}
