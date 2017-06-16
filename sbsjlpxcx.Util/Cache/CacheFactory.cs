using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sbsjlpxcx.Cache
{
    /// <summary>
    /// 缓存工厂类
    /// </summary>
    public class CacheFactory
    {
        public static ICache Cache()
        {
            return new Cache();
        }
    }
}
