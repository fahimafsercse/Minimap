using Minimap.Core.Entities;
using Minimap.Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Minimap.Web.Mvc.Controllers
{
    public class HomeController : Controller
    {
        AccountDetailService accountDetailService= new AccountDetailService();
        AccountDetail accountDetail = new AccountDetail();
        
        // GET: Home
        public ActionResult Index()
        {
            DateTime date1 = new DateTime(2010, 8, 18);


            accountDetail.Username = "afser02";
            accountDetail.FirstName = "a";
            accountDetail.LastName = "afserA";
            accountDetail.Email = "afserA@gmail.com";
            accountDetail.TotalChaneel = 20;
            accountDetail.TotalMarker = 50;
            accountDetail.TotalSubscription = 10;
            accountDetail.UserTypeId = "client";
            
            accountDetail.JoinDate = date1;
            accountDetail.MobileNo = "01620171819";
            accountDetailService.Add(accountDetail);
            return View();
        }
    }
}