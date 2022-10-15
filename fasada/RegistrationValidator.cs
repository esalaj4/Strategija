using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fasada
{
    class RegistrationValidator:IRegistrationValidator
    {
        private EmailValidator emailValidator;
        private PasswordValidator passwordValidator;

        public RegistrationValidator(EmailValidator emailValidator,PasswordValidator passwordValidator)
        {
            this.emailValidator = emailValidator;
            this.passwordValidator = passwordValidator;
        }

        public bool IsUserEntryValid(UserEntry entry)
        {
            if (emailValidator.IsValidAddress(entry.Email) && passwordValidator.IsValidPassword(entry.Password))
                return true;
            return false;

        }
    }
}
