using CZDK.ItcastProject.BLL;
using CZDK.ItcastProject.Model;
using System;
using System.Web;

namespace CZDK.ItcastProject.WebApp
{
    /// <summary>
    /// 编辑用户
    /// </summary>
    public class EditUser : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            UserInfo userinfo = new UserInfo()
            {
                Id = Convert.ToInt32(context.Request.Form["txtId"]),
                UserName = context.Request.Form["txtName"],
                UserPass = context.Request.Form["txtPwd"],
                Email = context.Request.Form["txtEmail"],
                RegTime = DateTime.Now

            };

            UserInfoService service = new UserInfoService();
            if (service.EditUserInfo(userinfo))
            {
                context.Response.Redirect("UserInfoList.ashx");
            }
            else
            {
                context.Response.Redirect("Error.html");
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
