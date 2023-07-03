using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    /// <summary>
    /// 菜单类型
    /// </summary>
    public enum MenuType
    {
        Unknown=0,
        /// <summary>
        /// 模块主菜单
        /// </summary>
        Module=10,
        /// <summary>
        /// 父级菜单
        /// </summary>
        ItemOwner=20,
        /// <summary>
        /// 数据窗体
        /// </summary>
        DataForm=30
    }
}
