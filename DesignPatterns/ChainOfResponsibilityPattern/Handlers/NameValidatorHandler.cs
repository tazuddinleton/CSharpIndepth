using DesignPatterns.ChainOfResponsibilityPattern.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ChainOfResponsibilityPattern.Handlers
{
    public class NameValidatorHandler : AbstractHandler<User>
    {
        public override void Handle(User request)
        {
            if (request.Name.Length <= 1)
                throw new UserValidationException("Invalid name");
            base.Handle(request);
        }
    }
}
