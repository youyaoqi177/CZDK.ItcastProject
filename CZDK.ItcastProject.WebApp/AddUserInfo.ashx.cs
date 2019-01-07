using CZDK.ItcastProject.BLL;
using CZDK.ItcastProject.Model;
using System;
using System.Web;

namespace CZDK.ItcastProject.WebApp
{
    /// <summary>
    /// 添加用户信息
    /// </summary>
    public class AddUserInfo : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            //接收表单数据
            string userName = context.Request.Form["txtName"];
            string userPwd = context.Request.Form["txtPwd"];
            string emain = context.Request.Form["txtEmail"];
            //创建userinfo对象并赋值
            UserInfo userInfo = new UserInfo()
            {
                UserName = userName,
                UserPass = userPwd,
                Email = emain,
                RegTime = DateTime.Now
            };
            UserInfoService userInfoService = new UserInfoService();
            if (userInfoService.AddUserInfo(userInfo))
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
