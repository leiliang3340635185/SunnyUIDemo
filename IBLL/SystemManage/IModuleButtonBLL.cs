using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IBLL
{
    /// <summary>
    /// 菜单按钮业务层接口
    /// </summary>
    public interface IModuleButtonBLL
    {
        DataTable GetTable();
        base_module_button GetEntity(string menuButtonId);
        IEnumerable<base_module_button> GetList(Expression<Func<base_module_button, bool>> condition);
        IEnumerable<base_module_button> GetList();
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="entity"></param>
        int Add(base_module_button entity);
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="entity"></param>
        int Update(base_module_button entity);
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="entity"></param>
        int Delete(base_module_button entity);
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="menuButtonId"></param>
        int Delete(string menuButtonId);
        /// <summary>
        /// 保存菜单按钮
        /// </summary>
        /// <param name="status"></param>
        /// <param name="dt"></param>
        /// <param name="menuId"></param>
        void Save(string status, DataTable dt, string menuId);


    }
}
