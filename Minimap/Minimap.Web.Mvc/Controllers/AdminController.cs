using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Minimap.Web.MVC.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Dashboard()
        {
            if (Session["Userid"] == null)
            {
                return RedirectToAction("Login", "User");
            }
            return View();
        }

        public ActionResult Users()
        {
            if (Session["Userid"] == null)
            {
                return RedirectToAction("Login", "User");
            }
            return View();
        }

        public ActionResult Admins()
        {
            if (Session["Userid"] == null)
            {
                return RedirectToAction("Login", "User");
            }
            return View();
        }

        public ActionResult Channels()
        {
            if (Session["Userid"] == null)
            {
                return RedirectToAction("Login", "User");
            }
            return View();
        }

        public ActionResult Notifications()
        {
            if (Session["Userid"] == null)
            {
                return RedirectToAction("Login", "User");
            }
            return View();
        }

        public ActionResult Markers()
        {
            if (Session["Userid"] == null)
            {
                return RedirectToAction("Login", "User");
            }
            return View();
        }

        public ActionResult Requests()
        {
            if (Session["Userid"] == null)
            {
                return RedirectToAction("Login", "User");
            }
            return View();
        }
        public ActionResult Logout()
        {
            Session["Userid"] = null;
            Session["Usertypeid"] = null;
            Session["Username"] = null;
            return RedirectToAction("Login", "User");
        }
    }
}