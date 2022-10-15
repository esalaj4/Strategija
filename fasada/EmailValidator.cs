using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fasada
{
    class EmailValidator:IEmailValidatorService
    {
        public bool IsValidAddress(String candidate)
        {
            if (candidate.Contains("@") && (candidate.EndsWith(".com") || candidate.EndsWith(".hr")))
                return true;
             return false;
        }

    }
}
