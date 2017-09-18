using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Tools
{
    public class TextHelper
    {
        #region 得到字符串长度，一个汉字长度为2
        /// <summary>
        /// 得到字符串长度，一个汉字长度为2
        /// </summary>
        /// <param name="inputString">参数字符串</param>
        /// <returns></returns>
        public static int StrLength(string inputString)
        {
            System.Text.ASCIIEncoding ascii = new System.Text.ASCIIEncoding();
            int tempLen = 0;
            byte[] s = ascii.GetBytes(inputString);
            for (int i = 0; i < s.Length; i++)
            {
                if ((int)s[i] == 63)
                    tempLen += 2;
                else
                    tempLen += 1;
            }
            return tempLen;
        }
        #endregion

        #region 截取指定长度字符串
        /// <summary>
        /// 截取指定长度字符串
        /// </summary>
        /// <param name="inputString">要处理的字符串</param>
        /// <param name="len">指定长度</param>
        /// <returns>返回处理后的字符串</returns>
        public static string ClipString(string inputString, int len)
        {
            bool isShowFix = false;
            if (len % 2 == 1)
            {
                isShowFix = true;
                len--;
            }
            System.Text.ASCIIEncoding ascii = new System.Text.ASCIIEncoding();
            int tempLen = 0;
            string tempString = "";
            byte[] s = ascii.GetBytes(inputString);
            for (int i = 0; i < s.Length; i++)
            {
                if ((int)s[i] == 63)
                    tempLen += 2;
                else
                    tempLen += 1;

                try
                {
                    tempString += inputString.Substring(i, 1);
                }
                catch
                {
                    break;
                }

                if (tempLen > len)
                    break;
            }

            byte[] mybyte = System.Text.Encoding.Default.GetBytes(inputString);
            if (isShowFix && mybyte.Length > len)
                tempString += "…";
            return tempString;
        }
        #endregion

        /// <summary>
        /// 检查字符串是否存在与一个,组合到一起的字符串数组中
        /// </summary>
        /// <param name="strSplit">未分割的字符串</param>
        /// <param name="split">分割符号</param>
        /// <param name="targetValue">目标字符串</param>
        /// <returns></returns>
        public static bool CheckStringHasValue(string strSplit, char split, string targetValue)
        {
            string[] strList = strSplit.Split(split);
            foreach (string str in strList)
            {
                if (targetValue == str)
                    return true;
            }
            return false;
        }

        /// <summary>
        /// 获取后几位数
        /// </summary>
        /// <param name="str">要截取的字符串</param>
        /// <param name="num">返回的具体位数</param>
        /// <returns>返回结果的字符串</returns>
        public static string GetLastStr(string str, int num)
        {
            int count = 0;
            if (str.Length > num)
            {
                count = str.Length - num;
                str = str.Substring(count, num);
            }
            return str;
        }


        /// <summary>
        /// 转换金额，保留指定小数为，不足补0
        /// </summary>
        /// <param name="money"></param>
        /// <param name="num"></param>
        /// <returns></returns>
        public static decimal GetDoubleMoney(decimal money, int num)
        {
            decimal result = 0;
            if (money > 0)
            {
                string str = money.ToString();
                int index = str.IndexOf(".");
                if (index == -1 || str.Length < index + num + 1)
                {
                    str = string.Format("{0:F" + num + "}", money);
                }
                else
                {
                    int length = index;
                    if (num != 0)
                    {
                        length = index + num + 1;
                    }
                    str = str.Substring(0, length);
                }
                return decimal.Parse(str);
            }
            return result;

        }
    }
}
