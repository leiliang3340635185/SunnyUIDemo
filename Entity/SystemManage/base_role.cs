using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    ///<summary>
    ///角色表
    ///</summary>
    public partial class base_role
    {
        public base_role()
        {


        }
        /// <summary>
        /// Desc:角色编号
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string encode { get; set; }
        /// <summary>
        /// Desc:角色名称
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string fullname { get; set; }

        /// <summary>
        /// Desc:角色描述
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string description { get; set; }

        /// <summary>
        /// Desc:删除标记
        /// Default:0
        /// Nullable:True
        /// </summary>           
        public int? delete_mark { get; set; }

        /// <summary>
        /// Desc:创建者
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string create_by { get; set; }

        /// <summary>
        /// Desc:创建时间
        /// Default:
        /// Nullable:True
        /// </summary>           
        public DateTime? create_time { get; set; }

        /// <summary>
        /// Desc:更新者
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string update_by { get; set; }

        /// <summary>
        /// Desc:角色ID
        /// Default:
        /// Nullable:False
        /// </summary>           
        public string roleid { get; set; }

        /// <summary>
        /// Desc:更新时间
        /// Default:
        /// Nullable:True
        /// </summary>           
        public DateTime? update_time { get; set; }

       

    }
}
