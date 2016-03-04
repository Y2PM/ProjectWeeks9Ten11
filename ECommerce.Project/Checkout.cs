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
            double totalPrice = 0;
            for (int i = 0; i < basket.itemsList.Count; i++)
            {
                totalPrice += basket.itemsList[i].price;
            }

            return totalPrice;
        }

        ////OverLoad1:
        //public double calculatedPrice()
        //{
        //    return 0;
        //}

    }
}
