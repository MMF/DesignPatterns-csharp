using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ObserverPattern
{
    public interface IOfferSubscriber
    {
        void NewOffer(Dictionary<string, double> offers);
    }
}
