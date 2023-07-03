using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBLL
{
    public interface IModuleBLL
    {
        DataTable GetTable();
        base_module GetEntity(string menuId);
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="entity"></param>
        int Add(base_module entity);
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="entity"></param>
        int Update(base_module entity);
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="entity"></param>
        int Delete(base_module entity);
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="moduleid"></param>
        int Delete(string moduleid);
        /// <summary>
        /// 验证菜单编号是否唯一
        /// </summary>
        /// <param name="status">1新增2修改</param>
        /// <param name="oldEnode">旧菜单编号</param>
        /// <param name="newEncode">新菜单编号</param>      
        bool VerifyEncode(string status, string oldEncode, string newEncode);

        /// <summary>
        /// 验证菜单名称是否唯一
        /// </summary>
        /// <param name="status">1新增2修改</param>
        /// <param name="oldEnode">旧角色名称</param>
        /// <param name="newEncode">新角色名称</param>      
        bool VerifyFullName(string status, string oldFullName, string newFullName);
       
    }
}
