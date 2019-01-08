using CZDK.ItcastProject.BLL;
using CZDK.ItcastProject.Model;
using System;
using System.Collections.Generic;

namespace CZDK.ItcastProject.WebApp.aspx
{
    public partial class UserInfoList : System.Web.UI.Page
    {
        public List<UserInfo> UserList { get; set; }
        UserInfoService service = new UserInfoService();
        protected void Page_Load(object sender, EventArgs e)
        {
            UserList = service.GetList();
        }
    }
}
