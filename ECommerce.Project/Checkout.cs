using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Project
{
    public class Checkout
    {
        public double calculatedPrice(Basket basket)
        {

            return basket.itemsList[0].price;
        }

        //OverLoad1:
        public double calculatedPrice()
        {
            return 0;
        }

    }
}
