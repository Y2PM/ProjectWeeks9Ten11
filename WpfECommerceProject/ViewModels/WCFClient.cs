using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WCFService;

namespace WpfECommerceProject.ViewModels
{
    public class WCFClient
    {
        EndpointAddress endpoint = new EndpointAddress("http://trnlon11566:8081/ChatService");

        public void Method()
        {
            IGetPriceService proxy = ChannelFactory<IGetPriceService>.CreateChannel(new BasicHttpBinding(), endpoint);
            //             Contract                                                      Binding            Address
            int thePrice = proxy.GetPrice();

            Console.WriteLine(thePrice);
        }
    }
}
