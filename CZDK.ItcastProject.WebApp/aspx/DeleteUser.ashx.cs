using CZDK.ItcastProject.BLL;
using CZDK.ItcastProject.Model;
using System.Web;

namespace CZDK.ItcastProject.WebApp.aspx
{
    /// <summary>
    /// aspx版的删除功能实现
    /// </summary>
    public class DeleteUser : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            int id;
            if (int.TryParse(context.Request.QueryString["id"], out id))
            {
                UserInfoService service = new UserInfoService();
                UserInfo userInfo = new UserInfo()
                {
                    Id = id
                };
                if (service.DeleteUserInfo(userInfo))
                {
                    context.Response.Redirect("UserInfoList.aspx");
                }
                else
                {
                    context.Response.Redirect("Error.html");
                }
            }
            else
            {
                context.Response.Write("参数错误");
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
