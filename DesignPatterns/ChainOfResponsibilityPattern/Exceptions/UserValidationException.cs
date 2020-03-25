using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ChainOfResponsibilityPattern.Exceptions
{
    public class UserValidationException : Exception
    {
        public UserValidationException(string msg)
            : base(msg)
        { 
        
        }
    }
}
