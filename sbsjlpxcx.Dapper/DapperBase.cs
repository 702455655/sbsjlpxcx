using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Configuration;

namespace sbsjlpxcx.Dapper
{
    public static class DapperBase
    {
        private static IDbConnection OpenConnection()
        {
            string connstr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;//获取界面应用层中的web.config 中<connectionStrings>这个节点里边的connStr，这是一个数据库连接字符串，我们在后边需要用这个字符串来打开数据库连接，让程序和数据库进行数据交互
            IDbConnection connection = new SqlConnection(connstr); 
            connection.Open();
            return connection;
        }
        #region 新增
        /// <summary>
        /// 插入
        /// </summary>
        /// <param name="obj">插入对象</param>
        /// <returns></returns>
        public static int? Insert(object obj)
        {
            using (var conn = OpenConnection())
            {
                return conn.Insert(obj);
            }
        }
        #endregion
        #region 删除
        /// <summary>
        /// 根据ID删除
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Id"></param>
        /// <returns></returns>
        public static int? Delete<T>(int Id)
        {
            using (var conn = OpenConnection())
            {
                return conn.Delete<T>(Id);
            }
        }
        /// <summary>
        /// 根据实体对象删除
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entityToDelete">删除对象实体</param>
        /// <returns></returns>
        public static int? Delete<T>(object obj)
        {
            using (var conn = OpenConnection())
            {
                return conn.Delete<T>(obj);
            }
        }
        /// <summary>
        /// 根据where条件删除
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="conditions"></param>
        /// <returns></returns>
        public static int? DeleteList<T>(string conditions)
        {
            using (var conn = OpenConnection())
            {
                return conn.DeleteList<T>(conditions);
            }
        }
        #endregion
        #region 修改
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="obj">修改对象</param>
        /// <returns></returns>
        public static int? Update(object obj)
        {
            using (var conn = OpenConnection())
            {
                return conn.Update(obj);
            }
        }
        #endregion
        #region 查询
        /// <summary>
        /// 查找单个
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static T GetInfo<T>(object obj)
        {
            using (var conn = OpenConnection())
            {
                return conn.Get<T>(obj);
            }
        }
        /// <summary>
        /// 查询集合
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static List<T> GetList<T>(object obj)
        {
            using (var conn = OpenConnection())
            {
                return conn.GetList<T>(obj).ToList();
            }
        }
        /// <summary>
        /// 分页查询
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="pageNumber">页码</param>
        /// <param name="pageSize">页大小</param>
        /// <param name="conditions">查询条件  where age = 10 or Name like '%Smith%'</param>
        /// <param name="orderby">排序条件  Name desc</param>
        /// <returns></returns>
        public static List<T> GetListPaged<T>(int pageNumber, int pageSize, string conditions, string orderby,ref int totalCount)
        {
            using (var conn = OpenConnection())
            {
                return conn.GetListPaged<T>(pageNumber, pageSize, conditions, orderby,ref totalCount).ToList();
            }
        }
        /// <summary>
        /// 根据条件查询总数
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="conditions"></param>
        /// <returns></returns>
        public static int? RecordCount<T>(string conditions = "")
        {
            using (var conn = OpenConnection())
            {
                return conn.RecordCount<T>(conditions);
            }
        }
        #endregion
    }
}
