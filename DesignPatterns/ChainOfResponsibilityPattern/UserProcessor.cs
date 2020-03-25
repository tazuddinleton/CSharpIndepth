﻿using DesignPatterns.ChainOfResponsibilityPattern.Exceptions;
using DesignPatterns.ChainOfResponsibilityPattern.Handlers;
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
			try
			{
                new SsnValidatorHandler()
                   .SetNext(new AgeValidatorHandler())
                   .SetNext(new NameValidatorHandler())
                   .SetNext(new RegionValidatorHandler())
                   .Handle(user);

                return true;
            }
			catch (UserValidationException)
			{
                return false;
			}
        }
    }
}
