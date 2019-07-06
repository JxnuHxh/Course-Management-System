
using System.Collections.Generic;
using System;
using System.Web;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using System.Text;
using System.Configuration;


    /// <summary>
    /// Sql数据库操作帮助类
    /// </summary>
    public class DBHelper : IDisposable
    {
        //定义这个类要使用的全局变量
        private static string constr;
        private static SqlConnection conn;
        private static SqlCommand cmd;
        private static SqlDataReader dr;
        private static SqlDataAdapter adapter;


        /// <summary>
        /// 数据库连接属性,连接配置文件的字符串为"ConnectionString"
        /// </summary>
        public static SqlConnection Connectionstrings
        {
            get
            {
                //constr = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
                constr = "Data Source=DESKTOP-BA1PJB9;Initial Catalog=xk;Integrated Security=True";
                //上面这个必须添加引用System.configuartion
                conn = new SqlConnection(constr);
                //DotNet默认打开数据库连接池
                conn.Open();
                return conn;

            }
        }
        // 先做几个处理 ,该类实现了IDisposable接口，自动调用非托管堆中释放资源，在由GC自动清理。
        public void Dispose()
        {
            Close();
            cmd.Dispose();
            dr.Dispose();
            conn.Dispose();
        }

        /// <summary>
        /// 取消 Command 执行，并关闭 DataReader 对象和数据连接
        /// </summary>
        public void Close()
        {
            cmd.Cancel();
            if (!dr.IsClosed)
                dr.Close();
            if (conn.State != ConnectionState.Closed)
                conn.Close();
        }
        /// <summary>
        /// 创建一个 SQL 参数，主要实现SqlParameter[] 参数列表
        /// </summary>
        /// <param name="parameterName">参数名</param>
        /// <param name="dbType">类型</param>
        /// <param name="value">值</param>
        /// <returns>返回创建完成的参数</returns>
        public static SqlParameter CreateParameter(string parameterName, SqlDbType dbType, object value)
        {
            SqlParameter result = new SqlParameter(parameterName, dbType);
            result.Value = value;
            return result;
        }

        /// <summary>
        /// 单向操作，主要用于（增加，删除，修改）,返回受影响的行数
        /// </summary>
        /// <param name="cmdTxt">安全的sql语句（string.format）</param>
        /// <returns></returns>
        public static int GetExcuteNonQuery(string cmdTxt)
        {
            return GetExcuteNonQuery(cmdTxt, null);
        }
        /// <summary>
        /// 带参数化的　主要用于（增加，删除，修改）,返回受影响的行数
        /// </summary>
        /// <param name="cmdTxt">带参数列表的sql语句</param>
        /// <param name="pars">要传入的参数列表</param>
        /// <returns></returns>
        public static int GetExcuteNonQuery(string cmdTxt, params SqlParameter[] pars)
        {
            using (cmd = new SqlCommand(cmdTxt, Connectionstrings))
            {
                if (pars != null)
                    cmd.Parameters.AddRange(pars);
                int result = cmd.ExecuteNonQuery();
                conn.Close();
                return result;
            }
        }

        /// <summary>
        /// 对连接执行 Transact-SQL 语句或者存储过程并返回受影响的行数
        /// </summary>
        /// <param name="cmdText">SQL 语句或者存储过程名称</param>
        /// <param name="pars">参数</param>
        /// <returns>受影响的行数</returns>
        public static int GetExcuteNonQuery(string cmdTxt, CommandType cmdtype, params SqlParameter[] pars)
        {
            using (cmd = new SqlCommand(cmdTxt, Connectionstrings))
            {
                cmd.CommandType = cmdtype;
                cmd.Parameters.AddRange(pars);
                int result = cmd.ExecuteNonQuery();
                conn.Close();
                return result;
            }
        }

        /// <summary>
        /// 执行查询，并返回查询所返回的结果集中第一行的第一列。忽略其他列或行。
        /// </summary>
        /// <typeparam name="T">返回的类型</typeparam>
        /// <param name="cmdText">SQL 语句</param>
        /// <param name="pars">参数列表</param>
        /// <returns>结果集中第一行的第一列或空引用</returns>
        public static T ExecuteScalar<T>(string cmdText, params SqlParameter[] pars)
        {
            using (SqlCommand cmd = new SqlCommand(cmdText, Connectionstrings))
            {
                if (pars != null)
                    cmd.Parameters.AddRange(pars);
                T result = (T)cmd.ExecuteScalar();
                conn.Close();
                return result;
            }
        }
        /// <summary>
        /// 执行查询，并返回查询所返回的结果集中第一行的第一列。忽略其他列或行。
        /// </summary>
        /// <typeparam name="T">参数类型[范型]</typeparam>
        /// <param name="cmdText">sql语句</param>
        /// <returns>返回T类型</returns>
        public static T ExecuteScalar<T>(string cmdText)
        {
            return ExecuteScalar<T>(cmdText, null);
        }
        /// <summary>
        /// 执行查询，并返回查询所返回的结果集中第一行的第一列。忽略其他列或行。
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="cmdTxt">SQL 语句或者存储过程名称</param>
        /// <param name="cmdtype">决定是存储过程还是sql语句</param>
        /// <param name="pars">参数列表</param>
        /// <returns>返回T类型</returns>
        public static T ExecuteScalar<T>(string cmdTxt, CommandType cmdtype, params SqlParameter[] pars)
        {
            using (cmd = new SqlCommand(cmdTxt, Connectionstrings))
            {
                cmd.CommandType = cmdtype;
                cmd.Parameters.AddRange(pars);
                T result = (T)cmd.ExecuteScalar();
                conn.Close();
                return result;
            }
 
        }
        /// <summary>
        /// 将 cmdText 发送到 System.Data.SqlClient.SqlCommand.Connection，并使用 System.Data.CommandBehavior 值之一生成一个 DataReader
        /// </summary>
        /// <param name="cmdTxt">安全的sql语句（string.format）</param>
        /// <returns>一个 DataReader 对象</returns>
        public static SqlDataReader GetDataReader(string cmdTxt)
        {
            return GetDataReader(cmdTxt, null);
        }
        /// <summary>
        /// 将 cmdText 发送到 System.Data.SqlClient.SqlCommand.Connection，并使用 System.Data.CommandBehavior 值之一生成一个 DataReader
        /// </summary>
        /// <param name="cmdTxt">安全的sql语句（string.format）</param>
        /// <param name="pars">参数</param>
        /// <returns>一个 DataReader 对象</returns>
        public static SqlDataReader GetDataReader(string cmdTxt, params SqlParameter[] pars)
        {
            using (cmd = new SqlCommand(cmdTxt, Connectionstrings))
            {
                if (pars != null)
                    cmd.Parameters.AddRange(pars);
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                return dr;
            }
        }
        /// <summary>
        ///  将 cmdText 发送到 System.Data.SqlClient.SqlCommand.Connection，并使用 System.Data.CommandBehavior 值之一生成一个 DataReader
        /// </summary>
        /// <param name="cmdTxt">存储过程名称或者sql语句</param>
        /// <param name="cmdtype">决定是存储过程类型还是sql语句</param>
        /// <param name="pars">参数列表</param>
        /// <returns>返回一个DataReader对象</returns>
        public static SqlDataReader GetDataReader(string cmdTxt, CommandType cmdtype, params SqlParameter[] pars)
        {
            using (cmd = new SqlCommand(cmdTxt, Connectionstrings))
            {
                cmd.CommandType = cmdtype;
                cmd.Parameters.AddRange(pars);
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                return dr;
            }
 
        }
        /// <summary>
        /// 做数据绑定显示作用，一般绑定的是数据查看控件
        /// </summary>
        /// <param name="cmdTxt">sql语句</param>
        /// <param name="tableName">要绑定显示的具体表名</param>
        /// <returns>返回一个数据表</returns>
        public static DataTable GetFillData(string cmdTxt)
        {
            return GetFillData(cmdTxt, null);
        }
        /// <summary>
        /// 做数据绑定显示作用，一般绑定的是数据查看控件
        /// </summary>
        /// <param name="cmdTxt">带参数的sql语句</param>
        /// <param name="pars">参数列表</param>
        /// <returns>返回是一个数据表</returns>

        public static DataTable GetFillData(string cmdTxt, params SqlParameter[] pars)
        {
            DataSet ds = new DataSet();
            using (cmd = new SqlCommand(cmdTxt, Connectionstrings))
            {
                if (pars != null)
                    cmd.Parameters.AddRange(pars);
                using (adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(ds);
                    return ds.Tables[0];
                }
            }
        }
        /// <summary>
        /// 做数据绑定显示作用，一般绑定的是数据查看控件
        /// </summary>
        /// <param name="cmdTxt">存储过程名称或者sql语句</param>
        /// <param name="cmdtype">决定是存储过程类型还是sql语句</param>
        /// <param name="pars">参数列表</param>
        /// <returns>返回一个DataTable</returns>
        public static DataTable GetFillData(string cmdTxt, CommandType cmdtype, params SqlParameter[] pars)
        {
            DataSet ds = new DataSet();
            using (cmd = new SqlCommand(cmdTxt, Connectionstrings))
            {
               cmd.CommandType = cmdtype;
               cmd.Parameters.AddRange(pars);
                using (adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(ds);
                    return ds.Tables[0];
                }
            }
        }

        /// <summary>
        /// 分页数据绑定显示
        /// </summary>
        /// <param name="cmdTxt">string.format格式化sql语句,格式如:"select top {0} * from books where typeid not in (select top {1} id from books order by typeid) order by typeid"总记录数 TotalRecordCount总记录数通过executescalar获取</param>
        /// <param name="pageSize">设置的分页数大小,默认为10</param>
        /// <param name="currentIndex">当前页的索引,通常是通过querystring获取.如:string currentIndex = Request.QueryString["id"] ?? "1"</param>
        /// <returns>返回当前页的数据显示</returns>
        public static DataTable GetFillData(string cmdTxt, int pageSize, int currentIndex)
        {
            DataTable dt = new DataTable();
            using (adapter = new SqlDataAdapter(string.Format(cmdTxt, pageSize, pageSize * (currentIndex - 1)), Connectionstrings))
            {
                adapter.Fill(dt);
            }
            return dt;
        }

    }

