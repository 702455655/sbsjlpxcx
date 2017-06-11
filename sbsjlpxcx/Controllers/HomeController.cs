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
        public ActionResult GetUser(Sys_UserParms parms)
        {
            parms.PageIndex = 1;
            parms.PageSize = 10;
            return Json(new Sys_UserBLL().GetSys_UserList(parms));
        }

    }
}