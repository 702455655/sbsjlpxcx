using sbsjlpxcx.Busines;
using System.Web.Mvc;
using sbsjlpxcx.Entity._02_Parms;

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

    }
}