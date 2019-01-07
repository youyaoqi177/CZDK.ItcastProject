using CZDK.ItcastProject.BLL;
using CZDK.ItcastProject.Model;
using System;
using System.Web;

namespace CZDK.ItcastProject.WebApp
{
    /// <summary>
    /// 删除用户信息
    /// </summary>
    public class DeleteUser : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            string idStr = context.Request.QueryString["id"];
            UserInfo userInfo = new UserInfo()
            {
                Id = Convert.ToInt32(idStr)
            };
            UserInfoService service = new UserInfoService();
            if (service.DeleteUserInfo(userInfo))
            {
                context.Response.Redirect("UserInfoList.ashx");
            }
            else
            {
                context.Response.Redirect("Error.ashx");
            }
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
