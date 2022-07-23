using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StrategyPattern
{
    public interface IPaymentStrategy
    {
        void Pay(decimal amount);
    }
}
