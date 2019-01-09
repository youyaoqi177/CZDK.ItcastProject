using CZDK.ItcastProject.DAL;
using CZDK.ItcastProject.Model;
using System;
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

        /// <summary>
        /// 修改用户数据
        /// </summary>
        /// <param name="userInfo"></param>
        /// <returns></returns>
        public bool EditUserInfo(UserInfo userInfo)
        {
            return userInfoDal.EditUserInfo(userInfo) > 0;
        }

        /// <summary>
        /// 计算数据访问，完成分页
        /// </summary>
        /// <param name="pageIndex">当前页码</param>
        /// <param name="pageSize">每页显示记录</param>
        /// <returns></returns>
        public List<UserInfo> GetPageList(int pageIndex, int pageSize)
        {
            int start = (pageIndex - 1) * pageSize + 1;
            int end = pageIndex * pageSize;
            return userInfoDal.GetPageList(start, end);
        }

        /// <summary>
        /// 获取总页数
        /// </summary>
        /// <param name="pageSize">每页显示的记录数</param>
        /// <returns></returns>
        public int GetPageCount(int pageSize)
        {
            int recoredCount = userInfoDal.GetRecordCount();
            int pageCount = Convert.ToInt32(Math.Ceiling((double)recoredCount / pageSize));
            return pageCount;

        }
    }


}
