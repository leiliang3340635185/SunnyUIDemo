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
    public class ModuleDAL : IModuleDAL
    {
        private SqlSugarClient db;
        public ModuleDAL()
        {

            db = SqlsugarHelper.Instance;
        }
        public base_module GetEntity(string menuId)
        {
            return db.Queryable<base_module>().AS(typeof(base_module).Name).InSingle(menuId);
        }
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="entity"></param>
        public int Add(base_module entity)
        {
            return db.Insertable<base_module>(entity).ExecuteCommand();
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="entity"></param>
        public int Update(base_module entity)
        {
            return db.Updateable<base_module>(entity).ExecuteCommand();
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public int Delete(base_module entity)
        {
            return db.Deleteable<base_module>(entity).ExecuteCommand();
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="moduleid"></param>
        /// <returns></returns>
        public int Delete(string moduleid)
        {
            
            return db.Deleteable<base_module>(moduleid).ExecuteCommand();
        }
        public DataTable GetTable()
        {
            string sql = "select * from base_module";
            List<SugarParameter> param = new List<SugarParameter>();
            DataTable dt = SqlsugarHelper.Init(SqlSugar.DbType.MySql).Query(sql, param);
            return dt;
        }
        public IEnumerable<base_module> GetList(Expression<Func<base_module, bool>> condition)
        {
            return db.Queryable<base_module>().Where(condition).ToList();
        }
    }
}
