using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.AspNetCore.Mvc;
using WebConfigTransform.Core;
using WebConfigTransform.Web.Models;

namespace WebConfigTransform.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var vm = new ConfigTransformViewModel();
            return View(vm);
        }
        [HttpPost]
        public IActionResult Index(ConfigTransformViewModel vm)
        {
            vm.OutPutConfigStr = XDocument.Parse(WebConfigTransformer.Transform(vm.WebConfigStr, vm.TransformConfigStr)).ToString();
            

            return View(vm);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
