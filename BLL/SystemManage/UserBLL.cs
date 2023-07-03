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
    public class UserBLL : IUserBLL
    {
        private IUserDAL dal = new UserDAL();
        
        /// <summary>
        /// 获取DataTable
        /// </summary>
        /// <returns></returns>
        public DataTable GetTable()
        {
            return dal.GetTable();
        }
        public DataTable GetTable(base_user query)
        {
            return dal.GetTable(query);
        }
        public IEnumerable<base_user> GetListLike(base_user query)
        {
            return dal.GetListLike(query);
        }
        /// <summary>
        /// 根据主键获取实体
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public base_user GetEntity(string userId)
        {
            return dal.GetEntity(userId);
        }
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="entity"></param>
        public int Add(base_user entity)
        {
            return dal.Add(entity);
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="entity"></param>
        public int Update(base_user entity)
        {
            return dal.Update(entity);
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="entity"></param>
        public int Delete(base_user entity)
        {
            return dal.Delete(entity);
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="userId"></param>
        public int Delete(string userId)
        {
            return dal.Delete(userId);
        }
        /// <summary>
        /// 验证账号是否有效
        /// </summary>
        /// <param name="status">1新增2修改</param>
        /// <param name="oldAccount">旧账号</param>
        /// <param name="newAccount">新账号</param>
        public bool VerifyAccount(string status,string oldAccount,string newAccount)
        {
            bool result = true;
            if (status == "1")
            {
                if(dal.GetList(s => s.account == newAccount).Any())
                {
                    result = false;
                }
            }
            else if (status == "2")
            {
                if(dal.GetList(s=>s.account==newAccount && s.account != oldAccount).Any())
                {
                    result = false;
                }
            }
            return result;
        }
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="account">账号</param>
        /// <param name="password">密码</param>
        /// <returns></returns>
        public base_user Login(string account,string password)
        {
            base_user entity = dal.GetList(s => s.account == account).FirstOrDefault();
            if (entity != null)
            {
                if (entity.password == password)
                {
                    
                }
                else
                {
                    throw new Exception("密码错误!");
                }
            }
            else
            {
                throw new Exception("账号不存在!");
            }
            return entity;
        }
    }
}
