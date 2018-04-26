using Minimap.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Minimap.Web.Mvc.Controllers
{
    public class AdminController : Controller
    {
        public IAdminService _service;
        public AdminController(IAdminService service)
        {
            _service = service;
        }

        // GET: Admin
        public ActionResult Index()
        {
          // return View(_service.GetAll());
            return View();
        }
    }
}