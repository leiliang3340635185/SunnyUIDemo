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
    /// 窗体按钮数据访问层类
    /// </summary>
    public class FormButtonsDAL : IFormButtonsDAL
    {
        private SqlSugarClient db;
        public FormButtonsDAL()
        {
            db = SqlsugarHelper.Instance;
        }
        public base_form_buttons GetEntity(string buttonId)
        {
            return db.Queryable<base_form_buttons>().AS(typeof(base_form_buttons).Name).InSingle(buttonId);
        }
        public DataTable GetTable()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from base_form_buttons  order by sortcode  ");
            List<SugarParameter> param = new List<SugarParameter>();
            DataTable dt = SqlsugarHelper.Init(SqlSugar.DbType.MySql).Query(strSql.ToString(), param);
            return dt;
        }
      
        

        public IEnumerable<base_form_buttons> GetList()
        {
            return db.Queryable<base_form_buttons>().ToList();
        }

     
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="entity"></param>
        public int Add(base_form_buttons entity)
        {
            return db.Insertable<base_form_buttons>(entity).ExecuteCommand();
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="entity"></param>
        public int Update(base_form_buttons entity)
        {
            return db.Updateable<base_form_buttons>(entity).ExecuteCommand();
        }
       
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="moduleid"></param>
        /// <returns></returns>
        public int Delete(string userId)
        {
            
            return db.Deleteable<base_form_buttons>(userId).ExecuteCommand();
        }
        
    }
}
