using CZDK.ItcastProject.DAL;
using CZDK.ItcastProject.Model;
using System.Collections.Generic;

namespace CZDK.ItcastProject.BLL
{

    public class UserInfoService
    {
        UserInfoDAL userInfoDal = new UserInfoDAL();

        public List<UserInfo> GetList()
        {
            return userInfoDal.GetList();
        }
    }
}
