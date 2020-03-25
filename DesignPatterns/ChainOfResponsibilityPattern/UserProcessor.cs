using DesignPatterns.ChainOfResponsibilityPattern.Validators;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ChainOfResponsibilityPattern
{
    public class UserProcessor
    {
        public bool Register(User user)
        {

            var ssnValidator = new SocialSecurityNumberValidator();

            if (!ssnValidator.Validate(user.SSN))
                return false;

            if (user.Name.Length <= 1)
                return false;

            if (user.Age < 18)
                return false;

            if (user.Region.TwoLetterISORegionName == "SE")
                return false;

            return true;
        }
    }
}
