using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace sbsjlpxcx.Dapper
{
    public class DapperBase
    {
        private static IDbConnection OpenConnection()
        {
            IDbConnection connection = new SqlConnection("connStr"); 
            connection.Open();
            return connection;
        }
         
        public static int? Insert(object obj)
        {
            using (var conn = OpenConnection())
            {
                return conn.Insert(obj);
            }
        }

        public static T GetInfo<T>(object obj)
        {
            using (var conn = OpenConnection())
            {
                return conn.Get<T>(obj);
            }
        }
    }
}
