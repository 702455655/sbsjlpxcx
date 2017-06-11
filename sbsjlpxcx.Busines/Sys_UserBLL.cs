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
        /// <summary>
        /// 获取单个用户
        /// </summary>
        /// <param name="parms"></param>
        /// <returns></returns>
        public Sys_User GetSys_User(Sys_UserParms parms)
        {
            return new Sys_UserService().GetSys_User(parms);
        }
        /// <summary>
        /// 获取用户列表
        /// </summary>
        /// <param name="parms"></param>
        /// <returns></returns>
        public List<Sys_User> GetSys_UserList(Sys_UserParms parms)
        {
            return new Sys_UserService().GetSys_UserList(parms);
        }
        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="parms"></param>
        /// <returns></returns>
        public bool Insert(Sys_User parms)
        {
            return new Sys_UserService().Insert(parms)>0;
        }
    }
}
