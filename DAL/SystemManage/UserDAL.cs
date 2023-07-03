using Entity;
using IDAL;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    /// <summary>
    /// 用户数据访问层类
    /// </summary>
    public class UserDAL : IUserDAL
    {
        private SqlSugarClient db;
        public UserDAL()
        {
            db = SqlsugarHelper.Instance;
        }
        public base_user GetEntity(string userId)
        {
            return db.Queryable<base_user>().AS(typeof(base_user).Name).InSingle(userId);
        }
        public DataTable GetTable()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from base_user where delete_mark=0 order by create_time desc ");
            List<SugarParameter> param = new List<SugarParameter>();
            DataTable dt = SqlsugarHelper.Init(SqlSugar.DbType.MySql).Query(strSql.ToString(), param);
            return dt;
        }
        public DataTable GetTable(base_user entity)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.AppendFormat(@"select * from base_user where delete_mark=0  ");
            List<SugarParameter> paramList = new List<SugarParameter>();
            if (!string.IsNullOrEmpty(entity.account))
            {
                //strSql.Append(" and account like '%@account%' ");
                strSql.Append(" and account=@account ");
                SugarParameter param = new SugarParameter("@account", entity.account);
                paramList.Add(param);
            }
            if (!string.IsNullOrEmpty(entity.realname))
            {
                //strSql.Append(" and realname like '%@realname%' ");
                strSql.Append(" and realname=@realname ");
                SugarParameter param = new SugarParameter("@realname", entity.realname);
                paramList.Add(param);
            }
            strSql.Append(" order by create_time desc ");
           
            DataTable dt = SqlsugarHelper.Init(SqlSugar.DbType.MySql).Query(strSql.ToString(), paramList);
            return dt;
        }
        public IEnumerable<base_user> GetListLike(base_user query)
        {
            var list = db.Queryable<base_user>().Where(t => t.delete_mark == 0);
            if (!string.IsNullOrEmpty(query.account))
            {
                list = list.Where(t => t.account.Contains(query.account));
            }
            if (!string.IsNullOrEmpty(query.realname))
            {
                list = list.Where(t => t.realname.Contains(query.realname));
            }
            list.OrderBy(" create_time desc ");
            return list.ToList();
        }

        public IEnumerable<base_user> GetList()
        {
            return db.Queryable<base_user>().Where(t=>t.delete_mark==0).ToList();
        }

        public IEnumerable<base_user> GetList(Expression<Func<base_user,bool>> condition,string orderby= "create_time")
        {
            return db.Queryable<base_user>().Where(condition).OrderBy(orderby).ToList();
        }
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="entity"></param>
        public int Add(base_user entity)
        {
            return db.Insertable<base_user>(entity).ExecuteCommand();
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="entity"></param>
        public int Update(base_user entity)
        {
            return db.Updateable<base_user>(entity).ExecuteCommand();
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public int Delete(base_user entity)
        {
            return db.Deleteable<base_user>(entity).ExecuteCommand();
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="moduleid"></param>
        /// <returns></returns>
        public int Delete(string userId)
        {
            
            return db.Deleteable<base_user>(userId).ExecuteCommand();
        }
        
    }
}
