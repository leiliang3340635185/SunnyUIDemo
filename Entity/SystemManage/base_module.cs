using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    ///<summary>
    ///菜单
    ///</summary>
    public partial class base_module
    {
        public base_module()
        {


        }
        /// <summary>
        /// Desc:删除标记
        /// Default:0
        /// Nullable:True
        /// </summary>           
        public int? delete_mark { get; set; }

        /// <summary>
        /// Desc:更新者
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string update_by { get; set; }
        /// <summary>
        /// Desc:分类
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string category { get; set; }
        /// <summary>
        /// Desc:分类名称
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string category_name { get; set; }

        /// <summary>
        /// Desc:描述
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string description { get; set; }

        /// <summary>
        /// Desc:更新时间
        /// Default:
        /// Nullable:True
        /// </summary>           
        public DateTime? update_time { get; set; }

        /// <summary>
        /// Desc:菜单编号
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string encode { get; set; }

        /// <summary>
        /// Desc:菜单名称
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string fullname { get; set; }

        /// <summary>
        /// Desc:是否菜单
        /// Default:
        /// Nullable:True
        /// </summary>           
        public int? ismenu { get; set; }

        /// <summary>
        /// Desc:菜单ID
        /// Default:
        /// Nullable:False
        /// </summary>           
        public string moduleid { get; set; }

        /// <summary>
        /// Desc:创建者
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string create_by { get; set; }

        /// <summary>
        /// Desc:父菜单ID
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string parentid { get; set; }

        /// <summary>
        /// Desc:创建时间
        /// Default:
        /// Nullable:True
        /// </summary>           
        public DateTime? create_time { get; set; }

        /// <summary>
        /// Desc:菜单类型
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string target { get; set; }

    }
}
