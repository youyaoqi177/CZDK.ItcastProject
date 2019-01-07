using System;
/// <summary>
/// 用户信息实体类
/// </summary>
namespace CZDK.ItcastProject.Model
{
    public class UserInfo
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string UserPass { get; set; }
        public DateTime RegTime { get; set; }
        public string Email { get; set; }
    }
}
