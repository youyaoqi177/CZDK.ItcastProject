using CZDK.ItcastProject.BLL;
using CZDK.ItcastProject.Model;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Web;

namespace CZDK.ItcastProject.WebApp
{
    /// <summary>
    /// 显示用户列表数据
    /// </summary>
    public class UserInfoList : IHttpHandler
    {
        UserInfoService userInfoService = new UserInfoService();
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            //读取数据
            List<UserInfo> list = userInfoService.GetList();
            StringBuilder sb = new StringBuilder();
            //遍历
            foreach (UserInfo userInfo in list)
            {
                sb.AppendFormat("<tr>");
                sb.AppendFormat("<td>{0}</td>", userInfo.Id);
                sb.AppendFormat("<td>{0}</td>", userInfo.UserName);
                sb.AppendFormat("<td>{0}</td>", userInfo.UserPass);
                sb.AppendFormat("<td>{0}</td>", userInfo.Email);
                sb.AppendFormat("<td>{0}</td>", userInfo.RegTime);
                sb.AppendFormat("</tr>");
            }

            //读取文件
            string path = context.Request.MapPath("UserInfoList.html");
            string fileContext = File.ReadAllText(path);
            fileContext = fileContext.Replace("@table", sb.ToString());
            context.Response.Write(fileContext);

        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}
