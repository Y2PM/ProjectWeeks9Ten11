using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFService
{
    public class GetPriceService : IGetPriceService
    {
        GetPrice thePriceO = new GetPrice();
        

        public int GetPrice()
        {
            thePriceO.thePrice = 10;//Here can get data from database / entity frame work maybe.
            return thePriceO.thePrice;
        }
    }
}
