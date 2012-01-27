using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using extjs_mvc_over_asp_mvc.Models;

namespace extjs_mvc_over_asp_mvc.Controllers
{
    public class UserController : Controller
    {
        public JsonResult GetUsers()
        {
            var users = MvcApplication.UserRepository.ToList();

            return Json(new { success = true, users = users }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult Update(int id, string name, string email)
        {
            return View();
        }

    }
}
