using CZDK.ItcastProject.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CZDK.ItcastProject.DAL
{
    public class UserInfoDAL
    {
        /// <summary>
        /// 查询数据返回list用户列表
        /// </summary>
        /// <returns></returns>
        public List<UserInfo> GetList()
        {
            string sql = "select * from UserInfo";
            DataTable dt = SqlHelper.GetDataTable(sql, System.Data.CommandType.Text);
            List<UserInfo> list = null;
            if (dt.Rows.Count > 0)
            {
                list = new List<UserInfo>();
                UserInfo userInfo = null;
                foreach (DataRow row in dt.Rows)
                {
                    userInfo = new UserInfo();
                    LoadEntity(userInfo, row);
                    list.Add(userInfo);
                }
            }
            return list;
        }

        /// <summary>
        /// 添加用户信息
        /// </summary>
        /// <param name="userinfo"></param>
        /// <returns></returns>
        public int AddUserInfo(UserInfo userinfo)
        {
            string sqlStr = "insert into UserInfo values(@username,@userpwd,@time,@email)";
            SqlParameter[] pars = {
                   new SqlParameter("@username",SqlDbType.NVarChar,32),
                   new SqlParameter("@userpwd",SqlDbType.NVarChar,32),
                   new SqlParameter("@time",SqlDbType.DateTime),
                   new SqlParameter("@email",SqlDbType.NVarChar,32)
            };
            pars[0].Value = userinfo.UserName;
            pars[1].Value = userinfo.UserPass;
            pars[2].Value = userinfo.RegTime;
            pars[3].Value = userinfo.Email;

            //调用方法 参数CommandType.Text表示sql语句
            return SqlHelper.ExecuteNonquery(sqlStr, CommandType.Text, pars);
        }

        /// <summary>
        /// 删除用户信息
        /// </summary>
        /// <param name="userinfo"></param>
        /// <returns></returns>
        public int DeleteUserInfo(UserInfo userinfo)
        {
            string sqlStr = "delete from UserInfo where ID=@id";
            SqlParameter par = new SqlParameter("@ID", SqlDbType.Int);
            par.Value = userinfo.Id;
            return SqlHelper.ExecuteNonquery(sqlStr, CommandType.Text, par);
        }

        /// <summary>
        /// 将行中数据赋值到userinfo中
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="row"></param>
        private void LoadEntity(UserInfo userInfo, DataRow row)
        {
            userInfo.UserName = row["UserName"] != DBNull.Value ? row["UserName"].ToString() :
                string.Empty;
            userInfo.UserPass = row["UserPass"] != DBNull.Value ? row["UserPass"].ToString() :
                string.Empty;
            userInfo.Email = row["Email"] != DBNull.Value ? row["Email"].ToString() :
                string.Empty;
            userInfo.Id = Convert.ToInt32(row["ID"]);
            userInfo.RegTime = Convert.ToDateTime(row["RegTime"]);
        }
    }
}
