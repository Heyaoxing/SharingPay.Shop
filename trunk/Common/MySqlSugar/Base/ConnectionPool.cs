using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MySqlSugar.Base
{
    public class ConnectionPool
    {
        private static ConnectionPool cpool = null;//池管理对象
        private static Object objlock = typeof(ConnectionPool);//池管理对象实例
        private int size = 1;//池中连接数
        private int useCount = 0;//已经使用的连接数
        private ArrayList pool = null;//连接保存的集合
        private string ConnectionStr = string.Empty;//连接字符串

        private int maxSize = 100; //最大链接数量

        public ConnectionPool()
        {
            //数据库连接字符串
            ConnectionStr = System.Configuration.ConfigurationManager.AppSettings[@"MySqlConnection"];
            //创建可用连接的集合
            pool = new ArrayList();
        }

        #region 创建获取连接池对象
        public static ConnectionPool GetPool()
        {
            lock (objlock)
            {
                if (cpool == null)
                {
                    cpool = new ConnectionPool();
                }
                return cpool;
            }
        }
        #endregion

        #region 获取池中的连接
        public MySqlConnection GetConnection()
        {
            lock (pool)
            {
                MySqlConnection tmp = null;
                //可用连接数量大于0
                if (pool.Count > 0)
                {
                    //取第一个可用连接
                    tmp = (MySqlConnection)pool[0];
                    //在可用连接中移除此链接
                    pool.RemoveAt(0);
                    //不成功
                    if (!IsUserful(tmp))
                    {
                        //可用的连接数据已去掉一个
                        useCount--;
                        tmp = GetConnection();
                    }
                }
                else
                {
                    //可使用的连接小于连接数量
                    if (useCount <= size)
                    {
                        try
                        {
                            //创建连接
                            tmp = CreateConnection(tmp);
                        }
                        catch (Exception e)
                        {
                        }
                    }
                }
                //连接为null
                if (tmp == null)
                {
                    //达到最大连接数递归调用获取连接否则创建新连接
                    if (maxSize < useCount)
                    {
                        int i = 5;
                        while (i>0)
                        {
                            i--;

                            //可用连接数量大于0
                            if (pool.Count > 0)
                            {
                                //取第一个可用连接
                                tmp = (MySqlConnection)pool[0];
                                //在可用连接中移除此链接
                                pool.RemoveAt(0);
                                //不成功
                                if (!IsUserful(tmp))
                                {
                                    //可用的连接数据已去掉一个
                                    useCount--;
                                }
                            }

                            if (tmp != null)
                                break;
                            else
                            {
                                Thread.Sleep(200);
                            }
                        }
                    }
                    else if (useCount <= size)
                    {
                        tmp = GetConnection();
                    }
                    else
                    {
                        tmp = CreateConnection(tmp);
                    }
                }
                return tmp;
            }
        }
        #endregion

        #region 创建连接
        private MySqlConnection CreateConnection(MySqlConnection tmp)
        {
            //创建连接
            MySqlConnection conn = new MySqlConnection(ConnectionStr);
            conn.Open();
            //可用的连接数加上一个
            useCount++;
            tmp = conn;
            return tmp;
        }
        #endregion

        #region 关闭连接,加连接回到池中
        public void CloseConnection(MySqlConnection con)
        {
            lock (pool)
            {
                if (con != null)
                {
                    //将连接添加在连接池中
                    pool.Add(con);
                }
            }
        }
        #endregion

        #region 目的保证所创连接成功,测试池中连接
        private bool IsUserful(MySqlConnection con)
        {
            //主要用于不同用户
            bool result = true;
            if (con != null)
            {
                string sql = "select 1";//随便执行对数据库操作
                MySqlCommand cmd = new MySqlCommand(sql, con);
                try
                {
                    cmd.ExecuteScalar().ToString();
                }
                catch
                {
                    result = false;
                }

            }
            return result;
        }
        #endregion
    }
}
