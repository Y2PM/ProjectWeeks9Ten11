using ASPECommerceApplication.Models;
using DatabaseLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WCFService;

namespace ASPECommerceApplication.Controllers
{
   
    public class GetPriceController : Controller
    {
        public static GetPrice thePriceO = new GetPrice();
        decimal totprice;

        //static ECommerceProjectSystemEntities contexT;//Injection.
        //public GetPriceController(ECommerceProjectSystemEntities givenContext)//Construction.
        //{
        //    contexT = givenContext;
        //}

        ////Overload1
        //public GetPriceController()
        //{
        //}

        Dump dump = new Dump(new ECommerceProjectSystemEntities());


        // GET: GetItems
        public ActionResult Index()
        {
            if (Request.IsAjaxRequest())
            {
                return MakeDecimalReturnable(thePriceO.thePrice);
            }

            //Here code connects to the service.
            List<item> items = dump.GetItemsFromDB();

            foreach (item iteM in items)
            {
                totprice += (decimal)iteM.item_price;
            }

            thePriceO.thePrice = totprice;
            
            return View();
        }

        public PartialViewResult MakeDecimalReturnable(decimal decimaL)
        {
            PriceClassModel PCM = new PriceClassModel();
            PCM.price = decimaL;
            return PartialView("PartialViewGetPrice", PCM);
        }
    }
}