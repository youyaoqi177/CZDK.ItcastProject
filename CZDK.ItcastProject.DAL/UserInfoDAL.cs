using CZDK.ItcastProject.Model;
using System;
using System.Collections.Generic;
using System.Data;

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
