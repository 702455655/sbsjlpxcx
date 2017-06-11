using sbsjlpxcx.Entity._01_Models;
using sbsjlpxcx.Entity._02_Parms;
using sbsjlpxcx.IService;
using sbsjlpxcx.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sbsjlpxcx.Busines
{
   public class Sys_UserBLL
    {
        Sys_UserIService sys_User;
        public List<Sys_User> GetSys_UserList(Sys_UserParms parms)
        {
            return sys_User.GetSys_UserList(parms);
        }
    }
}
