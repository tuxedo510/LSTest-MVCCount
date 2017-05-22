using LSTest_MVCCount.CountService;
using LSTest_MVCCount.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LSTest_MVCCount.Controllers
{
    public class HomeController : Controller
    {
        ICounterService _service;

        public HomeController() {
            _service = new CounterService();
        }

        public HomeController(ICounterService service) {
            _service = service;
        }
        public ActionResult Index()
        {
            int count = _service.ResetCount();
            return View(count);
        }

        public int CountFunction()
        {
            var count = _service.IncreaseCount();

            return count;
        }
    }
}