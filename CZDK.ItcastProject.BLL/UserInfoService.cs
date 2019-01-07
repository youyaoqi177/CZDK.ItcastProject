using CZDK.ItcastProject.DAL;
using CZDK.ItcastProject.Model;
using System.Collections.Generic;

namespace CZDK.ItcastProject.BLL
{

    public class UserInfoService
    {
        UserInfoDAL userInfoDal = new UserInfoDAL();
        /// <summary>
        /// 查询数据
        /// </summary>
        /// <returns></returns>
        public List<UserInfo> GetList()
        {
            return userInfoDal.GetList();
        }

        /// <summary>
        /// 添加数据
        /// </summary>
        /// <param name="userinfo"></param>
        /// <returns></returns>
        public bool AddUserInfo(UserInfo userinfo)
        {
            return userInfoDal.AddUserInfo(userinfo) > 0;
        }
    }


}
