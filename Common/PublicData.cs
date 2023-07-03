using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    /// <summary>
    /// 公共数据类
    /// </summary>
    public class PublicData
    {
        /// <summary>
        /// 公共变量
        /// </summary>
        public class Variable
        {
            /// <summary>
            /// 加密解密秘钥
            /// </summary>
            public static string EncryptKey = "84196123";
            /// <summary>
            /// 是否登录成功
            /// </summary>
            public static bool IsLogin = false;
            /// <summary>
            /// 主窗体引用
            /// </summary>
            public static object mainForm = null;
        }
        /// <summary>
        /// 当前登录用户
        /// </summary>
        public class LoginInfo
        {
            /// <summary>
            /// 用户ID
            /// </summary>
            public static string id = "";
            /// <summary>
            /// 账号
            /// </summary>
            public static string account = "";
            /// <summary>
            /// 姓名
            /// </summary>
            public static string realname = "";
        }
        /// <summary>
        /// 菜单类
        /// </summary>

        public class MenuInfo
        {
            /// <summary>
            /// 0:查看1:新增2:修改3:删除
            /// </summary>
            public static string status = "0";
            /// <summary>
            /// 主键ID
            /// </summary>
            public static string id = "";
        }
        /// <summary>
        /// 用户类
        /// </summary>
        public class UserInfo
        {
            /// <summary>
            /// 0:查看1:新增2:修改3:删除
            /// </summary>
            public static string status = "0";
            /// <summary>
            /// 主键ID
            /// </summary>
            public static string id = "";
        }

        /// <summary>
        /// 角色类
        /// </summary>
        public class RoleInfo
        {
            /// <summary>
            /// 0:查看1:新增2:修改3:删除
            /// </summary>
            public static string status = "0";
            /// <summary>
            /// 主键ID
            /// </summary>
            public static string id = "";
        }
    }
}
