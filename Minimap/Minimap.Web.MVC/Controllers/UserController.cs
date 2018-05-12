using Minimap.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;
using Minimap.Core.Services;
using Minimap.Core.Interfaces;

namespace Minimap.Web.MVC.Controllers
{
    public class UserController : Controller
    {
        MarkerService markerService = new MarkerService();
        UserService userService = new UserService();
        UserTypeService uTypeService = new UserTypeService();
        UserAuthenticationService uAthenticationService = new UserAuthenticationService();
        ChannelService channelService = new ChannelService();
        MarkerChannelService mChannelService = new MarkerChannelService();

        //Login
        public ActionResult Login()
        {
            Session["Userid"] =null;
            Session["Usertypeid"] = null;
            Session["Username"] = null;
            return View();
        }
        public ActionResult VerifyLogin()
        {
            User user = new User();
            string username = Request.Form["Username"];
            string password = Request.Form["Password"];
            user = uAthenticationService.Login(username, password);
            if (user != null)
            {
                Session["Userid"] = user.UserId;
                Session["Usertypeid"] = user.UserTypeId;
                Session["Username"] = user.Username;


                if (user.UserTypeId == 3)
                {
                    return RedirectToAction("Dashboard", "Admin");
                }
                else
                {
                    return RedirectToAction("HomePage", "User");
                }

            }
            else
            {
                return RedirectToAction("Login", "User");

            }

        }
        public ActionResult Logout()
        {
            Session["Userid"] = null;
            Session["Usertypeid"] = null;
            Session["Username"] = null;
            return RedirectToAction("Login", "User");
        }
        //Homepage
        public ActionResult HomePage()
        {
            if (Session["Userid"] == null)
            {
                return RedirectToAction("Login", "User");
            }
            return View();
        }

        public ActionResult Profile()
        {
            if (Session["Userid"] == null)
            {
                return RedirectToAction("Login", "User");
            }
            User user = userService.GetById(Convert.ToInt32(Session["Userid"]));
            return View(user);
        }
        [HttpGet]
        public ActionResult EditProfile(int id)
        {
            if (Session["Userid"] == null){
                return RedirectToAction("Login", "User");
            }

            User user = userService.GetById(id);
            return View(user);
        }
        [HttpPost]
        public ActionResult EditProfile(User u)
        {
            if (Session["Userid"] == null)
            {
                return RedirectToAction("Login", "User");
            }
            User user = new User();
            user.Username = Request.Form["username"];
            user.FirstName = Request.Form["firstname"];
            user.LastName = Request.Form["lastname"];
            user.Email = Request.Form["email"];
            user.Gender = Request.Form["gender"];
            user.Password = Request.Form["password"];
            user.MobileNo = Request.Form["mobileno"];
            userService.EditUser(user);

            User user1 = userService.GetById(Convert.ToInt32(Session["Userid"]));
            return RedirectToAction("Profile", "User", user1);
        }
        public ActionResult DeactiveProfile(int id)
        {
            if (Session["Userid"] == null)
            {
                return RedirectToAction("Login", "User");
            }
            string msg = userService.Deactivate(id);
            User user = userService.GetById(id);

            return RedirectToAction("Login", "User");
        }
        //Registration
        public ActionResult Registration()
        {
            return View();
        }
        public ActionResult AddUser()
        {
            User user = new User();
            user.UserTypeId = 3;
            user.Username = Request.Form["Username"];
            user.FirstName = Request.Form["first_name"];
            user.LastName = Request.Form["last_name"];
            user.Email = Request.Form["email"];
            user.Gender = Request.Form["gender"];
            user.Password = Request.Form["password"];
            string confPass = Request.Form["confirm_password"];
            user.JoinDate = DateTime.Now;
            user.IsValid = true;

            if (user.Password == confPass)
            {
                ViewBag.email = user.Email;
                ViewBag.password = user.Password;
                ViewBag.confpass = confPass;
                ViewBag.firstname = user.FirstName;
                ViewBag.lastname = user.LastName;
                userService.AddUser(user);
                return RedirectToAction("Login", "User");
                //return View();
            }
            else
            {
                return RedirectToAction("Registration", "User");
            }
        }
       


        
        




  

  
        

