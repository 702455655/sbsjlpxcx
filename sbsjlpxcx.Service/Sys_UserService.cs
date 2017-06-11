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
        /// <summary>
        /// 获取单个用户
        /// </summary>
        /// <param name="parms"></param>
        /// <returns></returns>
        public Sys_User GetSys_User(Sys_UserParms parms)
        {
            return DapperBase.GetInfo<Sys_User>(parms.ID);
        }
        /// <summary>
        /// 获取用户列表
        /// </summary>
        /// <param name="parms"></param>
        /// <returns></returns>
        public List<Sys_User> GetSys_UserList(Sys_UserParms parms)
        {
           return DapperBase.GetListPaged<Sys_User>(parms.PageIndex,parms.PageSize,"","ID DESC");
        }
        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="parms"></param>
        /// <returns></returns>
        public int? Insert(Sys_User parms)
        {
            return DapperBase.Insert(parms);
        }
    }
}
