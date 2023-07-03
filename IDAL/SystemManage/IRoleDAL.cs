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
    /// 角色数据库层接口
    /// </summary>
    public interface IRoleDAL
    {
        base_role GetEntity(string roleId);

        DataTable GetTable();
        DataTable GetTable(base_role entity);
        IEnumerable<base_role> GetList();
        IEnumerable<base_role> GetList(Expression<Func<base_role, bool>> condition, string orderby = "create_time");

        IEnumerable<base_role> GetListLike(base_role query);
        int Add(base_role entity);
        int Update(base_role entity);

        int Delete(base_role entity);
        int Delete(string roleId);
       
    }
}
