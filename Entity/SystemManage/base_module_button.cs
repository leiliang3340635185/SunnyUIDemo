using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    ///<summary>
    ///按钮表
    ///</summary>
    public partial class base_module_button
    {
        public base_module_button()
        {


        }
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
        /// Desc:按钮ID
        /// Default:
        /// Nullable:False
        /// </summary>           
        public string modulebuttonid { get; set; }

        /// <summary>
        /// Desc:菜单ID
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string moduleid { get; set; }

        /// <summary>
        /// Desc:父按钮ID
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string parentid { get; set; }

        /// <summary>
        /// Desc:排序码
        /// Default:
        /// Nullable:True
        /// </summary>           
        public int? sortcode { get; set; }

        /// <summary>
        /// Desc:创建者
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string create_by { get; set; }

        /// <summary>
        /// Desc:更新者
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string update_by { get; set; }

        /// <summary>
        /// Desc:创建时间
        /// Default:
        /// Nullable:True
        /// </summary>           
        public DateTime? create_time { get; set; }

        /// <summary>
        /// Desc:更新时间
        /// Default:
        /// Nullable:True
        /// </summary>           
        public DateTime? update_time { get; set; }

    }
}
