using DatabaseLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfECommerceProject.ViewModels
{
    class AddItemToSellPageViewModel : BaseViewModel
    {
        private string _price;

        public string price
        {
            get { return _price; }
            set
            {
                _price = value;
                OnPropertyChanged("price");
            }
        }

        private string _name;

        public string name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged("name");
            }
        }

        public AddItemToSellPageViewModel()
        {
            name = "name here";
            price = "price here";
        }
        /////////////////////////////////////////////////////
        private ICommand _addSomeItem;

        public ICommand addSomeItem
        {
            get
            {
                if (_addSomeItem == null)
                {
                    _addSomeItem = new Command(addToDB, canAddToDB);
                }
                return _addSomeItem;
            }
            set { _addSomeItem = value; }
        }

        private bool canAddToDB()
        {
            return true;//Could add logic to check if this item already exists.
        }

        private void addToDB()
        {
            Dump dump = new Dump(new ECommerceProjectSystemEntities());
            item item1 = new item() { item_name = name, item_price = Int32.Parse(price) };
            dump.addItemtoDB(item1);
        }

    }
}