        //markerService
        public ActionResult AddMarker()
        {
            if (Session["Userid"] == null)
            {
                return RedirectToAction("Login", "User");
            }
            return View();
        }
        public ActionResult AddMarkerList()
        {
            if (Session["Userid"] == null)
            {
                return RedirectToAction("Login", "User");
            }
            List<Marker> markerList = new List<Marker>();
            Marker marker = new Marker();
            int len = Convert.ToInt16(Request.Form["len"]);            
            for (int i = 0; i < len; i++)
            {
                marker = new Marker();
                marker.MarkerName = Request.Form["name[" + i + "]"];
                marker.Lat =  Convert.ToDouble(Request.Form["lat[" + i + "]"]);
                marker.Longi = Convert.ToDouble(Request.Form["lng[" + i + "]"]);
                marker.CreationDate = DateTime.Today;             
                marker.UserId = Convert.ToInt32(Session["Userid"]);
                markerList.Add(marker);
            }
            ViewBag.len1 = markerList.Count();
            ViewBag.count = markerService.AddMarkerList(markerList);
            ViewBag.l = len;
            return RedirectToAction("MyMarkerList","User");    
            //return View();
        }
        public ActionResult MyMarkerList()
        {
            if (Session["Userid"] == null)
            {
                return RedirectToAction("Login", "User");
            }

            List<Marker> markerList = markerService.GetAllMarkers(Convert.ToInt32(Session["Userid"])); 
            //List<Marker> markerList = markerService.GetAllMarkers(3);
            return View(markerList);
        }
        //INCOMPLETE
        public ActionResult ManageMarkers()
        {
            if (Session["Userid"] == null)
            {
                return RedirectToAction("Login", "User");
            }
            List<Marker> markerList = new List<Marker>();
            Marker marker = new Marker();
            int len = Convert.ToInt16(Request.Form["len"]);
            for (int i = 0; i < len; i++)
            {
                marker = new Marker();
                marker.MarkerName = Request.Form["name[" + i + "]"];
                marker.Lat = Convert.ToDouble(Request.Form["lat[" + i + "]"]);
                marker.Longi = Convert.ToDouble(Request.Form["lng[" + i + "]"]);
                marker.CreationDate = DateTime.Today;
                marker.UserId = Convert.ToInt32(Session["Userid"]);
                markerList.Add(marker);
            }
            markerService.GetAllMarkers(3);//Convert.ToInt32(Session["Userid"]));
            return RedirectToAction("MyMarkerList","User",markerList);
            //return View(markerList);
        }
        public ActionResult MarkerDetails(int id)
        {
            if (Session["Userid"] == null)
            {
                return RedirectToAction("Login", "User");
            }
            Marker marker = markerService.GetMarkerById(id);
            return View(marker);
        }




        //NOT WORKIN 

        [HttpGet]
        public ActionResult DeleteMarker(int id)
        {
            if (Session["Userid"] == null)
            {
                return RedirectToAction("Login", "User");
            }
            markerService.DeleteMarkerById(id);
            return RedirectToAction("MyMarkerList", "User");
        }




        //usertype
        public ActionResult UserTypes()
        {
            return View(uTypeService.GetAllUserType());
        }
        public ActionResult AddUserTypes()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddUserTypes(UserType utype)
        {
            uTypeService.AddUserType(utype);

            return RedirectToAction("UserTypes", "User");
        }
        [HttpGet]
        public ActionResult EditUserType(int id)
        {
            UserType uType = uTypeService.GetUserTypeById(id);
            return View(uType);
        }
        [HttpPost]
        public ActionResult EditUserType(UserType  uType)
        {
            uTypeService.EditUserType(uType);
            return RedirectToAction("UserTypes", "User");
        }
        [HttpGet]
        public ActionResult DeleteUserType(int id)
        {
            UserType uType = uTypeService.GetUserTypeById(id);
            return View(uType);          
        }

        [HttpPost]
        public ActionResult DeleteUserType(UserType uType)
        {
            uType.UserTypeName = Request.Form["typeName"];
            UserType u =  uTypeService.GetByUserTypeName(uType.UserTypeName);
            uTypeService.DeleteUserType(u);
            return RedirectToAction("UserTypes", "User");
        }
        [HttpGet]
        public ActionResult UserTypeDetails(int id)
        {
            return View(uTypeService.GetUserTypeById(id));
        }



        
        public ActionResult CreateChannel()
        {
            if (Session["Userid"] == null)
            {
                return RedirectToAction("Login", "User");
            }
            return View();
        }
        
