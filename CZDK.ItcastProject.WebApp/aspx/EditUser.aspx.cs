using CZDK.ItcastProject.BLL;
using CZDK.ItcastProject.Model;
using System;

namespace CZDK.ItcastProject.WebApp.aspx
{
    public partial class EditUser : System.Web.UI.Page
    {
        UserInfoService service = new UserInfoService();
        public UserInfo Info { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["uid"];

            Info = service.GetUserInfo(Convert.ToInt32(id));

            //判断是否是post表单提交的数据
            if (IsPostBack)
            {
                EditInfo();
            }
        }

        //编辑
        protected void EditInfo()
        {
            UserInfo newInfo = new UserInfo()
            {
                UserName = Request.Form["txtName"],
                UserPass = Request.Form["txtPwd"],
                Email = Request.Form["txtEmail"],
                RegTime = DateTime.Now,
                Id = Convert.ToInt32(Request.Form["txtId"])
            };

            if (service.EditUserInfo(newInfo))
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
