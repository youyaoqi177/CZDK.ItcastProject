using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace CZDK.ItcastProject.DAL
{
    public class SqlHelper
    {
        //读取连接字符串
        private static readonly string conStr = ConfigurationManager.ConnectionStrings["sqlCon"].ConnectionString;

        /// <summary>
        /// 查询数据库数据得到datatable
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="type"></param>
        /// <param name="pars"></param>
        /// <returns></returns>
        public static DataTable GetDataTable(string sql, CommandType type, params SqlParameter[] pars)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(conStr))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(sql, connection))
                {
                    if (pars != null)
                    {
                        adapter.SelectCommand.Parameters.AddRange(pars);
                    }
                    adapter.SelectCommand.CommandType = type;
                    adapter.Fill(dt);
                    return dt;
                }
            }

        }

        /// <summary>
        /// 返回受影响行数的方法
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="type"></param>
        /// <param name="pars"></param>
        /// <returns></returns>
        public static int ExecuteNonquery(string sql, CommandType type, params SqlParameter[] pars)
        {
            using (SqlConnection connection = new SqlConnection(conStr))
            {
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    if (pars != null)
                    {
                        command.Parameters.AddRange(pars);
                    }
                    command.CommandType = type;
                    connection.Open();
                    return command.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// 查询结果单行
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="type"></param>
        /// <param name="pars"></param>
        /// <returns></returns>
        public static object ExcuteScalar(string sql, CommandType type, params SqlParameter[] pars)
        {
            using (SqlConnection connection = new SqlConnection(conStr))
            {
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    if (pars != null)
                    {
                        command.Parameters.AddRange(pars);
                    }
                    command.CommandType = type;
                    connection.Open();
                    return command.ExecuteScalar();
                }
            }
        }
    }
}
