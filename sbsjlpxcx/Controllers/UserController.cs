using sbsjlpxcx.Busines;
using sbsjlpxcx.Entity._01_Models;
using sbsjlpxcx.Entity._02_Parms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sbsjlpxcx.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 只是测试能否拿到数据
        /// </summary>
        /// <param name="parms">前台传回来的参数</param>
        /// <returns></returns>
        public ActionResult GetUser(Sys_UserParms parms)
        {
            int totalCount = 0;
            parms.PageIndex = 1;
            parms.PageSize = 10;
            var re = new Sys_UserBLL().GetSys_UserList(parms, ref totalCount);
            return Json(re);
        }
        public ActionResult AddUser()
        {
            Sys_User user = new Sys_User();
            user.Name = "大傻逼";
            user.Password = "123456";
            user.Usertype = false;
            return Content(new Sys_UserBLL().Insert(user).ToString());

        }

        public ActionResult GetUserInfo(Sys_UserParms parms)
        {
            return Json(new Sys_UserBLL().GetSys_User(parms));
        }
    }
}