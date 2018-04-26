using Minimap.Core.Entities;
using Minimap.Core.Service;
using Minimap.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Minimap.Web.Mvc.Controllers
{
    public class HomeController : Controller
    {
        AccountDetailService accountDetailService;
        AccountDetail accountDetail;
       
        public HomeController()
        {
            accountDetailService = new AccountDetailService();
            accountDetail = new AccountDetail();
        }
        
        // GET: Home
        public ActionResult Index()
        {
            DateTime date = new DateTime();
            date = DateTime.Now;

            accountDetail.Username = "finalG";
            accountDetail.FirstName = "a";
            accountDetail.LastName = "afserA";
            accountDetail.Email = "fahimh02@gmail.com";
            accountDetail.UserTypeId = "client";
            accountDetail.Gender = "Male";
            accountDetail.JoinDate = date;
            accountDetail.MobileNo = "01620171819";
            accountDetail.TotalChaneel = 20;
            accountDetail.TotalMarker = 50;
            accountDetail.TotalSubscription = 10;

            //accountDetailService.AddAccount(accountDetail);
            accountDetailService.DeleteAccount("finalG");
           

            return View();
        }


    }
}