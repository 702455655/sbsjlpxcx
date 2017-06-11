using sbsjlpxcx.Busines;
using System.Web.Mvc;
using sbsjlpxcx.Entity._02_Parms;
using sbsjlpxcx.Entity._01_Models;

namespace sbsjlpxcx.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AnotherLink()
        {
            return View("Index");
        }
        /// <summary>
        /// 只是测试能否拿到数据
        /// </summary>
        /// <param name="parms">前台传回来的参数</param>
        /// <returns></returns>
        public ActionResult GetUser(Sys_UserParms parms)
        {
            parms.PageIndex = 1;
            parms.PageSize = 10;
            return Json(new Sys_UserBLL().GetSys_UserList(parms));
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