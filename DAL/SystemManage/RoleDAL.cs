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
    /// 角色数据访问层类
    /// </summary>
    public class RoleDAL : IRoleDAL
    {
        private SqlSugarClient db;
        public RoleDAL()
        {
            db = SqlsugarHelper.Instance;
        }
        public base_role GetEntity(string roleId)
        {
            return db.Queryable<base_role>().AS(typeof(base_role).Name).InSingle(roleId);
        }
        public DataTable GetTable()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from base_role where delete_mark=0 order by create_time desc ");
            List<SugarParameter> param = new List<SugarParameter>();
            DataTable dt = SqlsugarHelper.Init(SqlSugar.DbType.MySql).Query(strSql.ToString(), param);
            return dt;
        }
        public DataTable GetTable(base_role entity)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.AppendFormat(@"select * from base_role where delete_mark=0  ");
            List<SugarParameter> paramList = new List<SugarParameter>();
            if (!string.IsNullOrEmpty(entity.encode))
            {
              
                strSql.Append(" and encode=@encode ");
                SugarParameter param = new SugarParameter("@encode", entity.encode);
                paramList.Add(param);
            }
            if (!string.IsNullOrEmpty(entity.fullname))
            {                
                strSql.Append(" and fullname=@fullname ");
                SugarParameter param = new SugarParameter("@fullname", entity.fullname);
                paramList.Add(param);
            }
            strSql.Append(" order by create_time desc ");
           
            DataTable dt = SqlsugarHelper.Init(SqlSugar.DbType.MySql).Query(strSql.ToString(), paramList);
            return dt;
        }
        public IEnumerable<base_role> GetListLike(base_role query)
        {
            var list = db.Queryable<base_role>().Where(t => t.delete_mark == 0);
            if (!string.IsNullOrEmpty(query.encode))
            {
                list = list.Where(t => t.encode.Contains(query.encode));
            }
            if (!string.IsNullOrEmpty(query.fullname))
            {
                list = list.Where(t => t.fullname.Contains(query.fullname));
            }
            list.OrderBy(" create_time desc ");
            return list.ToList();
        }

        public IEnumerable<base_role> GetList()
        {
            return db.Queryable<base_role>().Where(t=>t.delete_mark==0).ToList();
        }

        public IEnumerable<base_role> GetList(Expression<Func<base_role,bool>> condition,string orderby= "create_time")
        {
            return db.Queryable<base_role>().Where(condition).OrderBy(orderby).ToList();
        }
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="entity"></param>
        public int Add(base_role entity)
        {
            return db.Insertable<base_role>(entity).ExecuteCommand();
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="entity"></param>
        public int Update(base_role entity)
        {
            return db.Updateable<base_role>(entity).ExecuteCommand();
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public int Delete(base_role entity)
        {
            return db.Deleteable<base_role>(entity).ExecuteCommand();
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="moduleid"></param>
        /// <returns></returns>
        public int Delete(string roleId)
        {
            
            return db.Deleteable<base_role>(roleId).ExecuteCommand();
        }
        
    }
}
