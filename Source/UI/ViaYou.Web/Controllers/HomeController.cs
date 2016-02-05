using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViaYou.Adapters.geobytes;
using ViaYou.Services.Culture;

namespace ViaYou.Web.Controllers
{
    public class HomeController : BaseController
    {
        private ICitiesProvider _citiesProvider;

        public HomeController(ICitiesProvider citiesProvider)
        {
            _citiesProvider = citiesProvider;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ChangeLanguage(string backUrl, string culture = "ES")
        {
            HttpCookie cookie = Request.Cookies["_cultureViaYou"];
            if (cookie != null)
                cookie.Value = culture;   // update cookie value
            else
            {
                cookie = new HttpCookie("_cultureViaYou")
                {
                    Value = culture,
                    Expires = DateTime.Now.AddYears(1)
                };
            }
            Response.Cookies.Add(cookie);
            return Redirect(backUrl);
        }
        
        [AllowAnonymous]
        public JsonResult RetrieveCities(string searchTerm, int pageSize, int pageNum)
        {
            var cities = _citiesProvider.GetCities(searchTerm);
            var results = cities.Where(x=>x.Name.Contains(searchTerm) || x.Code.ToString().Contains(searchTerm)).Select(c => new { id = c.Code, text = c.Name }).ToList();
            return new JsonResult
            {
                Data = new { Total = results.Count(), Results = results },
                JsonRequestBehavior = JsonRequestBehavior.AllowGet
            };
        }

    }
}