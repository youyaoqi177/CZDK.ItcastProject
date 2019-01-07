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

        /// <summary>
        /// 删除用户数据
        /// </summary>
        /// <param name="userInfo"></param>
        /// <returns></returns>
        public bool DeleteUserInfo(UserInfo userInfo)
        {
            return userInfoDal.DeleteUserInfo(userInfo) > 0;
        }

        /// <summary>
        /// 根据id查询数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public UserInfo GetUserInfo(int id)
        {
            return userInfoDal.GetUserInfo(id);
        }

        public bool EditUserInfo(UserInfo userInfo)
        {
            return userInfoDal.EditUserInfo(userInfo) > 0;
        }
    }


}
