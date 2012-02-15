using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using WarStoryServer.Repositories;

namespace WarStory.Controllers
{
    public class ChavpController : Controller
    {
        //
        // GET: /Chavp/

        string _connectionString = "mongodb://localhost";

        public ActionResult Index()
        {
            string playerName = "Chavp";
            WarehouseRepository warehouseRepository = new WarehouseRepository(_connectionString);
            var warehouse = warehouseRepository.Save(playerName);

            ViewBag.PlayerName = playerName;

            return View(warehouse);
        }

        public JsonResult GetWarehouse(string name)
        {
            WarehouseRepository warehouseRepository = new WarehouseRepository(_connectionString);
            var warehouse = warehouseRepository.Save(name);
            return Json(
                new { warehouse = warehouse, total = 1, success = true },
                JsonRequestBehavior.AllowGet);
        }

        public JsonResult Reset(string name)
        {
            WarehouseRepository warehouseRepository = new WarehouseRepository(_connectionString);
            var warehouse = warehouseRepository.Save(name);
            warehouse.Reset();

            warehouseRepository.Save(warehouse);

            return Json(
                new { warehouse = warehouse, success = true },
                JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult UpgradeForest(string name)
        {
            WarehouseRepository warehouseRepository = new WarehouseRepository(_connectionString);
            var warehouse = warehouseRepository.Save(name);
            warehouse.UpgradeForest();
            warehouseRepository.Save(warehouse);

            return Json(
                new { warehouse = warehouse, success = true },
                JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public JsonResult UpgradeMountain(string name)
        {
            WarehouseRepository warehouseRepository = new WarehouseRepository(_connectionString);
            var warehouse = warehouseRepository.Save(name);
            warehouse.UpgradeMountain();
            warehouseRepository.Save(warehouse);

            return Json(
                new { warehouse = warehouse, success = true },
                JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public JsonResult UpgradeMine(string name)
        {
            WarehouseRepository warehouseRepository = new WarehouseRepository(_connectionString);
            var warehouse = warehouseRepository.Save(name);
            warehouse.UpgradeMine();
            warehouseRepository.Save(warehouse);

            return Json(
                new { warehouse = warehouse, success = true },
                JsonRequestBehavior.AllowGet);
        }
    }
}
