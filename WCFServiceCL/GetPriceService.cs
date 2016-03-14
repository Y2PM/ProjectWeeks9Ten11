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
        //Dump dump = new Dump(new ECommerceProjectSystemEntities());

        public int GetPrice()
        {


            //List<item> items = dump.GetItemsFromDB();
            //decimal totprice;

            //foreach (item iteM in items)
            //{
            //    totprice += (decimal)iteM.item_price;
            //}

            thePriceO.thePrice = 10;//Here can get data from database / entity frame work maybe.
            return thePriceO.thePrice;
        }
    }
}