        public ActionResult AddChannelList()
        {
            if (Session["Userid"] == null)
            {
                return RedirectToAction("Login", "User");
            }
            List<Channel> channelList = new List<Channel>();
           
            List<MarkerChannel> markerList = new List<MarkerChannel>();
            MarkerChannel markerChannel = new MarkerChannel();
            Channel ch = new Channel();
            ch.ChannelName = Request.Form["Name"];
            ch.ChannelDescription = Request.Form["Description"];
            ch.CreationDate = DateTime.Today;
            ch.Status = false;
            ch.UserId = Convert.ToInt32(Session["Userid"]);
            
            

            //rest are undone
            /*int len = Convert.ToInt16(Request.Form["len"]);
            for (int i = 0; i < len; i++)
            {
                markerChannel = new MarkerChannel();
                markerChannel.MarkerName = Request.Form["name[" + i + "]"];
                markerChannel.Lat = Convert.ToDouble(Request.Form["lat[" + i + "]"]);
                markerChannel.Longi = Convert.ToDouble(Request.Form["lng[" + i + "]"]);
                markerChannel.UserId = Convert.ToInt32(Session["Userid"]);
                markerList.Add(markerChannel);
            }*/
            //return View(markerList);
            
             channelService.AddChannel(ch);
            channelList = channelService.GetAllChannel();

            return RedirectToAction("MyChannel", "User",channelList);

            //return View();
        }
        [HttpGet]
        public ActionResult ChannelDetails(int id)
        {
            if (Session["Userid"] == null)
            {
                return RedirectToAction("Login", "User");
            }
            Channel ch = new Channel();
            List<MarkerChannel> markerCh = new List<MarkerChannel>();
            ch = channelService.GetChannel(id);
            markerCh =channelService.GetChannelMarkers(ch.ChannelId);


            ViewBag.ChannelDescription = ch.ChannelDescription;
            ViewBag.ChannelId = ch.ChannelId;
            ViewBag.ChannelName = ch.ChannelName;
            ViewBag.CreationDate = ch.CreationDate;
            ViewBag.Status = ch.Status;
            ViewBag.UserId = ch.UserId;
            ViewBag.TotaMarker = ch.TotaMarker;
            ViewBag.TotalSubscriber = ch.TotalSubscriber;
            ViewBag.TotalView = ch.TotalView;
            ViewBag.Rating = ch.Rating;
            return View(markerCh);            
        }


        public ActionResult ExploreChannel()
        {
            if (Session["Userid"] == null)
            {
                return RedirectToAction("Login", "User");
            }
            return View(channelService.GetAllChannel());
        }



        public ActionResult DeleteChannel(int id)
        {
            if (Session["Userid"] == null)
            {
                return RedirectToAction("Login", "User");
            }
            channelService.DeleteChannel(id);
            return RedirectToAction("MyChannel", "User");

        }
        public ActionResult MyChannel()
        {
            if (Session["Userid"] == null)
            {
                return RedirectToAction("Login", "User");
            }
            return View(channelService.GetMyChannels(Convert.ToInt32(Session["Userid"])));
        }


        public ActionResult MySubscribes()
        {
            if (Session["Userid"] == null)
            {
                return RedirectToAction("Login", "User");
            }
            List<Channel> subChannelList = new List<Channel>() ;
            List<Subscription> subList = channelService.GetSubList();
            foreach (var sub in subList)
            {
                if (sub.UserId == Convert.ToInt32(Session["Userid"]))
                {
                    Channel ch = channelService.GetChannel(sub.ChannelId);
                    List<MarkerChannel> markerChannel = channelService.GetChannelMarkers(sub.ChannelId);
                    subChannelList.Add(ch);
                }
            }
            return View(subChannelList);

        }
        
        public ActionResult Subscribe(int channelId)
        {
            if (Session["Userid"] == null)
            {
                return RedirectToAction("Login", "User");
            }
            channelService.SubscribeChannel(channelId,Convert.ToInt32(Session["Userid"]));
            return View();
        }
        [HttpGet]
        public ActionResult Unsubscribe(int?  ch)
        {

            ViewBag.chl = ch;
            /*int channelId = Convert.ToInt32(ch);
            if (Session["Userid"] == null)
            {
                return RedirectToAction("Login", "User");
            }
            channelService.UnsubscribeChannel(channelId, Convert.ToInt32(Session["Userid"]));
            //return RedirectToAction("MySubscribes", "User");*/
            return View();
        }
      
    }
}
