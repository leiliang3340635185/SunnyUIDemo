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
    /// 菜单按钮数据访问层类
    /// </summary>
    public class ModuleButtonDAL : IModuleButtonDAL
    {
        private SqlSugarClient db;
        public ModuleButtonDAL()
        {
            db = SqlsugarHelper.Instance;
        }
        public base_module_button GetEntity(string menuButtonId)
        {
            return db.Queryable<base_module_button>().AS(typeof(base_module_button).Name).InSingle(menuButtonId);
        }
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="entity"></param>
        public int Add(base_module_button entity)
        {
            return db.Insertable<base_module_button>(entity).ExecuteCommand();
        }
        /// <summary>
        /// 批量添加
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public int AddBatch(List<base_module_button> list)
        {
           return  db.Insertable<base_module_button>(list).ExecuteCommand();
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="entity"></param>
        public int Update(base_module_button entity)
        {
            return db.Updateable<base_module_button>(entity).ExecuteCommand();
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public int Delete(base_module_button entity)
        {
            return db.Deleteable<base_module_button>(entity).ExecuteCommand();
        }
        public int DeleteCondition(Expression<Func<base_module_button,bool>> condition)
        {
            return db.Deleteable<base_module_button>(condition).ExecuteCommand();
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="menuButtonId"></param>
        /// <returns></returns>
        public int Delete(string menuButtonId)
        {
            
            return db.Deleteable<base_module_button>(menuButtonId).ExecuteCommand();
        }
        public DataTable GetTable()
        {
            string sql = "select * from base_module_button";
            List<SugarParameter> param = new List<SugarParameter>();
            DataTable dt = SqlsugarHelper.Init(SqlSugar.DbType.MySql).Query(sql, param);
            return dt;
        }
        public IEnumerable<base_module_button> GetList(Expression<Func<base_module_button, bool>> condition)
        {
            return db.Queryable<base_module_button>().Where(condition).ToList();
        }

        public IEnumerable<base_module_button> GetList()
        {
            return db.Queryable<base_module_button>().ToList();
        }
    }
}
