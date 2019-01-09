using CZDK.ItcastProject.BLL;
using CZDK.ItcastProject.Model;
using System;
using System.Collections.Generic;

namespace CZDK.ItcastProject.WebApp.aspx
{
    public partial class UserInfoList : System.Web.UI.Page
    {
        public List<UserInfo> UserList { get; set; }
        public int PageCount { get; set; }
        public int pagess { get; set; }
        UserInfoService service = new UserInfoService();
        protected void Page_Load(object sender, EventArgs e)
        {
            int pageSize = 10;
            int PageIndex;
            if (!int.TryParse(Request.QueryString["pageIndex"], out PageIndex))
            {
                PageIndex = 1;
            }
            //获取总页数
            PageCount = service.GetPageCount(pageSize);
            //对当前页码范围进行判断
            PageIndex = PageIndex < 1 ? 1 : PageIndex;
            PageIndex = PageIndex > PageCount ? PageCount : PageIndex;
            pagess = PageIndex;
            //获取分页数据
            UserList = service.GetPageList(PageIndex, pageSize);
        }
    }
}
