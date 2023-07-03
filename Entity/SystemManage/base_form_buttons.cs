using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    ///<summary>
    ///窗体按钮表
    ///</summary>
    public partial class base_form_buttons
    {
        public base_form_buttons()
        {


        }
        /// <summary>
        /// Desc:创建时间
        /// Default:
        /// Nullable:True
        /// </summary>           
        public DateTime? create_time { get; set; }

        /// <summary>
        /// Desc:按钮编号
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string encode { get; set; }

        /// <summary>
        /// Desc:按钮名称
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string fullname { get; set; }

        /// <summary>
        /// Desc:排序码
        /// Default:
        /// Nullable:True
        /// </summary>           
        public int? sortcode { get; set; }

        /// <summary>
        /// Desc:按钮ID
        /// Default:
        /// Nullable:False
        /// </summary>           
        public string buttonid { get; set; }

        /// <summary>
        /// Desc:创建者
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string create_by { get; set; }

    }
}
