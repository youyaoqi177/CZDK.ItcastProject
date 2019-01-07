using CZDK.ItcastProject.BLL;
using CZDK.ItcastProject.Model;
using System.IO;
using System.Web;

namespace CZDK.ItcastProject.WebApp
{
    /// <summary>
    /// 显示用户信息
    /// </summary>
    public class ShowDetail : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            int id;
            if (int.TryParse(context.Request.QueryString["uid"], out id))
            {
                UserInfoService service = new UserInfoService();
                UserInfo userinfo = service.GetUserInfo(id);
                if (userinfo != null)
                {
                    string path = context.Request.MapPath("Detail.html");
                    string filestring = File.ReadAllText(path);
                    filestring = filestring.Replace("@user", userinfo.UserName);
                    filestring = filestring.Replace("@pwd", userinfo.UserPass);
                    context.Response.Write(filestring);
                }
                else
                {
                    context.Response.Redirect("Error.html");
                }
            }
            else
            {
                context.Response.Write("参数错误！");
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
