using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using System.IO;
using System.Web.UI;
using System.Data.OleDb;
using System.Data;
using System.Web;

namespace Common.Tools
{
    public class SourceIO
    {
        /// <summary>
        /// MD5加密方式
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string MD5(string str)
        {
            lock (typeof(SourceIO))
            {
                byte[] b = System.Text.Encoding.GetEncoding(1252).GetBytes(str);
                b = new System.Security.Cryptography.MD5CryptoServiceProvider().ComputeHash(b);
                string ret = "";
                for (int i = 0; i < b.Length; i++)
                    ret += b[i].ToString("x").PadLeft(2, '0');
                return ret;
            }
        }

        /// <summary>
        ///  这个方法的作用是替换掉敏感词语
        /// </summary>
        /// <param name="source">验证源</param>
        /// <returns>结果</returns>
        public static string ValidateMC(string source)
        {
            string[] mingGan = new string[] { "法论功", "藏独", "台独" };
            foreach (string t in mingGan)
            {
                Regex regex = new Regex(t);
                source = regex.Replace(source, new MatchEvaluator(outPrintMatch));//调用委托开始验证
            }
            return source;
        }

        /// <summary>
        /// 定义一个委托用于检验是否使用了敏感字
        /// </summary>
        /// <param name="match">操作过程中的单个正则表达式</param>
        /// <returns></returns>
        private static string outPrintMatch(Match match)
        {
            string temp = "";
            for (int i = 0; i < match.Value.Length; i++)//将敏感字替换掉
            {
                temp = temp + "*";
            }
            return temp;
        }




        /// <summary>
        /// 对文本单向加密
        /// </summary>
        /// <param name="sourceText">原始字符串</param>
        /// <param name="expandText">文本后缀（按需添加）</param>
        /// <returns>加密后的文本</returns>
        public static string GetSingleDicCipherText(string sourceText, string expandText)
        {
            //1:将文本转换为byte[]
            byte[] sourceArr = Encoding.UTF8.GetBytes(sourceText + expandText);
            //2:创建数据加密类(两种)
            MD5CryptoServiceProvider cryptoProvider = new MD5CryptoServiceProvider();
            // SHA1CryptoServiceProvider cryptoProvider = new SHA1CryptoServiceProvider();

            //3:调用加密类方法加密
            byte[] resultArr = cryptoProvider.ComputeHash(sourceArr);
            //4:将加密后的数组转换回字符串
            return Convert.ToBase64String(resultArr);


        }

        /// <summary>
        /// 文本的加密解密操作
        /// </summary>
        /// <param name="sourceText">待处理文本</param>
        /// <param name="keyCode">密钥</param>
        /// <param name="oprateType">加密或解密</param>
        /// <returns>处理后文本</returns>
        public static string Ciphertext(string sourceText, string keyCode, OperateDirection oprateType)
        {
            byte[] sourceArr;//存放待加密数据
            byte[] resultArr;//存放加密后的数据
            DESCryptoServiceProvider descProvider;//加密操作类
            CryptoStream cs;//加密操作流
            MemoryStream ms;//内存中转流(用于临时存放转换后的结果)

            //1:将待加密数据放入byte数组
            if (oprateType == OperateDirection.encrypt)
            {
                //注意：该处编码方式必须和输出的编码方法一致
                sourceArr = Encoding.ASCII.GetBytes(sourceText);
            }
            else
            {
                sourceArr = Convert.FromBase64String(sourceText);
            }

            //2:创建加密操作对象
            descProvider = new DESCryptoServiceProvider();
            descProvider.Key = Encoding.ASCII.GetBytes(keyCode.Substring(0, 8));//设置密钥(只能64位)
            descProvider.IV = Encoding.ASCII.GetBytes(keyCode.Substring(0, 8)); //设置偏移量
            ICryptoTransform transObj;
            switch (oprateType)
            {
                case OperateDirection.encrypt://加密
                    transObj = descProvider.CreateEncryptor();
                    break;
                case OperateDirection.decrypt://解密
                    transObj = descProvider.CreateDecryptor();
                    break;
                default:
                    throw new Exception("加密对象创建错误！");
            }

            //3:创建两个操作流对象
            using (ms = new MemoryStream())
            {
                using (cs = new CryptoStream(ms, transObj, CryptoStreamMode.Write))
                {
                    //4:进行具体加密操作
                    cs.Write(sourceArr, 0, sourceArr.Length);
                    cs.FlushFinalBlock();
                }
                //5:将加密后的结果转换到byte数组
                resultArr = ms.ToArray();
            }

            if (oprateType == OperateDirection.encrypt)
            {
                return Convert.ToBase64String(resultArr);
            }
            else
            {
                return Encoding.ASCII.GetString(resultArr);
            }

        }

