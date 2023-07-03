using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    /// <summary>
    /// 授权类型
    /// </summary>
    public enum AuthorizeTypeEnum
    {
        /// <summary>
        /// 角色
        /// </summary>
        [Description("角色")]
        Role=1,
        /// <summary>
        /// 用户
        /// </summary>
        [Description("用户")]
        User =2
    }
}
