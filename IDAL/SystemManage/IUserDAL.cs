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
    /// 用户数据库层接口
    /// </summary>
    public interface IUserDAL
    {
        base_user GetEntity(string userId);

        DataTable GetTable();
        DataTable GetTable(base_user entity);
        IEnumerable<base_user> GetList();
        IEnumerable<base_user> GetList(Expression<Func<base_user, bool>> condition, string orderby = "create_time");

        IEnumerable<base_user> GetListLike(base_user query);
        int Add(base_user entity);
        int Update(base_user entity);

        int Delete(base_user entity);
        int Delete(string userId);
       
    }
}
