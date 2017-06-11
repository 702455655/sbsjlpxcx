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
        public Sys_User GetSys_User(Sys_UserParms parms)
        {
            return DapperBase.GetInfo<Sys_User>(parms.ID);
        }

        public List<Sys_User> GetSys_UserList(Sys_UserParms parms)
        {
           return DapperBase.GetListPaged<Sys_User>(parms.PageIndex,parms.PageSize,"","ID DESC");
        }

        public int? Insert(Sys_User parms)
        {
            return DapperBase.Insert(parms);
        }
    }
}
