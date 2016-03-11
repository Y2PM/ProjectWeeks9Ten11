using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFService
{
    public class GetPriceService : IGetPriceService
    {
        int thePrice = 10;

        public int GetPrice()
        {
            return thePrice;
        }
    }
}
