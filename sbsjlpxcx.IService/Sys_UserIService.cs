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
        /// <summary>
        /// 获取用户列表
        /// </summary>
        /// <param name="parms"></param>
        /// <returns></returns>
        List<Sys_User> GetSys_UserList(Sys_UserParms parms, ref int totalCount);
        /// <summary>
        /// 获取单个用户
        /// </summary>
        /// <param name="parms"></param>
        /// <returns></returns>
        Sys_User GetSys_User(Sys_UserParms parms);
        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="parms"></param>
        /// <returns></returns>
        int? Insert(Sys_User parms);
    }
}
