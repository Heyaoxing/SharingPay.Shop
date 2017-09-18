using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Model
{
    /// <summary>
    /// 通用返回实体
    /// </summary>
    public class ResultModel
    {
        /// <summary>
        /// 返回结果
        /// </summary>
        public bool Result { set; get; }

        /// <summary>
        /// 结果信息
        /// </summary>
        public string Message { set; get; } = "";
    }

    /// <summary>
    /// 通用返回实体
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ResultModel<T>
    {
        /// <summary>
        /// 返回结果
        /// </summary>
        public bool Result { set; get; }

        /// <summary>
        /// 结果信息
        /// </summary>
        public string Message { set; get; } = "";
        /// <summary>
        /// 自定义返回信息
        /// </summary>
        public T Data { set; get; }
    }
}
