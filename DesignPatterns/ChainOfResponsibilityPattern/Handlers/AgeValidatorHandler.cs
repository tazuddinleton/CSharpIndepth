using DesignPatterns.ChainOfResponsibilityPattern.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ChainOfResponsibilityPattern.Handlers
{
    public class AgeValidatorHandler : AbstractHandler<User>
    {
        public override void Handle(User request)
        {
            if(request.Age < 18)
                throw new UserValidationException("Age cannot be less than 18 year.");
            base.Handle(request);
        }
    }
}
