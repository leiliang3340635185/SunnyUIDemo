using DAL;
using Entity;
using IBLL;
using IDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    /// <summary>
    /// 菜单按钮业务层类
    /// </summary>
    public class ModuleButtonBLL : IModuleButtonBLL
    {
        private IModuleButtonDAL dal = new ModuleButtonDAL();
        public DataTable GetTable()
        {
            return dal.GetTable();
        }
        public IEnumerable<base_module_button> GetList()
        {
            return dal.GetList();
        }

        public IEnumerable<base_module_button> GetList(Expression<Func<base_module_button, bool>> condition)
        {
            return dal.GetList(condition);
        }
        public base_module_button GetEntity(string menuButtonId)
        {
            return dal.GetEntity(menuButtonId);
        }
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="entity"></param>
        public int Add(base_module_button entity)
        {
            return dal.Add(entity);
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="entity"></param>
        public int Update(base_module_button entity)
        {
            return dal.Update(entity);
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="entity"></param>
        public int Delete(base_module_button entity)
        {
            return dal.Delete(entity);
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="menuButtonId"></param>
        public int Delete(string menuButtonId)
        {
            return dal.Delete(menuButtonId);
        }
        /// <summary>
        /// 保存菜单按钮数据
        /// </summary>
        /// <param name="status">1菜单新增2菜单修改</param>
        /// <param name="dt">按钮列表</param>
        /// <param name="menuId">菜单ID</param>
        public void Save(string status,DataTable dt,string menuId)
        {
            try
            {
                if (status == "1")
                {

                }
                else if (status == "2")
                {
                    //删除旧按钮列表
                    base_module_button condition = new base_module_button();
                    condition.moduleid = menuId;
                    int result1 = dal.DeleteCondition(t=>t.moduleid==menuId);
                }
                //添加按钮列表
                List<base_module_button> list = new List<base_module_button>();
                foreach (DataRow dataRow in dt.Rows)
                {
                    base_module_button entity = new base_module_button();
                    entity.modulebuttonid = Guid.NewGuid().ToString().Replace("-", "");
                    entity.moduleid = menuId;
                    entity.encode = dataRow["encode"].ToString();
                    entity.fullname = dataRow["fullname"].ToString();
                    entity.sortcode = int.Parse(dataRow["sortcode"].ToString());
                    entity.create_time = DateTime.Now;
                    list.Add(entity);
                }
                if (list.Count > 0)
                {
                    int result2=dal.AddBatch(list);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
           

        }
    }
}
