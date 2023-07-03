using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    /// <summary>
    /// 菜单标记类
    /// </summary>
    public class MenuTag
    {
        /// <summary>
        /// 菜单类型
        /// </summary>
        public MenuType MType { get; set; }
        /// <summary>
        /// 菜单ID
        /// </summary>
        public string MenuId { get; set; }
        /// <summary>
        /// 菜单编码
        /// </summary>
        public string EnCode { get; set; }
        /// <summary>
        /// 菜单名称
        /// </summary>
        public string FullName { get; set; }
        /// <summary>
        /// 窗体全类名
        /// </summary>
        public string FormName { get; set; }
        /// <summary>
        /// 页面索引
        /// </summary>
        public int PageIndex { get; set; }
    }
}
