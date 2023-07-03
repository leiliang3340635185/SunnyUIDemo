using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IDAL
{
    /// <summary>
    /// 菜单按钮数据访问层接口
    /// </summary>
    public interface IModuleButtonDAL
    {
        base_module_button GetEntity(string menuButtonId);
        int Add(base_module_button entity);
        int AddBatch(List<base_module_button> list);
        int Update(base_module_button entity);
        int DeleteCondition(Expression<Func<base_module_button, bool>> condition);
        int Delete(base_module_button entity);
        int Delete(string moduleid);
        DataTable GetTable();
        IEnumerable<base_module_button> GetList();
        IEnumerable<base_module_button> GetList(Expression<Func<base_module_button, bool>> condition);
    }
}
