using DesignPatterns.ChainOfResponsibilityPattern.Exceptions;
using DesignPatterns.ChainOfResponsibilityPattern.Validators;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ChainOfResponsibilityPattern.Handlers
{
    public class SsnValidatorHandler : AbstractHandler<User>
    {

        private SocialSecurityNumberValidator validator
            = new SocialSecurityNumberValidator();
            

        public override void Handle(User request)
        {
            if (!validator.Validate(request.SSN, request.Region))
                throw new UserValidationException("Social sequrity number is invalid.");

            base.Handle(request);
        }

    }
}
