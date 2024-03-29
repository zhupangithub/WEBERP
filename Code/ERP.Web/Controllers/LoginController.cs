﻿using System;
using System.Web.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Zephyr.Core;
using ERP.Web.Models;
using Zephyr.Utils;
using ERP.Web;
using ERP.Web.Areas.Mms.Common;

namespace ERP.Web.Controllers
{
    [AllowAnonymous]
    [MvcMenuFilter(false)]
    public class LoginController : Controller
    {
        public ActionResult Index()
        {
            //ViewBag.CnName = "企业管理系统";
            //ViewBag.EnName = "Enterprise Mangange System";
            //return View();
            return Mms();
        }

        public ActionResult Mms()
        {
            ViewBag.CnName = "企业信息管理系统";
            ViewBag.EnName = "Engineering Material Mangange System";
            return View("Index");
        }

        public ActionResult Psi() 
        {
            ViewBag.CnName = "企业进销存管理系统";
            ViewBag.EnName = "Purchase-Sales-Inventory Management System";
            ViewBag.EnNameStyle = "left:298px;";
            return View("Index");
        }

        public JsonResult DoAction(JObject request)
        {
            var message = new sys_userService().Login(request);
            return Json(message, JsonRequestBehavior.DenyGet);
        }

        public ActionResult Logout()
        {
            FormsAuth.SingOut();
            return Redirect("~/Login");
        }
    }
}
