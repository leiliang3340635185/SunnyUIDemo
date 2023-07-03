using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBLL
{
    /// <summary>
    /// 窗体按钮业务层接口
    /// </summary>
    public interface IFormButtonsBLL
    {
        base_form_buttons GetEntity(string buttonId);
        DataTable GetTable();
        IEnumerable<base_form_buttons> GetList();
        int Add(base_form_buttons entity);
        int Update(base_form_buttons entity);
        int Delete(string userId);
    }
}
