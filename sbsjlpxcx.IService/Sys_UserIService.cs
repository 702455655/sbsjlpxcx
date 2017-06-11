using sbsjlpxcx.Entity._01_Models;
using sbsjlpxcx.Entity._02_Parms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sbsjlpxcx.IService
{
    public interface Sys_UserIService
    {
         List<Sys_User> GetSys_UserList(Sys_UserParms parms);
    }
}
