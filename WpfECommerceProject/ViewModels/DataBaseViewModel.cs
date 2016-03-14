using DatabaseLibrary;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WCFService;

namespace WpfECommerceProject.ViewModels
{
    public class DataBaseViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<item> _items;

        public ObservableCollection<item> items
        {
            get
            { return _items; }
            set
            {
                _items = value;
                OnPropertyChanged("items");
            }
        }

        private Dump dump;

        public DataBaseViewModel()//constructor for normal use
        {
            dump = new Dump(new ECommerceProjectSystemEntities());

            items = new ObservableCollection<item>();
            items = new ObservableCollection<item>(dump.GetItemsFromDB());

            //
            thePrice = new ObservableCollection<int>();
            GetPriceMethod();
        }

        public DataBaseViewModel(Dump injectedDump)//Constructor for test cases using mock
        {
            dump = injectedDump;

            items = new ObservableCollection<item>();
            items = new ObservableCollection<item>(dump.GetItemsFromDB());

            //
            thePrice = new ObservableCollection<int>();
            GetPriceMethod();
        }

        //------------------WCFClient:
        EndpointAddress endpoint = new EndpointAddress("http://trnlon11566:8081/GetPriceService");

        private ObservableCollection<int> _thePrice;

        public ObservableCollection<int> thePrice
        {
            get { return _thePrice; }
            set
            {
                _thePrice = value;
                OnPropertyChanged("thePrice");
            }
        }

        public void GetPriceMethod()
        {
            IGetPriceService proxy = ChannelFactory<IGetPriceService>.CreateChannel(new BasicHttpBinding(), endpoint);
            //             Contract                                                      Binding            Address
            //GetPriceService
            thePrice.Add(proxy.GetPrice());
        }
        //----------------------------
        public event PropertyChangedEventHandler PropertyChanged;
        //
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        //
    }
}