        /// <summary>
        /// 将Excel文件写成视图状态
        /// </summary>
        /// <param name="Path">文件路径</param>
        /// <returns></returns>
        ////public static DataView ExcelToDataView(string Path)
        //{
        //    lock (typeof(SourceIO))//将文件锁定
        //    {
        //        System.Web.UI.Page p = new Page();
        //        string strConn = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + Path + ";Extended Properties=Excel 4.0;";
        //        //根据后缀判断
        //        string exName = Path.Substring(Path.LastIndexOf("."));
        //        if (exName.ToLower().Trim() == ".xlsx")
        //        {
        //            strConn = "Provider=Microsoft.Jet.OLEDB.12.0;" + "Data Source=" + Path + ";Extended Properties=Excel 12.0;";
        //        }
        //        OleDbConnection conn = new OleDbConnection(strConn);
        //        conn.Open();
        //        string strExcel = "";
        //        OleDbDataAdapter myCommand = null;
        //        DataSet ds = null;
        //        strExcel = "select * from [sheet1$]";//Excel页名类似表名
        //        myCommand = new OleDbDataAdapter(strExcel, strConn);
        //        ds = new DataSet();
        //        myCommand.Fill(ds);
        //        conn.Close();
        //        return ds.Tables[0].DefaultView;
        //    }
        //}
        /// <summary>
        /// 去除html标签
        /// </summary>
        /// <param name="Htmlstring"></param>
        /// <returns></returns>
        //public static string NoHTML(string Htmlstring) //去除HTML标记
        //{
        //    //删除脚本
        //    Htmlstring = Regex.Replace(Htmlstring, @"<script[^>]*?>.*?</script>", "", RegexOptions.IgnoreCase);
        //    //删除HTML
        //    Htmlstring = Regex.Replace(Htmlstring, @"<(.[^>]*)>", "", RegexOptions.IgnoreCase);
        //    Htmlstring = Regex.Replace(Htmlstring, @"([\r\n])[\s]+", "", RegexOptions.IgnoreCase);
        //    Htmlstring = Regex.Replace(Htmlstring, @"-->", "", RegexOptions.IgnoreCase);
        //    Htmlstring = Regex.Replace(Htmlstring, @"<!--.*", "", RegexOptions.IgnoreCase);

        //    Htmlstring = Regex.Replace(Htmlstring, @"&(quot|#34);", "\"", RegexOptions.IgnoreCase);
        //    Htmlstring = Regex.Replace(Htmlstring, @"&(amp|#38);", "&", RegexOptions.IgnoreCase);
        //    Htmlstring = Regex.Replace(Htmlstring, @"&(lt|#60);", "<", RegexOptions.IgnoreCase);
        //    Htmlstring = Regex.Replace(Htmlstring, @"&(gt|#62);", ">", RegexOptions.IgnoreCase);
        //    Htmlstring = Regex.Replace(Htmlstring, @"&(nbsp|#160);", " ", RegexOptions.IgnoreCase);
        //    Htmlstring = Regex.Replace(Htmlstring, @"&(iexcl|#161);", "\xa1", RegexOptions.IgnoreCase);
        //    Htmlstring = Regex.Replace(Htmlstring, @"&(cent|#162);", "\xa2", RegexOptions.IgnoreCase);
        //    Htmlstring = Regex.Replace(Htmlstring, @"&(pound|#163);", "\xa3", RegexOptions.IgnoreCase);
        //    Htmlstring = Regex.Replace(Htmlstring, @"&(copy|#169);", "\xa9", RegexOptions.IgnoreCase);
        //    Htmlstring = Regex.Replace(Htmlstring, @"&#(\d+);", "", RegexOptions.IgnoreCase);

        //    Htmlstring.Replace("<", "");
        //    Htmlstring.Replace(">", "");
        //    Htmlstring.Replace("\r\n", "");
        //    Htmlstring = HttpContext.Current.Server.HtmlEncode(Htmlstring).Trim();

        //    return Htmlstring;
        //}

    }

    /// <summary>
    /// 加密操作方向
    /// </summary>
    public enum OperateDirection
    {
        /// <summary>
        /// 加密
        /// </summary>
        encrypt,
        /// <summary>
        /// 解密
        /// </summary>
        decrypt

    }
}
