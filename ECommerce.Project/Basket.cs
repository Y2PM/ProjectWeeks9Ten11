using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Project
{
    public class Basket
    {
        int itemNumber = 0;

        public Dictionary<int,Item> addItem(Item anItem)
        {
            Dictionary<int,Item> basket = new Dictionary<int,Item>();
            basket.Add(itemNumber++, anItem);
            return basket;
        }


        
    }
}
