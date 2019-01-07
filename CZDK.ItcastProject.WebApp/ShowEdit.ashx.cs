using CZDK.ItcastProject.BLL;
using CZDK.ItcastProject.Model;
using System.IO;
using System.Web;

namespace CZDK.ItcastProject.WebApp
{
    /// <summary>
    /// 编辑用户信息
    /// </summary>
    public class ShowEdit : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            int id;
            if (int.TryParse(context.Request.QueryString["pid"], out id))
            {
                UserInfoService service = new UserInfoService();
                UserInfo user = service.GetUserInfo(id);
                if (user != null)
                {
                    string path = context.Request.MapPath("ShowEditUser.html");
                    string filestring = File.ReadAllText(path);
                    filestring = filestring.Replace("@name", user.UserName);
                    filestring = filestring.Replace("@pwd", user.UserPass);
                    filestring = filestring.Replace("@Id", user.Id.ToString());
                    filestring = filestring.Replace("@Email", user.Email);
                    context.Response.Write(filestring);
                }
                else
                {
                    context.Response.Write("查无此人");
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
