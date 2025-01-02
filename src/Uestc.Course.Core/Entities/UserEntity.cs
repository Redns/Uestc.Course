namespace Uestc.Course.Core.Entities
{
    /// <summary>
    /// 用户实体
    /// </summary>
    public class UserEntity
    {
        #region 账户信息（用户名、注册邮箱、密码、头像、注册时间）
        /// <summary>
        /// ID
        /// </summary>
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// 用户名
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email { get; set; } = string.Empty;

        /// <summary>
        /// 头像
        /// </summary>
        public string Avatar { get; set; } = string.Empty;

        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; } = string.Empty;

        /// <summary>
        /// 注册时间
        /// </summary>
        public DateTime RegisterTime { get; set; } = DateTime.Now;
        #endregion

        #region 权限信息（账户状态、角色、API访问控制、令牌）
        /// <summary>
        /// 账户状态
        /// </summary>
        public UserState State { get; set; } = UserState.Checking;

        /// <summary>
        /// 用户角色
        /// </summary>
        public UserRole Role { get; set; } = UserRole.User;
        #endregion
    }

    /// <summary>
    /// 用户角色
    /// </summary>
    public enum UserRole
    {
        User = 0, // 用户
        System // 系统
    }

    /// <summary>
    /// 账户状态
    /// </summary>
    public enum UserState
    {
        Checking = 0, // 待验证
        Normal, // 正常
        Forbidden // 封禁中
    }
}
