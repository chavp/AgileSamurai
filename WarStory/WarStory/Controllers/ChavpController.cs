using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WarStory.Models;
using WarStory.Repositories;

namespace WarStory.Controllers
{
    public class ChavpController : Controller
    {
        //
        // GET: /Chavp/

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetWarehouse(string name)
        {
            WarehouseRepository warehouseRepository = new WarehouseRepository("mongodb://localhost");
            var warehouse = warehouseRepository.Save(name);
            return Json(
                new { warehouse = warehouse, total = 1, success = true },
                JsonRequestBehavior.AllowGet);
        }
    }
}
