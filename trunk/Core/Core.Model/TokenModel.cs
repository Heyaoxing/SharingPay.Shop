using MySqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace Core.Model
{

    /// <summary>
    /// 
    /// </summary>
    public class TokenModel
    {
        /// <summary>
        /// Token密文（因前期客户端调用传入该参数，后期以该参数存储Token值）
        /// </summary>
        public string StaffId { get; set; }

        /// <summary>
        /// Token
        /// </summary>
        public string SignToken { get; set; }

        /// <summary>
        /// Token过期时间
        /// </summary>
        public long? ExpireTime { get; set; }

    }

}
