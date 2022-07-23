﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StrategyPattern
{
    public class StrategyProgram
    {
        public static void Run()
        {
            var paymentContext = new PaymentContext();

            paymentContext.SetStrategy(new CreditCardStrategy("4508750015741019", 123, "01/22"));
            paymentContext.Pay(100);

            paymentContext.SetStrategy(new PayPalStrategy("test", "P@ssword123"));
            paymentContext.Pay(200);
        }
    }
}
