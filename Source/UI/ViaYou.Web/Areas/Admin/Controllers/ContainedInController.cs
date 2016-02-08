using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViaYou.Domain.Repositories;

namespace ViaYou.Web.Areas.Admin.Controllers
{
    public class ContainedInController : Controller
    {
        IContainedInRepository _containedInRepository;
        public ContainedInController(IContainedInRepository containedInRepository)
        {
            _containedInRepository = containedInRepository;
        }

        // GET: Admin/ContainedIn
        public ActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        public JsonResult RetrieveContainedIn(string searchTerm, int pageSize, int pageNum)
        {
            var cities = _containedInRepository.GetAll();
            var results = cities.Where(c => c.Name.Contains(searchTerm)).Select(c => new { id = c.Id, text = c.Name }).ToList();
            return new JsonResult
            {
                Data = new { Total = results.Count(), Results = results },
                JsonRequestBehavior = JsonRequestBehavior.AllowGet
            };
        }
    }
}