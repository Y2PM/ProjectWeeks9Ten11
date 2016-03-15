using DatabaseLibrary;
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
        Dump dump = new Dump(new ECommerceProjectSystemEntities());
        decimal totprice;

        public decimal GetPrice()
        {


            List<item> items = dump.GetItemsFromDB();
            

            foreach (item iteM in items)
            {
                totprice += (decimal)iteM.item_price;
            }

            thePriceO.thePrice = totprice;//Here can get data from database / entity frame work maybe.
            return thePriceO.thePrice;
        }
    }
}
