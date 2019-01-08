using CZDK.ItcastProject.BLL;
using CZDK.ItcastProject.Model;
using System;

namespace CZDK.ItcastProject.WebApp.aspx
{
    public partial class AddUserInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //判断表单提交方式是post,表单添加一个隐藏域isPostBack

            //如果隐藏域不为空，表示用户提交了post请求
            if (!string.IsNullOrEmpty(Request.Form["isPostBack"]))
            {
                InsertUserInfo();
            }
        }

        protected void InsertUserInfo()
        {
            UserInfo userInfo = new UserInfo()
            {
                UserName = Request.Form["txtName"],
                UserPass = Request.Form["txtPwd"],
                Email = Request.Form["txtEmail"],
                RegTime = DateTime.Now
            };

            UserInfoService service = new UserInfoService();
            if (service.AddUserInfo(userInfo))
            {
                Response.Redirect("UserInfoList.aspx");
            }
            else
            {
                Response.Redirect("Error.html");
            }
        }
    }
}
