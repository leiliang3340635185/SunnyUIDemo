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

    /// <summary>
    /// 窗体按钮业务层类
    /// </summary>
    public class FormButtonsBLL : IFormButtonsBLL
    {
        private IFormButtonsDAL dal = new FormButtonsDAL();
        public base_form_buttons GetEntity(string buttonId)
        {
            return dal.GetEntity(buttonId);
        }

        public IEnumerable<base_form_buttons> GetList()
        {
            return dal.GetList();
        }

        public DataTable GetTable()
        {
            return dal.GetTable();
        }
        public int Add(base_form_buttons entity)
        {
            return dal.Add(entity);
        }
        public int Update(base_form_buttons entity)
        {
            return dal.Update(entity);
        }

      

        public int Delete(string userId)
        {
            return dal.Delete(userId);
        }
    }
}
