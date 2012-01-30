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
        public JsonResult Update(int id, User user)
        {
            var oldUser = (from u in MvcApplication.UserRepository
                          where u.Id == id
                          select u).First();

            oldUser.Name = user.Name;
            oldUser.Email = user.Email;

            return Json(new
            {
                success = true,
                message = string.Format("Update user id {0}called successfully", id)
            });
        }

    }
}
