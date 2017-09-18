using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Common.Web
{
    /// <summary>
    /// 订单帮助类
    /// </summary>
    public class OrderHelper
    {
        /// <summary>
        /// 防止创建类的实例
        /// </summary>
        private OrderHelper() { }

        private static readonly object Locker = new object();
        private static int _sn = 0;

        /// <summary>
        /// 生成订单号
        /// 规则
        /// 下单渠道1位+时间信息4位+下单时间的Unix时间戳后8位
        /// （或是这8位数字加上随机码和随机规则进行随机后的数字）+用户user id后4位共计17位
        /// </summary>
        /// <returns></returns>
        public static long CreateOrderId(int payType)
        {

            //用户下单的平台类型
            string platoform = payType.ToString().Substring(0, 1);

            //下单时间戳
            DateTime oldTime = new DateTime(1970, 1, 1, 0, 0, 0, 0);

            //获取时间戳
            TimeSpan ts = DateTime.Now.Subtract(oldTime);

            //精确到毫秒
            double mif = ts.TotalMilliseconds;

            //把带小数的时间戳转成int类型
            long str = Convert.ToInt64(mif);

            //除去时间戳第一位只取后面12位
            string newstr = str.ToString().Substring(1, str.ToString().Length - 1);

            ///取三位随机数
            string extNumber = new Random().Next(100, 999).ToString();

            //拼接成新的16位长度订单号
            string orderId = platoform + "" + extNumber + "" + newstr;

            //返回一个订单号
            return Convert.ToInt64(orderId);
        }
    }
}
