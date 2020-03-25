using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace DesignPatterns.ChainOfResponsibilityPattern.Validators
{

    public class SocialSecurityNumberValidator
    {
        public bool Validate(string ssn, RegionInfo region)
        {
            return false;
        }
    }
}
