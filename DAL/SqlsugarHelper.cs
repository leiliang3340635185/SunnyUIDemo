using Newtonsoft.Json;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SqlsugarHelper
    {

        static string ConnectionString = string.Empty;
        static SqlSugar.DbType dbtype = SqlSugar.DbType.MySql;
        SqlsugarHelper(SqlSugar.DbType dbtype)
        {
            if (dbtype == SqlSugar.DbType.MySql)
            {
                SqlsugarHelper.ConnectionString = GetConnectionString();
            }
            SqlsugarHelper.dbtype = dbtype;
        }
        /// <summary>
        /// 获取解密后的连接字符串
        /// </summary>
        /// <returns></returns>
        private static string GetConnectionString()
        {
            //获取配置文件中的连接字符串           
            string newConnectionString = ConfigurationManager.ConnectionStrings["BaseDb"].ToString();
            return newConnectionString;
        }
        private static SqlsugarHelper _Singleton = null;
        private static object Singleton_Lock = new object();
        public static SqlsugarHelper Init(SqlSugar.DbType dbtype = SqlSugar.DbType.MySql)
        {
            if (_Singleton == null) //双if +lock
            {
                lock (Singleton_Lock)
                {
                    if (_Singleton == null)
                    {
                        //创建对象
                        _Singleton = new SqlsugarHelper(dbtype);

                    }
                }
            }
            SqlsugarHelper.ConnectionString = GetConnectionString();
            return _Singleton;
        }
        /// <summary>
        /// 获取数据库连接实体，禁止使用静态变量对接
        /// </summary>
        public static SqlSugarClient Instance
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(GetConnectionString()))
                {
                    SqlSugarClient db = new SqlSugarClient(new ConnectionConfig()
                    {
                        ConnectionString = GetConnectionString(),
                        DbType = dbtype,//设置数据库类型
                        IsAutoCloseConnection = true,//自动释放数据务，如果存在事务，在事务结束后释放
                        InitKeyType = InitKeyType.SystemTable,//从数据库系统表读取主键信息中（InitKeyType.Attribute从实体特性中读取主键自增列信息）
                    });

                    //  调试SQL，AOP ,日志
                    db.Aop.OnLogExecuted = (sql, pars) => //SQL执行完事件
                    {
#if DEBUG
                        //获取执行后的总毫秒数
                        double sqlExecutionTotalMilliseconds = db.Ado.SqlExecutionTime.TotalMilliseconds;
#endif
                    };
                    db.Aop.OnLogExecuting = (sql, pars) => //SQL执行前事件。可在这里查看生成的sql
                    {
#if DEBUG
                        string tempSQL = LookSQL(sql, pars);
#endif
                    };
                    db.Aop.OnError = (exp) =>//执行SQL 错误事件
                    {
                        //exp.sql exp.parameters 可以拿到参数和错误Sql  
                        StringBuilder sb_SugarParameterStr = new StringBuilder("###SugarParameter参数为:");
                        var parametres = exp.Parametres as SugarParameter[];
                        if (parametres != null)
                        {
                            sb_SugarParameterStr.Append(JsonConvert.SerializeObject(parametres));
                        }

                        StringBuilder sb_error = new StringBuilder();
                        sb_error.AppendLine("SqlSugarClient执行sql异常信息:" + exp.Message);
                        sb_error.AppendLine("###赋值后sql:" + LookSQL(exp.Sql, parametres));
                        sb_error.AppendLine("###带参数的sql:" + exp.Sql);
                        sb_error.AppendLine("###参数信息:" + sb_SugarParameterStr.ToString());
                        sb_error.AppendLine("###StackTrace信息:" + exp.StackTrace);


                    };

                    db.Aop.OnExecutingChangeSql = (sql, pars) => //SQL执行前 可以修改SQL
                    {
                        //判断update或delete方法是否有where条件。如果真的想删除所有数据，请where(p=>true)或where(p=>p.id>0)
                        if (sql.TrimStart().IndexOf("delete ", StringComparison.CurrentCultureIgnoreCase) == 0)
                        {
                            if (sql.IndexOf("where", StringComparison.CurrentCultureIgnoreCase) <= 0)
                            {
                                throw new Exception("delete删除方法需要有where条件！！");
                            }
                        }
                        else if (sql.TrimStart().IndexOf("update ", StringComparison.CurrentCultureIgnoreCase) == 0)
                        {
                            if (sql.IndexOf("where", StringComparison.CurrentCultureIgnoreCase) <= 0)
                            {
                                throw new Exception("update更新方法需要有where条件！！");
                            }
                        }

                        return new KeyValuePair<string, SugarParameter[]>(sql, pars);
                    };

                    //db.Aop.OnDiffLogEvent = it =>// 数据库操作前和操作后的数据变化。
                    //{
                    //    var editBeforeData = it.BeforeData;
                    //    var editAfterData = it.AfterData;
                    //    var sql = it.Sql;
                    //    var parameter = it.Parameters;
                    //    var data = it.BusinessData;
                    //    var time = it.Time;
                    //    var diffType = it.DiffType;//枚举值 insert 、update 和 delete 用来作业务区分

                    //    //你可以在这里面写日志方法
                    //};

                    //db.Ado.CommandTimeOut //设置sql执行超时等待时间(毫秒单位)
                    //db.Ado.Connection.ConnectionTimeout //设置数据库连接等待时间(毫秒单位)

                    return db;
                }
                else
                {
                    return null;
                }

            }
        }

        /// <summary>
        /// 查看赋值后的sql
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="pars">参数</param>
        /// <returns></returns>
        private static string LookSQL(string sql, SugarParameter[] pars)
        {
            if (pars == null || pars.Length == 0) return sql;

            StringBuilder sb_sql = new StringBuilder(sql);
            var tempOrderPars = pars.Where(p => p.Value != null).OrderByDescending(p => p.ParameterName.Length).ToList();//防止 @par1错误替换@par12
            for (var index = 0; index < tempOrderPars.Count; index++)
            {
                sb_sql.Replace(tempOrderPars[index].ParameterName, "'" + tempOrderPars[index].Value.ToString() + "'");
            }

            return sb_sql.ToString();
        }

        #region 获取实体
        /// <summary>
        /// 获取一个实体
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="id">主键</param>
        /// <returns></returns>
        public T GetModel<T>(object id)
        {
            return GetModel<T>(id, SqlsugarHelper.Instance);
        }
        /// <summary>
        /// 获取一个实体
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="id">主键</param>
        /// <param name="TableName">表名称</param>
        /// <returns></returns>
        public T GetModel<T>(object id, string TableName)
        {
            return GetModel<T>(id, TableName, SqlsugarHelper.Instance);
        }
        /// <summary>
        /// 获取多个实体
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="id">主键</param>
        /// <returns></returns>
        public List<T> GetModelList<T>()
        {
            return GetModelList<T>(SqlsugarHelper.Instance);
        }
        /// <summary>
        /// 获取多个实体
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="id">主键</param>
        /// <param name="TableName">表名称</param>
        /// <returns></returns>
        public List<T> GetModelList<T>(string TableName)
        {
            return GetModelList<T>(SqlsugarHelper.Instance, TableName);
        }


        /// <summary>
        /// 获取一个实体
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="id">主键</param>
        /// <param name="db"></param>
        /// <returns></returns>
        public T GetModel<T>(object id, SqlSugarClient db)
        {
            return db.Queryable<T>().InSingle(id);
        }
        /// <summary>
        /// 获取一个实体
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="id">主键</param>
        /// <param name="db"></param>
        /// <returns></returns>
        public T GetModel<T>(object id, string
             TableName, SqlSugarClient db)
        {
            return db.Queryable<T>().AS(TableName).InSingle(id);
        }
        /// <summary>
        /// 获取多个实体
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="id">主键</param>
        /// <param name="db"></param>
        /// <returns></returns>
        public List<T> GetModelList<T>(SqlSugarClient db)
        {
            return db.Queryable<T>().ToList();
        }
        /// <summary>
        /// 获取多个实体
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="id">主键</param>
        /// <param name="db"></param>
        /// <returns></returns>
        public List<T> GetModelList<T>(SqlSugarClient db, string TableName)
        {
            return db.Queryable<T>().AS(TableName).ToList();
        }


        #region 从缓存中获取一个实体
        /// <summary>
        /// 从缓存中获取一个实体
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="id">主键</param>
        /// <returns></returns>
        public T GetModel_WithCache<T>(object id)
        {
            return GetModel_WithCache<T>(id, Instance);
        }

        /// <summary>
        /// 从缓存中获取一个实体
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="id">主键</param>
        /// <param name="db"></param>
        /// <returns></returns>
        public T GetModel_WithCache<T>(object id, SqlSugarClient db)
        {
            return db.Queryable<T>().WithCache().InSingle(id);
        }
        #endregion

        #endregion

        #region 添加
        /// <summary>
        /// 添加实体（实体名称和表名称不一致是使用）
        /// </summary>
        /// <typeparam name="T">实体类型</typeparam>
        /// <param name="t">实体</param>
        /// <param name="TableName">表名称</param>
        /// <returns>返回添加成功条数</returns>
        public int InsertModel<T>(T t, string TableName) where T : class, new()
        {
            return InsertModel(t, TableName, SqlsugarHelper.Instance);
        }
        /// <summary>
        /// 添加实体（实体名称和表名称不一致是使用）
        /// </summary>
        /// <typeparam name="T">实体类型</typeparam>
        /// <param name="t">实体</param>
        /// <param name="TableName">表名称</param>
        /// <param name="db">数据库连接字符串</param>
        /// <returns></returns>
        public int InsertModel<T>(T t, string TableName, SqlSugarClient db) where T : class, new()
        {
            return db.Insertable(t).AS(TableName).ExecuteCommand();
        }
        ///// <summary>
        /////批量数据插入(有则更新无则插入)
        ///// </summary>
        ///// <typeparam name="T"></typeparam>
        ///// <param name="t"></param>
        ///// <param name="TableName"></param>
        ///// <returns></returns>
        //public int BulkCopyModel<T>(List<T> t, string TableName) where T : class, new()
        //{
        //    return BulkCopyModel(t, TableName, SqlsugarHelper.Instance);
        //}
        ///// <summary>
        ///// 大量数据更新（如果有则更新没有则插入）
        ///// </summary>
        ///// <typeparam name="T">模型</typeparam>
        ///// <param name="t">数据</param>
        ///// <param name="TableName">表名</param>
        ///// <param name="db">数据库连接</param>
        ///// <returns></returns>
        //public int BulkCopyModel<T>(List<T> t, string TableName, SqlSugarClient db) where T : class, new()
        //{
        //    var x = db.Storageable<T>(t).As(TableName).ToStorage();
        //    int I = x.BulkCopy();//不存在插入
        //    int U = x.BulkUpdate();//存在更新

        //    return I + U;
        //}
        ///// <summary>
        ///// 批量数据插入（不检查数据是否已存在）
        ///// </summary>
        ///// <typeparam name="T">模型类型</typeparam>
        ///// <param name="t">数据对象</param>
        ///// <param name="TableName">表名称</param>
        ///// <returns>受影响行数</returns>
        //public int BulkInsertModel<T>(List<T> t, string TableName) where T : class, new()
        //{
        //    return BulkInsertModel(t, TableName);
        //}
        ///// <summary>
        ///// 批量数据插入（不检查数据是否已存在）
        ///// </summary>
        ///// <typeparam name="T">模型</typeparam>
        ///// <param name="t"></param>
        ///// <param name="TableName">表名</param>
        ///// <param name="db"></param>
        ///// <returns></returns>
        //public int BulkInsertModel<T>(List<T> t, string TableName, SqlSugarClient db) where T : class, new()
        //{
        //    return db.Fastest<T>().AS(TableName).BulkCopy(t);
        //}
        /// <summary>
        /// 添加实体数据，并返回主键值(主键为自增int类型id,实体需要设置主键特性(为null字段不更新,注意model有默认值的情况)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <returns></returns>
        public int InsertModel<T>(T t) where T : class, new()
        {
            return InsertModel(t, SqlsugarHelper.Instance);
        }
        /// <summary>
        /// 添加实体数据，并返回主键值(主键为自增int类型id,实体需要设置主键特性)(为null字段不更新,注意model有默认值的情况)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="db">(事务的db对象)</param>
        /// <returns></returns>
        public int InsertModel<T>(T t, SqlSugarClient db) where T : class, new()
        {
            //Where(true/*不插入null值的列*/,false/*不插入主键值*/)
            return db.Insertable(t).
                //IgnoreColumns(p=>p.Equals("id",StringComparison.InvariantCultureIgnoreCase)).
                IgnoreColumns(true, false).ExecuteReturnIdentity();
        }
        /// <summary>
        /// 添加实体数据，并返回主键值(主键为自增long类型id,实体需要设置主键特性(为null字段不更新,注意model有默认值的情况)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <returns></returns>
        public long InsertModel_BigIdentity<T>(T t) where T : class, new()
        {
            return InsertModel_BigIdentity(t, SqlsugarHelper.Instance);
        }
        /// <summary>
        /// 添加实体数据，并返回主键值(主键为自增long类型id,实体需要设置主键特性)(为null字段不更新,注意model有默认值的情况)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="db">(事务的db对象)</param>
        /// <returns></returns>
        public long InsertModel_BigIdentity<T>(T t, SqlSugarClient db) where T : class, new()
        {
            //Where(true/*不插入null值的列*/,false/*不插入主键值*/)
            return db.Insertable(t).
                //IgnoreColumns(p=>p.Equals("id",StringComparison.InvariantCultureIgnoreCase)).
                IgnoreColumns(true, false).ExecuteReturnBigIdentity();
        }
        #region  删除缓存
        /// <summary>
        /// 添加实体数据,删除缓存,并返回主键值(主键为自增int类型id,实体需要设置主键特性(为null字段不更新,注意model有默认值的情况)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <returns></returns>
        public int InsertModel_RemoveDataCache<T>(T t) where T : class, new()
        {
            return InsertModel_RemoveDataCache(t, SqlsugarHelper.Instance);
        }

        /// <summary>
        /// 添加实体数据,删除缓存,并返回主键值(主键为自增int类型id,实体需要设置主键特性)(为null字段不更新,注意model有默认值的情况)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="db">(事务的db对象)</param>
        /// <returns></returns>
        public int InsertModel_RemoveDataCache<T>(T t, SqlSugarClient db) where T : class, new()
        {
            //Where(true/*不插入null值的列*/,false/*不插入主键值*/)
            return db.Insertable(t).
                //IgnoreColumns(p=>p.Equals("id",StringComparison.InvariantCultureIgnoreCase)).
                IgnoreColumns(true, false).RemoveDataCache().ExecuteReturnIdentity();
        }

        /// <summary>
        /// 添加实体数据，并返回主键值(主键为自增long类型id,实体需要设置主键特性(为null字段不更新,注意model有默认值的情况)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <returns></returns>
        public long InsertModel_BigIdentity_RemoveDataCache<T>(T t) where T : class, new()
        {
            return InsertModel_BigIdentity_RemoveDataCache(t, SqlsugarHelper.Instance);
        }

        /// <summary>
        /// 添加实体数据，并返回主键值(主键为自增long类型id,实体需要设置主键特性)(为null字段不更新,注意model有默认值的情况)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="db">(事务的db对象)</param>
        /// <returns></returns>
        public long InsertModel_BigIdentity_RemoveDataCache<T>(T t, SqlSugarClient db) where T : class, new()
        {
            //Where(true/*不插入null值的列*/,false/*不插入主键值*/)
            return db.Insertable(t).
                //IgnoreColumns(p=>p.Equals("id",StringComparison.InvariantCultureIgnoreCase)).
                IgnoreColumns(true, false).RemoveDataCache().ExecuteReturnBigIdentity();
        }
        #endregion

        #endregion

        #region 更新
        /// <summary>
        /// 根据主键更新实体(为null字段不更新,注意model有默认值的情况)，返回影响条数(实体字段要有主键特性)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <returns></returns>
        public int UpdateModelByKey<T>(T t, string TableName) where T : class, new()
        {
            return UpdateModelByKey(t, TableName, SqlsugarHelper.Instance);
        }

        /// <summary>
        /// 根据主键更新实体，返回影响条数(实体字段要有主键特性)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="db">(事务的db对象)</param>
        /// <returns></returns>
        public int UpdateModelByKey<T>(T t, string TableName, SqlSugarClient db) where T : class, new()
        {
            //字段null，不进行更新
            return db.Updateable(t).AS(TableName).IgnoreColumns(ignoreAllNullColumns: true).ExecuteCommand();
        }

        /// <summary>
        /// 根据条件表达式更新实体(为null字段不更新,注意model有默认值的情况)，返回影响条数
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="expressionWhere">条件表达式</param>
        /// <returns></returns>
        public int UpdateModelsIgnoreNull<T>(T t, Expression<Func<T, bool>> expressionWhere) where T : class, new()
        {
            return UpdateModelsIgnoreNull(t, expressionWhere, SqlsugarHelper.Instance);
        }

        /// <summary>
        /// 根据条件表达式更新实体(为null字段不更新,注意model有默认值的情况)，返回影响条数
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="expressionWhere">条件表达式</param>
        /// <param name="db">(事务的db对象)</param>
        /// <returns></returns>
        public int UpdateModelsIgnoreNull<T>(T t, Expression<Func<T, bool>> expressionWhere, SqlSugarClient db) where T : class, new()
        {
            return db.Updateable(t).IgnoreColumns(ignoreAllNullColumns: true).Where(expressionWhere).ExecuteCommand();
        }

        /// <summary>
        /// 根据条件表达式更新实体(指定要更新的列)，返回影响条数
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t">模型</param>
        /// <param name="TableName">数据库中的表名称</param>
        /// <param name="columns">需要更新的字段</param>
        /// <param name="expressionWhere">条件表达式</param>
        /// <returns></returns>
        public int UpdateModels<T>(T t, string TableName, Expression<Func<T, object>> columns, Expression<Func<T, bool>> expressionWhere) where T : class, new()
        {
            return UpdateModels<T>(t, TableName, columns, expressionWhere, SqlsugarHelper.Instance);
        }

        /// <summary>
        /// 根据条件表达式更新实体(指定要更新的列)，返回影响条数
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="TableName">数据库中的表名</param>
        /// <param name="columns">需要更新的字段表达式</param>
        /// <param name="expressionWhere">条件表达式</param>
        /// <param name="db">(事务的db对象)</param>
        /// <returns></returns>
        public int UpdateModels<T>(T t, string TableName, Expression<Func<T, object>> columns, Expression<Func<T, bool>> expressionWhere, SqlSugarClient db) where T : class, new()
        {

            return db.Updateable(t).AS(TableName).UpdateColumns(columns).Where(expressionWhere).ExecuteCommand();

        }

        /// <summary>
        /// 动态更新
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="columns">写入要更新的字段</param>
        /// <param name="expressionWhere">where条件表达式</param>
        /// <returns></returns>
        public int Update<T>(Expression<Func<T, T>> columns, Expression<Func<T, bool>> expressionWhere) where T : class, new()
        {
            return Update<T>(columns, expressionWhere, SqlsugarHelper.Instance);
            /* 调用示例
            Update<Entity.SysAdmin>(p => new Entity.SysAdmin { photo = photo, Password = newPwd }
               ,p => p.ID == sm.id && p.Password == oldPwd) > 0;
            */
        }

        /// <summary>
        /// 动态更新
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="columns">要更新的字段</param>
        /// <param name="expressionWhere">where条件表达式</param>
        /// <param name="db"></param>
        /// <returns></returns>
        public int Update<T>(Expression<Func<T, T>> columns, Expression<Func<T, bool>> expressionWhere, SqlSugarClient db) where T : class, new()
        {
            return db.Updateable<T>().SetColumns(columns).
                //IgnoreColumns(ignoreAllNullColumns: true).//不能加此方法，会有“CommandText 属性尚未初始化”异常
                Where(expressionWhere).ExecuteCommand();
            /* 调用示例
             Update<Entity.SysAdmin>(p => new Entity.SysAdmin { photo = photo, Password = newPwd }
                ,p => p.ID == sm.id && p.Password == oldPwd ,db) > 0;
             */
        }
        /// <summary>
        /// 有主键批量更新
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="TableName">表名称</param>
        /// <param name="whereColumns">条件列</param>
        /// <param name="updateColumns">更新列</param>
        /// <returns></returns>
        public int BulkUpdata<T>(List<T> t, string TableName, string[] whereColumns = null, string[] updateColumns = null) where T : class, new()
        {
            return BulkUpdata(t, TableName, whereColumns, updateColumns);
        }
        ///// <summary>
        ///// 有主键批量更新
        ///// </summary>
        ///// <typeparam name="T"></typeparam>
        ///// <param name="t"></param>
        ///// <param name="TableName">表名称</param>
        ///// <param name="db">数据库连接</param>
        ///// <param name="whereColumns">条件列</param>
        ///// <param name="updateColumns">更新列</param>
        ///// <returns></returns>
        //public int BulkUpdata<T>(List<T> t, string TableName, SqlSugarClient db, string[] whereColumns, string[] updateColumns) where T : class, new()
        //{
        //    return db.Fastest<T>().AS(TableName).BulkUpdate(t, whereColumns, updateColumns);
        //}

        #region 删除缓存
        /// <summary>
        /// 根据主键更新实体(为null字段不更新,注意model有默认值的情况)并删除缓存，返回影响条数(实体字段要有主键特性)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <returns></returns>
        public int UpdateModelByKey_RemoveDataCache<T>(T t) where T : class, new()
        {
            return UpdateModelByKey_RemoveDataCache(t, SqlsugarHelper.Instance);
        }

        /// <summary>
        /// 根据主键更新实体，返回影响条数(实体字段要有主键特性)并删除缓存，返回影响条数(实体字段要有主键特性)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="db">(事务的db对象)</param>
        /// <returns></returns>
        public int UpdateModelByKey_RemoveDataCache<T>(T t, SqlSugarClient db) where T : class, new()
        {
            //字段null，不进行更新
            return db.Updateable(t).IgnoreColumns(ignoreAllNullColumns: true).RemoveDataCache().ExecuteCommand();
        }


        /// <summary>
        /// 根据条件表达式更新实体(指定要更新的列)并删除缓存，返回影响条数
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="columns"></param>
        /// <param name="expressionWhere"></param>
        /// <returns></returns>
        public int UpdateModels_RemoveDataCache<T>(T t, Expression<Func<T, object>> columns, Expression<Func<T, bool>> expressionWhere) where T : class, new()
        {
            return UpdateModels_RemoveDataCache<T>(t, columns, expressionWhere, Instance);
        }

        /// <summary>
        /// 根据条件表达式更新实体(指定要更新的列)并删除缓存，返回影响条数
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="columns"></param>
        /// <param name="expressionWhere">条件表达式</param>
        /// <param name="db">(事务的db对象)</param>
        /// <returns></returns>
        public int UpdateModels_RemoveDataCache<T>(T t, Expression<Func<T, object>> columns, Expression<Func<T, bool>> expressionWhere, SqlSugarClient db) where T : class, new()
        {
            return db.Updateable(t).UpdateColumns(columns).Where(expressionWhere).RemoveDataCache().ExecuteCommand();
        }

        /// <summary>
        /// 动态更新,并删除缓存
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="columns">写入要更新的字段</param>
        /// <param name="expressionWhere">where条件表达式</param>
        /// <returns></returns>
        public int Update_RemoveDataCache<T>(Expression<Func<T, T>> columns, Expression<Func<T, bool>> expressionWhere) where T : class, new()
        {
            return Update_RemoveDataCache<T>(columns, expressionWhere, SqlsugarHelper.Instance);
            /* 调用示例
            Update<Entity.SysAdmin>(p => new Entity.SysAdmin { photo = photo, Password = newPwd }
               ,p => p.ID == sm.id && p.Password == oldPwd) > 0;
            */
        }

        /// <summary>
        /// 动态更新,并删除缓存
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="columns">要更新的字段</param>
        /// <param name="expressionWhere">where条件表达式</param>
        /// <param name="db"></param>
        /// <returns></returns>
        public int Update_RemoveDataCache<T>(Expression<Func<T, T>> columns, Expression<Func<T, bool>> expressionWhere, SqlSugarClient db) where T : class, new()
        {
            return db.Updateable<T>().SetColumns(columns).
                //IgnoreColumns(ignoreAllNullColumns: true).//不能加此方法，会有“CommandText 属性尚未初始化”异常
                Where(expressionWhere).RemoveDataCache().ExecuteCommand();
            /* 调用示例
             Update<Entity.SysAdmin>(p => new Entity.SysAdmin { photo = photo, Password = newPwd }
                ,p => p.ID == sm.id && p.Password == oldPwd ,db) > 0;
             */
        }

        #endregion

        #endregion

        #region 删除方法

        /// <summary>
        /// 删除ids集合条件的字符串(高效率写法,注意防止注入攻击)
        /// </summary>
        /// <param name="ids">ids为字符串 "1,2,3"或"1" 形式</param>
        /// <param name="key">主键字段</param>
        /// <returns></returns>
        public static bool DeleteByWhereSql_ids<T>(string ids, string key = "id") where T : class, new()
        {
            return DeleteByWhereSql_ids<T>(ids, SqlsugarHelper.Instance, key);
        }

        /// <summary>
        /// 删除ids集合条件的字符串(高效率写法,注意防止注入攻击)
        /// </summary>
        /// <param name="ids">ids为字符串 "1,2,3"或"1" 形式</param>
        /// <param name="db">(事务的db对象)</param>
        /// <param name="key">主键字段</param>
        /// <returns></returns>
        public static bool DeleteByWhereSql_ids<T>(string ids, SqlSugarClient db, string key = "id") where T : class, new()
        {
            return db.Deleteable<T>().Where(string.Format(" {0} IN ({1})", key, ids)).ExecuteCommand() > 0;
        }

        /// <summary>
        /// 删除ids集合条件的字符串
        /// </summary>
        /// <param name="ids">ids为字符串 "1,2,3"或"1" 形式 </param>
        /// <returns></returns>
        public static bool DeleteByIds<T>(string ids) where T : class, new()
        {
            return DeleteByIds<T>(ids, SqlsugarHelper.Instance);
        }

        /// <summary>
        /// 删除ids集合条件的字符串
        /// </summary>
        /// <param name="ids">ids为字符串 "1,2,3"或"1" 形式 </param>
        /// <param name="db">(事务的db对象)</param>
        /// <returns></returns>
        public static bool DeleteByIds<T>(string ids, SqlSugarClient db) where T : class, new()
        {
            return db.Deleteable<T>(GetIntListByString(ids)).ExecuteCommand() > 0;
        }

        /// <summary>
        /// 删除ids集合条件的字符串
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="ids">ids为字符串 "1,2,3"或"1" 形式</param>
        /// <returns></returns>
        public static bool DeleteByInt64_Ids<T>(string ids) where T : class, new()
        {
            return DeleteByInt64_Ids<T>(ids, SqlsugarHelper.Instance);
        }

        /// <summary>
        /// 删除ids集合条件的字符串
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="ids">ids为字符串 "1,2,3"或"1" 形式</param>
        /// <param name="db">(事务的db对象)</param>
        /// <returns></returns>
        public static bool DeleteByInt64_Ids<T>(string ids, SqlSugarClient db) where T : class, new()
        {
            return db.Deleteable<T>(GetLongListByString(ids)).ExecuteCommand() > 0;
        }

        /// <summary>
        /// 根据条件表达式删除，返回影响条数
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="expression"></param>
        /// <returns></returns>
        public static int DeleteModels<T>(Expression<Func<T, bool>> expression) where T : class, new()
        {
            return DeleteModels<T>(expression, SqlsugarHelper.Instance);
        }

        /// <summary>
        /// 根据条件表达式删除，返回影响条数
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="expression">表达式</param>
        /// <param name="db">(事务的db对象)</param>
        /// <returns></returns>
        public static int DeleteModels<T>(Expression<Func<T, bool>> expression, SqlSugarClient db) where T : class, new()
        {
            return db.Deleteable<T>().Where(expression).ExecuteCommand();
        }

        #region 删除缓存

        /// <summary>
        /// 删除ids集合条件的字符串(高效率写法,注意防止注入攻击)，并删除缓存
        /// </summary>
        /// <param name="ids">ids为字符串 "1,2,3"或"1" 形式</param>
        /// <param name="key">主键字段</param>
        /// <returns></returns>
        public static bool DeleteByWhereSql_ids_RemoveDataCache<T>(string ids, string key = "id") where T : class, new()
        {
            return DeleteByWhereSql_ids_RemoveDataCache<T>(ids, SqlsugarHelper.Instance, key);
        }

        /// <summary>
        /// 删除ids集合条件的字符串(高效率写法,注意防止注入攻击)，并删除缓存
        /// </summary>
        /// <param name="ids">ids为字符串 "1,2,3"或"1" 形式</param>
        /// <param name="db">(事务的db对象)</param>
        /// <param name="key">主键字段</param>
        /// <returns></returns>
        public static bool DeleteByWhereSql_ids_RemoveDataCache<T>(string ids, SqlSugarClient db, string key = "id") where T : class, new()
        {
            return db.Deleteable<T>().Where(string.Format(" {0} IN ({1})", key, ids)).RemoveDataCache().ExecuteCommand() > 0;
        }


        /// <summary>
        /// 删除ids集合条件的字符串，并删除缓存
        /// </summary>
        /// <param name="ids">ids为字符串 "1,2,3"或"1" 形式 </param>
        /// <returns></returns>
        public static bool DeleteByIds_RemoveDataCache<T>(string ids) where T : class, new()
        {
            return DeleteByIds_RemoveDataCache<T>(ids, Instance);
        }

        /// <summary>
        /// 删除ids集合条件的字符串，并删除缓存
        /// </summary>
        /// <param name="ids">ids为字符串 "1,2,3"或"1" 形式 </param>
        /// <param name="db">(事务的db对象)</param>
        /// <returns></returns>
        public static bool DeleteByIds_RemoveDataCache<T>(string ids, SqlSugarClient db) where T : class, new()
        {
            return db.Deleteable<T>(GetIntListByString(ids)).RemoveDataCache().ExecuteCommand() > 0;
        }

        /// <summary>
        /// 删除ids集合条件的字符串，并删除缓存
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="ids">ids为字符串 "1,2,3"或"1" 形式</param>
        /// <returns></returns>
        public static bool DeleteByInt64_Ids_RemoveDataCache<T>(string ids) where T : class, new()
        {
            return DeleteByInt64_Ids_RemoveDataCache<T>(ids, Instance);
        }

        /// <summary>
        /// 删除ids集合条件的字符串，并删除缓存
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="ids">ids为字符串 "1,2,3"或"1" 形式</param>
        /// <param name="db">(事务的db对象)</param>
        /// <returns></returns>
        public static bool DeleteByInt64_Ids_RemoveDataCache<T>(string ids, SqlSugarClient db) where T : class, new()
        {
            return db.Deleteable<T>(GetLongListByString(ids)).RemoveDataCache().ExecuteCommand() > 0;
        }

        #endregion

        #endregion

        #region ids转集合

        /// <summary>
        /// 将字符串转成int数组(, 号分割)
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public static int[] GetIntListByString(string ids)
        {
            if (string.IsNullOrWhiteSpace(ids)) return null;
            return Array.ConvertAll<string, int>(ids.Split(','), Int32.Parse);
        }

        /// <summary>
        /// 将字符串转成long数组(, 号分割)
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public static long[] GetLongListByString(string ids)
        {
            if (string.IsNullOrWhiteSpace(ids)) return null;
            return Array.ConvertAll<string, long>(ids.Split(','), Int64.Parse);
        }

        #endregion

        #region 扩展查询，不建议使用

        /// <summary>
        /// 简单查询数据
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <param name="columns">字段</param>
        /// <param name="dicWhere">条件</param>
        /// <returns></returns>
        public DataTable GetDataTable(string tableName, string columns, Dictionary<string, object> dicWhere)
        {
            var db = SqlsugarHelper.Instance;
            string sql = string.Format("select {0} from {1} ", columns, tableName);

            List<SugarParameter> sqlParams = new List<SugarParameter>();

            if (dicWhere != null)
            {
                string whereSql = dicFill_where(dicWhere, ref sqlParams);

                return db.Ado.GetDataTable(sql + " where 1=1 " + whereSql, sqlParams.ToArray());
            }
            else
            {
                return db.Ado.GetDataTable(sql);
            }
        }


        /// <summary>
        /// 查询数据
        /// </summary>
        /// <param name="sqlStr">sql</param>
        /// <param name="dicWhere">条件</param>
        /// <param name="whereSql">where 条件,加and (注意sql注入攻击)</param>
        /// <param name="parList">扩展参数</param>
        /// <returns></returns>
        public DataTable GetDataTableBySql(string sqlStr, Dictionary<string, object> dicWhere, string whereSql = "", List<SugarParameter> parList = null)
        {
            var db = SqlsugarHelper.Instance;
            List<SugarParameter> sqlParams = new List<SugarParameter>();

            string _whereSql = dicFill_where(dicWhere, ref sqlParams) + whereSql;

            if (parList != null && parList.Count > 0)
            {
                sqlParams.AddRange(parList);
            }

            if (sqlParams.Count > 0)
            {
                return db.Ado.GetDataTable(string.Format(sqlStr + " {0} ", " where 1=1 " + _whereSql), sqlParams.ToArray());
            }
            else
            {
                return db.Ado.GetDataTable(string.IsNullOrEmpty(whereSql) ? sqlStr : sqlStr + whereSql);
            }
        }

        /// <summary>
        /// 查询数据
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="parameters">参数</param>
        /// <param name="ConnectionString">连接字符串</param>
        /// <param name="dbType">数据库类型</param>
        /// <returns>Datatable</returns>
        public DataTable Query(string sql, List<SugarParameter> parameters)
        {
            var dt = SqlsugarHelper.Instance.Ado.GetDataTable(sql, parameters);
            return dt;
        }
        /// <summary>
        /// 分页取数据
        /// </summary>
        /// <param name="tableName">前台子查询生成表名字</param>
        /// <param name="dicWhere">where条件字段集合</param>
        /// <param name="whereSql">where条件，加 and (注意sql注入)</param>
        /// <param name="orderbyColumn">排序字段</param>
        /// <param name="pageIndex">当前页码(从0开始)</param>
        /// <param name="pageSize">一页显示多少条记录</param>
        /// <param name="recordCount">返回总记录</param>
        /// <param name="cte">cte的sql</param>
        /// <returns></returns>
        public DataTable GetDataPage(string tableName, Dictionary<string, object> dicWhere, string whereSql, string orderbyColumn, int pageIndex, int pageSize, out int recordCount, string cte = "")
        {
            var db = SqlsugarHelper.Instance;
            List<SugarParameter> par = new List<SugarParameter>();

            StringBuilder where = new StringBuilder();
            where.Append(" where 1=1 ");
            where.Append(dicFill_where(dicWhere, ref par) + whereSql);


            string tableSql = tableName.Contains("select ") ?
                string.Format(" ( " + tableName + " {0} ) pageTable ", where.ToString()) :
                string.Format(" ( select * from " + tableName + " {0} ) pageTable ", where.ToString());

            string sql = string.Format(@"{5} 
                       select  {0},row_number() over(order by {1}) rid into #tt from {2} 
                               Order By {1}  select * from  #tt where rid> {3} and rid<={4} ;select count(1) from #tt ;drop table  #tt ",

                " * ", orderbyColumn, tableSql, pageSize * pageIndex, pageSize * (pageIndex + 1), cte);


            DataSet ds = par.Count > 0 ? db.Ado.GetDataSetAll(sql, par.ToArray()) : db.Ado.GetDataSetAll(sql);

            recordCount = Convert.ToInt32(ds.Tables[1].Rows[0][0].ToString());

            return ds.Tables[0];
        }

        /// <summary>
        /// 封装where参数sql语句
        /// </summary>
        /// <param name="dicWhere"></param>
        /// <param name="par"></param>
        /// <returns></returns>
        private string dicFill_where(Dictionary<string, object> dicWhere, ref List<SugarParameter> par)
        {
            StringBuilder whereSql = new StringBuilder();

            if (dicWhere != null && dicWhere.Count > 0)
            {
                string keyName;
                foreach (KeyValuePair<string, object> keyDic in dicWhere)
                {
                    keyName = getParameterName(keyDic.Key);
                    if (keyDic.Value.ToString().Contains("%") ||
                        keyDic.Value.ToString().Contains("_") ||
                        (keyDic.Value.ToString().Contains("[") && keyDic.Value.ToString().Contains("]"))
                    ) //只要是含有 % _  [ ]  都是按照模糊查询
                    {
                        whereSql.AppendFormat(" and {0} like @{1} ", keyDic.Key, keyName);
                    }
                    else
                    {
                        whereSql.AppendFormat(" and {0} = @{1} ", keyDic.Key, keyName);
                    }

                    par.Add(new SugarParameter(string.Format("@{0}", keyName), keyDic.Value));
                }
            }

            return whereSql.ToString();
        }

        /// <summary>
        /// 把字段名称 [dbo].[new].[title] ，取字段名title
        /// </summary>
        /// <param name="key">字段</param>
        /// <returns></returns>
        private string getParameterName(string key)
        {
            var temp = key.Split('.');
            StringBuilder sb = new StringBuilder(temp[temp.Length - 1]);
            sb.Replace("[", string.Empty).Replace("]", string.Empty);
            return sb.ToString();
        }

        /// <summary>
        /// 动态添加数据
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <param name="dic">参数和对应值集合</param>
        /// <returns>新添加数据id</returns>
        public int InsertDB(string tableName, Dictionary<string, object> dic)
        {
            StringBuilder columns = new StringBuilder();
            StringBuilder columnParameters = new StringBuilder();
            List<SugarParameter> sqlParams = new List<SugarParameter>();
            if (dic.Count > 0)
            {
                foreach (KeyValuePair<string, object> keyDic in dic)
                {
                    columns.AppendFormat(",{0}", keyDic.Key);
                    columnParameters.AppendFormat(",@{0}", getParameterName(keyDic.Key));
                    sqlParams.Add(new SugarParameter(string.Format("@{0}", getParameterName(keyDic.Key)), keyDic.Value));
                }
            }
            else
            {
                return 0;
            }

            string sql =
                string.Format("insert into {0}({1}) values ({2});select @@IDENTITY",
                    tableName, columns.ToString().Substring(1), columnParameters.ToString().Substring(1));

            return SqlsugarHelper.Instance.Ado.ExecuteCommand(sql, sqlParams.ToArray());
        }

        /// <summary>
        /// 动态更新数据
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <param name="dic">参数和对应值集合</param>
        /// <param name="whereSql">where 条件(注意sql注入攻击)</param>
        /// <returns>是否更新成功！</returns>
        public bool UpdateDB(string tableName, Dictionary<string, object> dic, string whereSql)
        {
            StringBuilder columns = new StringBuilder();

            List<SugarParameter> sqlParams = new List<SugarParameter>();
            string keyName;
            if (dic != null && dic.Count > 0)
            {
                foreach (KeyValuePair<string, object> keyDic in dic)
                {
                    keyName = getParameterName(keyDic.Key);
                    columns.AppendFormat(",{0}=@{1}", keyDic.Key, keyName);
                    sqlParams.Add(new SugarParameter(string.Format("@{0}", keyName), keyDic.Value));
                }
            }
            else
            {
                return false;
            }


            string sql =
                string.Format("update {0} set {1} where {2}",
                    tableName, columns.ToString().Substring(1), whereSql);

            return SqlsugarHelper.Instance.Ado.ExecuteCommand(sql, sqlParams) > 0;
        }


        /// <summary>
        /// 动态更新数据
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <param name="dic">参数和对应值集合</param>
        /// <param name="dicWhere">where条件参数和对应值集合</param>
        /// <returns>是否更新成功！</returns>
        public bool UpdateDB(string tableName, Dictionary<string, object> dic, Dictionary<string, object> dicWhere)
        {
            StringBuilder columns = new StringBuilder();
            StringBuilder wheresSql = new StringBuilder();
            List<SugarParameter> sqlParams = new List<SugarParameter>();
            string keyName;
            if (dic != null && dic.Count > 0)
            {
                foreach (KeyValuePair<string, object> keyDic in dic)
                {
                    keyName = getParameterName(keyDic.Key);
                    columns.AppendFormat(",{0}=@{1}", keyDic.Key, keyName);
                    sqlParams.Add(new SugarParameter(string.Format("@{0}", keyName), keyDic.Value));
                }
            }
            else
            {
                return false;
            }

            if (dicWhere != null && dicWhere.Count > 0)
            {
                foreach (KeyValuePair<string, object> keyDic in dicWhere)
                {
                    keyName = getParameterName(keyDic.Key);
                    wheresSql.AppendFormat(" and {0}=@{1}", keyDic.Key, keyName);
                    sqlParams.Add(new SugarParameter(string.Format("@{0}", keyName), keyDic.Value));
                }
            }
            else
            {
                return false;
            }

            string sql =
                string.Format("update {0} set {1} where 1=1 {2}",
                    tableName, columns.ToString().Substring(1), wheresSql.ToString().Substring(1));

            return SqlsugarHelper.Instance.Ado.ExecuteCommand(sql, sqlParams) > 0;
        }


        /// <summary>
        /// 查询是否存在此记录
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <param name="dicWhere">条件</param>
        /// <param name="whereSql">条件(加 and)</param>
        /// <returns></returns>
        public bool Exists(string tableName, Dictionary<string, object> dicWhere, string whereSql = "")
        {
            string sql = string.Format("select count(1) from {0} where 1=1 ", tableName);

            List<SugarParameter> sqlParams = new List<SugarParameter>();

            string whereSql2 = dicFill_where(dicWhere, ref sqlParams) + whereSql;

            return SqlsugarHelper.Instance.Ado.GetInt(sql + whereSql2, sqlParams) > 0;
        }

        #endregion

    }
}
