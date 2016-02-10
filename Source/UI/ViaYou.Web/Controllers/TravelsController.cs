using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViaYou.Services.TravelSearchProvider;
using ViaYou.Web.Models;

namespace ViaYou.Web.Controllers
{
    public class TravelsController : Controller
    {
        private readonly ITravelSearchService _travelSearchService;

        public TravelsController(ITravelSearchService travelSearchService)
        {
            _travelSearchService = travelSearchService;
        }

        // GET: Travels
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult SearchTravels(SearchTravelViewModel data)
        {
            var travels = _travelSearchService.SearchTravels(data.From, data.To, data.CategoryId, data.ContainedInId);
            return PartialView(travels);
        }
    }
}