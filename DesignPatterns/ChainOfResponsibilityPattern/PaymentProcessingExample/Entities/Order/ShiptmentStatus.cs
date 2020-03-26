using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ChainOfResponsibilityPattern.PaymentProcessingExample.Entities
{
    public enum ShiptmentStatus
    {
        WaitingForPayment = 1,
        ReadyForShipment = 2
    }
}
