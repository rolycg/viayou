using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViaYou.Services.Culture;

namespace ViaYou.Web.Controllers
{
    public class HomeController : BaseController
    {
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
            var list = new List<string>
            {
                "La habana",
                "Rio",
                "Madrid"
            };
            var results = list.Where(x=>x.ToLower().Contains(searchTerm)).Select(c => new { id = c, text = c }).ToList();
            return new JsonResult
            {
                Data = new { Total = results.Count(), Results = results },
                JsonRequestBehavior = JsonRequestBehavior.AllowGet
            };
        }

    }
}