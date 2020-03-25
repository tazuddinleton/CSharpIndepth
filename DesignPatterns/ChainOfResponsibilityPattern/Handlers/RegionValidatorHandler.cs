using DesignPatterns.ChainOfResponsibilityPattern.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ChainOfResponsibilityPattern.Handlers
{    
    public class RegionValidatorHandler : AbstractHandler<User>
    {
        public override void Handle(User request)
        {
            if (request.Region.TwoLetterISORegionName == "SE")
                throw new UserValidationException("Invalid Region");
            base.Handle(request);
        }
    }
}
