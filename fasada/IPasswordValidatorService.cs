﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fasada
{
    interface IPasswordValidatorService
    {
        bool IsValidPassword(String candidate);
    }

}
