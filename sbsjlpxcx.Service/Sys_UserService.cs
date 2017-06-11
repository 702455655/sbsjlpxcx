using sbsjlpxcx.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sbsjlpxcx.Entity._01_Models;
using sbsjlpxcx.Dapper;
using sbsjlpxcx.Entity._02_Parms;

namespace sbsjlpxcx.Service
{
    public class Sys_UserService : Sys_UserIService
    {
        public List<Sys_User> GetSys_UserList(Sys_UserParms parms)
        {
           return DapperBase.GetListPaged<Sys_User>(parms.PageIndex,parms.PageSize,"","ID DESC");
        }
    }
}
