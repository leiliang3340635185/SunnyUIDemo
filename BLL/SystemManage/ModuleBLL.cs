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
    public class ModuleBLL : IModuleBLL
    {
        private IModuleDAL dal = new ModuleDAL();
        public DataTable GetTable()
        {
            return dal.GetTable();
        }
        public base_module GetEntity(string menuId)
        {
            return dal.GetEntity(menuId);
        }
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="entity"></param>
        public int Add(base_module entity)
        {
            return dal.Add(entity);
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="entity"></param>
        public int Update(base_module entity)
        {
            return dal.Update(entity);
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="entity"></param>
        public int Delete(base_module entity)
        {
            return dal.Delete(entity);
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="moduleid"></param>
        public int Delete(string moduleid)
        {
            return dal.Delete(moduleid);
        }
        /// <summary>
        /// 验证菜单编号是否唯一
        /// </summary>
        /// <param name="status">1新增2修改</param>
        /// <param name="oldEnode">旧菜单编号</param>
        /// <param name="newEncode">新菜单编号</param>      
        public bool VerifyEncode(string status, string oldEncode, string newEncode)
        {
            bool result = true;
            if (status == "1")
            {
                if (dal.GetList(s => s.encode == newEncode).Any())
                {
                    result = false;
                }
            }
            else if (status == "2")
            {
                if (dal.GetList(s => s.encode == newEncode && s.encode != oldEncode).Any())
                {
                    result = false;
                }
            }
            return result;
        }
        /// <summary>
        /// 验证菜单名称是否唯一
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
