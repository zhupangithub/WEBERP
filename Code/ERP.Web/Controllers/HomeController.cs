using System;
using System.Web.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Zephyr.Core;
using ERP.Web.Models;
using ERP.Web;

namespace ERP.Web.Controllers
{
    [MvcMenuFilter(false)]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var loginer = FormsAuth.GetUserData<LoginerBase>();
            ViewBag.Title = "企业信息管理系统";
            ViewBag.UserName = loginer.UserName;
            ViewBag.Settings = new sys_userService().GetCurrentUserSettings();

            return View();
        }
 
        public ActionResult Error() 
        {
            return View();
        }

        public void Download()
        {
            Exporter.Instance().Download();
        }
    }
}
