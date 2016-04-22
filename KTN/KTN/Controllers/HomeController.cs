using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KTN.KTNServiceRef;
using KTN.Models;
using KTN.Security;

namespace KTN.Controllers
{
    [LoggedInFilter]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Persons()
        {
            KTNServiceClient client = new KTNServiceClient();
            IndexPersonsVM model = new IndexPersonsVM();
            model.Countries = client.GetRegions(RegionsType.COUNTRIES);
            model.Cities = client.GetRegions(RegionsType.CITIES);
            model.Districts = client.GetRegions(RegionsType.DISTRICTS);
            
            client.Close();
            return View(model);
        }

        public JsonResult Citizens()
        {
            KTNServiceClient client = new KTNServiceClient();
            PersonDto[] citizens = client.GetPersons();

            client.Close();
            return Json(citizens, JsonRequestBehavior.AllowGet);
        }

    }
}