using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBLL
{
    /// <summary>
    /// 角色业务层接口
    /// </summary>
    public interface IRoleBLL
    {
        /// <summary>
        /// 查询
        /// </summary>
        /// <returns></returns>
        DataTable GetTable();
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>

        DataTable GetTable(base_role query);
        /// <summary>
        /// 模糊查询
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        IEnumerable<base_role> GetListLike(base_role query);
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="menuId"></param>
        /// <returns></returns>
        base_role GetEntity(string menuId);
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="entity"></param>
        int Add(base_role entity);
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="entity"></param>
        int Update(base_role entity);
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="entity"></param>
        int Delete(base_role entity);
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="roleid"></param>
        int Delete(string roleid);
        /// <summary>
        /// 验证角色编号是否唯一
        /// </summary>
        /// <param name="status">1新增2修改</param>
        /// <param name="oldEnode">旧角色编号</param>
        /// <param name="newEncode">新角色编号</param>      
        bool VerifyEncode(string status, string oldEnode, string newEncode);
        /// <summary>
        /// 验证角色名称是否唯一
        /// </summary>
        /// <param name="status">1新增2修改</param>
        /// <param name="oldEnode">旧角色名称</param>
        /// <param name="newEncode">新角色名称</param>      
        bool VerifyFullName(string status, string oldFullName, string newFullName);
    }
}
