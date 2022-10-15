using System;

namespace Fasada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string invalidPassword = "kdsd";
            string validPassword = "Password2";
            string invalidEmail = "email";
            string validEmail = "salaj@gmail.com";

            EmailValidator emailValidator = new EmailValidator();
            PasswordValidator passwordValidator = new PasswordValidator(5);

            Console.WriteLine(emailValidator.IsValidAddress(invalidEmail));
            Console.WriteLine(emailValidator.IsValidAddress(validEmail));
            Console.WriteLine(passwordValidator.IsValidPassword(invalidPassword));
            Console.WriteLine(passwordValidator.IsValidPassword(validPassword));

            UserEntry user;
            bool validUser;
            RegistrationValidator validator = new RegistrationValidator(emailValidator, passwordValidator);

            
            do
            {
                Console.WriteLine("upisite ispravnog korisnika:");
                user = UserEntry.ReadUserFromConsole();
                validUser = validator.IsUserEntryValid(user);
            } while (!validUser);

        }
    }
}
