using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    /// <summary>
    /// 窗体按钮标记类
    /// </summary>
    public class FormButtonTag
    {
        /// <summary>
        /// 按钮ID
        /// </summary>
        public string FormButtonId { get; set; }
        /// <summary>
        /// 按钮编码
        /// </summary>
        public string EnCode { get; set; }
        /// <summary>
        /// 按钮名称
        /// </summary>
        public string FullName { get; set; }
        /// <summary>
        /// 排序码
        /// </summary>
        public int SortCode { get; set; }
    }
}
