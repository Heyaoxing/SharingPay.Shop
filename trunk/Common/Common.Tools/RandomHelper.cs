using Common.Safety;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Tools
{
    public class RandomHelper
    {

        /// <summary>
        /// 获取推荐码
        /// </summary>
        /// <param name="account"></param>
        /// <returns></returns>
        public static string GetRecommendedCode(string account)
        {
            // 要使用生成URL的字符

            string[] chars = new string[]{
            "0","1","2","3","4","5",
            "6","7","8","9","A","B","C","D",
            "E","F","G","H","I","J","K","L",
            "M","N","O","P","Q","R","S","T",
            "U","V","W","X","Y","Z"
            };

            string hex = MD5EncryptHelper.MD5Encrypt32(account);

            return hex.Substring(0, 6);
        }


        public static List<string> GetRandString(int len, int count)
        {
            double max_value = Math.Pow(36, len);

            long all_count = (long)max_value;
            long stepLong = all_count / count;

            int step = (int)stepLong;

            long begin = 0;
            List<string> list = new List<string>();
            Random rand = new Random();
            while (true)
            {
                long value = rand.Next(1, step) + begin;
                begin += step;
                list.Add(GetChart(len, value));
                if (list.Count == count)
                {
                    break;
                }
            }

            list = SortByRandom(list);

            return list;
        }


        private const string CHAR = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private static string GetChart(int len, long value)
        {
            StringBuilder str = new StringBuilder();
            while (true)
            {
                str.Append(CHAR[(int)(value % 36)]);
                value = value / 36;
                if (str.Length == len)
                {
                    break;
                }
            }
            return str.ToString();
        }

        /// <summary>
        /// 随机排序
        /// </summary>
        /// <param name="charList"></param>
        /// <returns></returns>
        private static List<string> SortByRandom(List<string> charList)
        {
            Random rand = new Random();
            for (int i = 0; i < charList.Count; i++)
            {
                int index = rand.Next(0, charList.Count);
                string temp = charList[i];
                charList[i] = charList[index];
                charList[index] = temp;
            }
            return charList;
        }

    }
}
