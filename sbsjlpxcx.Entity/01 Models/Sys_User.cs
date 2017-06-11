using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sbsjlpxcx.Entity._01_Models
{
    [Table("Sys_User")]
    public class Sys_User:ModelBase
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public bool Usertype { get; set; }
    }
}
