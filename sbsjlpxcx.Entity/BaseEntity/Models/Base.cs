using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sbsjlpxcx.Entity.BaseEntity.Models
{
    public class Base
    {

        /// <summary>
        /// 主键
        /// </summary>
        [Key]
        public long ID { get; set; }

    }
}
