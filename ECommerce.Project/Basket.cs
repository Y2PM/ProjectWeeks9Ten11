using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Project
{
    public class Basket
    {

        public List<Item> itemsList;
        public Basket(List<Item> givenItemsList)
        {
            itemsList = givenItemsList;
        }

        //Overload1:
        public Basket()
        {
        }

        int itemNumber = 0;

        public Dictionary<int, Item> addItem(Item anItem)//Maybe not required
        {
            Dictionary<int, Item> aBasket = new Dictionary<int, Item>();
            aBasket.Add(itemNumber++, anItem);
            return aBasket;
        }

        public void removeItem(Item anItem, List<string> itemsList)
        {
            for (int i = 0; i < itemsList.Count; i++)
            {
                if (anItem.itemName == itemsList[i].itemName)
                {
                    itemsList.Remove(itemsList[i].itemName);
                }
            }
        }


    }
}
