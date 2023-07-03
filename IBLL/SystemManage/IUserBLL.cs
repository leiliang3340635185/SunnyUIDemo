using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBLL
{
    public interface IUserBLL
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

        DataTable GetTable(base_user query);
        /// <summary>
        /// 模糊查询
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        IEnumerable<base_user> GetListLike(base_user query);
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="menuId"></param>
        /// <returns></returns>
        base_user GetEntity(string menuId);
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="entity"></param>
        int Add(base_user entity);
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="entity"></param>
        int Update(base_user entity);
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="entity"></param>
        int Delete(base_user entity);
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="moduleid"></param>
        int Delete(string moduleid);
        /// <summary>
        /// 验证账号是否有效
        /// </summary>
        /// <param name="status">1新增2修改</param>
        /// <param name="oldAccount">旧账号</param>
        /// <param name="newAccount">新账号</param>
        bool VerifyAccount(string status, string oldAccount, string newAccount);
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="account">账号</param>
        /// <param name="password">密码</param>
        /// <returns></returns>
        base_user Login(string account, string password);
    }
}
