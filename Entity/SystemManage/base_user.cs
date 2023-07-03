using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    ///<summary>
    ///用户表
    ///</summary>
    public partial class base_user
    {
        public base_user()
        {


        }
        /// <summary>
        /// Desc:密码
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string password { get; set; }

        /// <summary>
        /// Desc:创建时间
        /// Default:
        /// Nullable:True
        /// </summary>           
        public DateTime? create_time { get; set; }

        /// <summary>
        /// Desc:姓名
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string realname { get; set; }

        /// <summary>
        /// Desc:更新者
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string update_by { get; set; }

        /// <summary>
        /// Desc:性别
        /// Default:男 
        /// Nullable:True
        /// </summary>           
        public string gender { get; set; }

        /// <summary>
        /// Desc:更新时间
        /// Default:
        /// Nullable:True
        /// </summary>           
        public DateTime? update_time { get; set; }

        /// <summary>
        /// Desc:出生日期
        /// Default:
        /// Nullable:True
        /// </summary>           
        public DateTime? birthday { get; set; }

        /// <summary>
        /// Desc:邮箱
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string email { get; set; }

        /// <summary>
        /// Desc:角色id
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string roleid { get; set; }

        /// <summary>
        /// Desc:用户ID
        /// Default:
        /// Nullable:False
        /// </summary>           
        public string userid { get; set; }

        /// <summary>
        /// Desc:删除标记
        /// Default:0
        /// Nullable:True
        /// </summary>           
        public int? delete_mark { get; set; }

        /// <summary>
        /// Desc:账号
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string account { get; set; }

        /// <summary>
        /// Desc:创建者
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string create_by { get; set; }

    }
}
