using DAL;
using Entity;
using IBLL;
using IDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class RoleBLL : IRoleBLL
    {
        private IRoleDAL dal = new RoleDAL();
        
        /// <summary>
        /// 获取DataTable
        /// </summary>
        /// <returns></returns>
        public DataTable GetTable()
        {
            return dal.GetTable();
        }
        public DataTable GetTable(base_role query)
        {
            return dal.GetTable(query);
        }
        public IEnumerable<base_role> GetListLike(base_role query)
        {
            return dal.GetListLike(query);
        }
        /// <summary>
        /// 根据主键获取实体
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public base_role GetEntity(string roleId)
        {
            return dal.GetEntity(roleId);
        }
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="entity"></param>
        public int Add(base_role entity)
        {
            return dal.Add(entity);
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="entity"></param>
        public int Update(base_role entity)
        {
            return dal.Update(entity);
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="entity"></param>
        public int Delete(base_role entity)
        {
            return dal.Delete(entity);
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="roleId"></param>
        public int Delete(string roleId)
        {
            return dal.Delete(roleId);
        }
        /// <summary>
        /// 验证角色编号是否唯一
        /// </summary>
        /// <param name="status">1新增2修改</param>
        /// <param name="oldEnode">旧角色编号</param>
        /// <param name="newEncode">新角色编号</param>      
        public bool VerifyEncode(string status, string oldEnode, string newEncode)
        {
            bool result = true;
            if (status == "1")
            {
                if(dal.GetList(s => s.encode == newEncode).Any())
                {
                    result = false;
                }
            }
            else if (status == "2")
            {
                if(dal.GetList(s=>s.encode == newEncode && s.encode != oldEnode).Any())
                {
                    result = false;
                }
            }
            return result;
        }
        /// <summary>
        /// 验证角色名称是否唯一
        /// </summary>
        /// <param name="status">1新增2修改</param>
        /// <param name="oldEnode">旧角色名称</param>
        /// <param name="newEncode">新角色名称</param>      
        public bool VerifyFullName(string status, string oldFullName, string newFullName)
        {
            bool result = true;
            if (status == "1")
            {
                if (dal.GetList(s => s.fullname == newFullName).Any())
                {
                    result = false;
                }
            }
            else if (status == "2")
            {
                if (dal.GetList(s => s.fullname == newFullName && s.fullname != oldFullName).Any())
                {
                    result = false;
                }
            }
            return result;
        }
    }
}
