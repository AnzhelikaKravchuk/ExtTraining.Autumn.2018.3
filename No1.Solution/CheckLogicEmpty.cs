﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No1.Solution
{
    public class CheckLogicEmpty : IChecker
    {
        public (bool, string) Check(string password) => password == string.Empty ? (false, $"{password} is empty ") : (true, "Password is OK.");
    }
}
