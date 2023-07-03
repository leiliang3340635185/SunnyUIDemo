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
    public interface IModuleDAL
    {
        base_module GetEntity(string menuId);
        int Add(base_module entity);
        int Update(base_module entity);

        int Delete(base_module entity);
        int Delete(string moduleid);
        DataTable GetTable();
        IEnumerable<base_module> GetList(Expression<Func<base_module, bool>> condition);
    }
}
