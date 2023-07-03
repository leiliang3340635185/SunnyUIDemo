using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    /// <summary>
    /// 数据窗体特性
    /// </summary>
    public class DataFormAttribute:Attribute
    {
        /// <summary>
        /// 窗体描述
        /// </summary>
        public string Description { get; set; }
    }
}
