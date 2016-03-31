using System.Collections.Generic;
using System.Threading.Tasks;

namespace Spherus.Data.Base
{
    public abstract class SqlDataManager : DataManagerBase
    {
        #region SQL Methods

        #region Synchronous

        #region ExecuteSQL

        /// <summary>
        /// Executes sql statement and returns Dynamic Data
        /// </summary>
        /// <param name="sqlStatement">sql statement</param>
        /// <returns>Dynamic Data</returns>
        protected abstract dynamic ExecuteSQL(string sqlStatement);

        /// <summary>
        /// Executes sql statement and returns Dynamic Data
        /// </summary>
        /// <param name="sqlStatement">sql statement</param>
        /// <param name="parameters">Collection of <see cref="SqlParameter"/></param>
        /// <returns>Dynamic Data</returns>
        protected abstract dynamic ExecuteSQL(string sqlStatement, IEnumerable<SqlParameter> parameters);

        /// <summary>
        /// Executes sql statement and returns Dynamic Data
        /// </summary>
        /// <param name="sqlStatement">sql statement</param>
        /// <param name="transactionManager"><see cref="SqlTransactionManager"/> in which need to execute sql statement</param>
        /// <returns>Dynamic Data</returns>
        protected abstract dynamic ExecuteSQL(string sqlStatement, SqlTransactionManager transactionManager);

        /// <summary>
        /// Executes sql statement and returns Dynamic Data
        /// </summary>
        /// <param name="sqlStatement">sql statement</param>
        /// <param name="parameters">Collection of <see cref="SqlParameter"/></param>
        /// <param name="transactionManager"><see cref="SqlTransactionManager"/> in which need to execute sql statement</param>
        /// <returns>Dynamic Data</returns>
        protected abstract dynamic ExecuteSQL(string sqlStatement, IEnumerable<SqlParameter> parameters, SqlTransactionManager transactionManager);

        #endregion

        #region ExecuteSQLNonQuery

        /// <summary>
        /// Executes sql statement 
        /// </summary>
        /// <param name="sqlStatement">sql string to execute</param>
        /// <returns>Number of Affected rows</returns>
        protected abstract int ExecuteSQLNonQuery(string sqlStatement);

        /// <summary>
        /// Executes sql statement as NonQuery with parameters
        /// </summary>
        /// <param name="sqlStatement">sql string to execute</param>
        /// <param name="parameters">Collection of <see cref="SqlParameter"/></param>
        /// <returns>Number of Affected rows</returns>
        protected abstract int ExecuteSQLNonQuery(string sqlStatement, IEnumerable<SqlParameter> parameters);

        /// <summary>
        /// Executes sql statement 
        /// </summary>
        /// <param name="sqlStatement">sql string to execute</param>
        /// <param name="transactionManager"><see cref="SqlTransactionManager"/> in which need to execute sql statement</param>
        /// <returns>Number of Affected rows</returns>
        protected abstract int ExecuteSQLNonQuery(string sqlStatement, SqlTransactionManager transactionManager);

        /// <summary>
        /// Executes sql statement 
        /// </summary>
        /// <param name="sqlStatement">sql string to execute</param>
        /// <param name="parameters">Collection of <see cref="SqlParameter"/></param>
        /// <param name="transactionManager"><see cref="SqlTransactionManager"/> in which need to execute sql statement</param>
        /// <returns>Number of Affected rows</returns>
        protected abstract int ExecuteSQLNonQuery(string sqlStatement, IEnumerable<SqlParameter> parameters, SqlTransactionManager transactionManager);

        #endregion

        #region ExecuteSQLScalar

        /// <summary>
        /// Executes sql statement scalar and returns object
        /// </summary>
        /// <param name="sqlStatement">sql string to execute</param>
        /// <returns>Execution result object</returns>
        protected abstract object ExecuteSQLScalar(string sqlStatement);

        /// <summary>
        /// Executes sql statement scalar and returns object
        /// </summary>
        /// <param name="sqlStatement">sql string to execute</param>
        /// <param name="parameters">Collection of <see cref="SqlParameter"/></param>
        /// <returns>Execution result object</returns>
        protected abstract object ExecuteSQLScalar(string sqlStatement, IEnumerable<SqlParameter> parameters);

        /// <summary>
        /// Executes sql statement scalar and returns object
        /// </summary>
        /// <param name="sqlStatement">sql string to execute</param>
        /// <param name="transactionManager"><see cref="SqlTransactionManager"/> in which need to execute sql statement</param>
        /// <returns>Execution result object</returns>
        protected abstract object ExecuteSQLScalar(string sqlStatement, SqlTransactionManager transactionManager);

        /// <summary>
        /// Executes sql statement scalar and returns object
        /// </summary>
        /// <param name="sqlStatement">sql string to execute</param>
        /// <param name="parameters">Collection of <see cref="SqlParameter"/></param>
        /// <param name="transactionManager"><see cref="SqlTransactionManager"/> in which need to execute sql statement</param>
        /// <returns>Execution result object</returns>
        protected abstract object ExecuteSQLScalar(string sqlStatement, IEnumerable<SqlParameter> parameters, SqlTransactionManager transactionManager);

        #endregion

        #region ExecuteSQLObject

        /// <summary>
        /// Executes a sql statement and returns an object
        /// </summary>
        /// <param name="sqlStatement">The sql statement to execute</param>
        /// <param name="parameters">Collection of <see cref="SqlParameter"/></param>
        /// <returns>Instance of generic <see cref="DataObject"/></returns>
        protected abstract T ExecuteSQLObject<T>(string sqlStatement) where T : DataObject;

        /// <summary>
        /// Executes a sql statement and returns an object
        /// </summary>
        /// <param name="sqlStatement">The sql statement to execute</param>
        /// <param name="parameters">Collection of <see cref="SqlParameter"/></param>
        /// <returns>Instance of generic <see cref="DataObject"/></returns>
        protected abstract T ExecuteSQLObject<T>(string sqlStatement, IEnumerable<SqlParameter> parameters) where T : DataObject;

        /// <summary>
        /// Executes a sql statement and returns an object
        /// </summary>
        /// <param name="sqlStatement">The sql statement to execute</param>
        /// <param name="transactionManager"><see cref="SqlTransactionManager"/> in which need to execute sql statement</param>
        /// <returns>Instance of generic <see cref="DataObject"/></returns>
        protected abstract T ExecuteSQLObject<T>(string sqlStatement, SqlTransactionManager transactionManager) where T : DataObject;

        /// <summary>
        /// Executes a sql statement and returns an object
        /// </summary>
        /// <param name="sqlStatement">The sql statement to execute</param>
        /// <param name="parameters">Collection of <see cref="SqlParameter"/></param>
        /// <param name="transactionManager"><see cref="SqlTransactionManager"/> in which need to execute sql statement</param>
        /// <returns>Instance of generic <see cref="DataObject"/></returns>
        protected abstract T ExecuteSQLObject<T>(string sqlStatement, IEnumerable<SqlParameter> parameters, SqlTransactionManager transactionManager) where T : DataObject;

        #endregion

        #region ExecuteSQLObjects

        /// <summary>
        /// Executes a sql statement and returns an IEnumerable of DataObject
        /// </summary>
        /// <param name="sqlStatement">The sql statement to execute</param>
        /// <returns>IEnumerable of generic <see cref="DataObject"/></returns>
        protected abstract IEnumerable<T> ExecuteSQLObjects<T>(string sqlStatement) where T : DataObject;

        /// <summary>
        /// Executes a sql statement and returns an IEnumerable of DataObject
        /// </summary>
        /// <param name="sqlStatement">The sql statement to execute</param>
        /// <param name="parameters">Collection of <see cref="SqlParameter"/></param>
        /// <returns>IEnumerable of generic <see cref="DataObject"/></returns>
        protected abstract IEnumerable<T> ExecuteSQLObjects<T>(string sqlStatement, IEnumerable<SqlParameter> parameters) where T : DataObject;

        /// <summary>
        /// Executes a sql statement and returns an IEnumerable of DataObject
        /// </summary>
        /// <param name="sqlStatement">The sql statement to execute</param>
        /// <param name="transactionManager"><see cref="SqlTransactionManager"/> in which need to execute sql statement</param>
        /// <returns>IEnumerable of generic <see cref="DataObject"/></returns>
        protected abstract IEnumerable<T> ExecuteSQLObjects<T>(string sqlStatement, SqlTransactionManager transactionManager) where T : DataObject;

        /// <summary>
        /// Executes a sql statement and returns an IEnumerable of DataObject
        /// </summary>
        /// <param name="sqlStatement">The sql statement to execute</param>
        /// <param name="parameters">Collection of <see cref="SqlParameter"/></param>
        /// <param name="transactionManager"><see cref="SqlTransactionManager"/> in which need to execute sql statement</param>
        /// <returns>IEnumerable of generic <see cref="DataObject"/></returns>
        protected abstract IEnumerable<T> ExecuteSQLObjects<T>(string sqlStatement, IEnumerable<SqlParameter> parameters, SqlTransactionManager transactionManager) where T : DataObject;

        #endregion

        #endregion

        #region Asynchronous

        #region ExecuteSQLAsync

        /// <summary>
        /// Executes sql statement asynchronously and returns Dynamic Data
        /// </summary>
        /// <param name="sqlStatement">sql statement</param>
        /// <returns>Dynamic Data</returns>
        protected abstract Task<dynamic> ExecuteSQLAsync(string sqlStatement);

        /// <summary>
        /// Executes sql statement asynchronously and returns Dynamic Data
        /// </summary>
        /// <param name="sqlStatement">sql statement</param>
        /// <param name="parameters">Collection of <see cref="SqlParameter"/></param>
        /// <returns>Dynamic Data</returns>
        protected abstract Task<dynamic> ExecuteSQLAsync(string sqlStatement, IEnumerable<SqlParameter> parameters);

        /// <summary>
        /// Executes sql statement asynchronously and returns Dynamic Data
        /// </summary>
        /// <param name="sqlStatement">sql statement</param>
        /// <param name="transactionManager"><see cref="SqlTransactionManager"/> in which need to execute sql statement</param>
        /// <returns>Dynamic Data</returns>
        protected abstract Task<dynamic> ExecuteSQLAsync(string sqlStatement, SqlTransactionManager transactionManager);

        /// <summary>
        /// Executes sql statement asynchronously and returns Dynamic Data
        /// </summary>
        /// <param name="sqlStatement">sql statement</param>
        /// <param name="parameters">Collection of <see cref="SqlParameter"/></param>
        /// <param name="transactionManager"><see cref="SqlTransactionManager"/> in which need to execute sql statement</param>
        /// <returns>Dynamic Data</returns>
        protected abstract Task<dynamic> ExecuteSQLAsync(string sqlStatement, IEnumerable<SqlParameter> parameters, SqlTransactionManager transactionManager);

        #endregion

        #region ExecuteSQLNonQueryAsync

        /// <summary>
        /// Executes sql statement asynchronously as NonQuery
        /// </summary>
        /// <param name="sqlStatement">sql string to execute</param>
        /// <returns>Number of Affected rows</returns>
        protected abstract Task<int> ExecuteSQLNonQueryAsync(string sqlStatement);

        /// <summary>
        /// Executes sql statement asynchronously as NonQuery
        /// </summary>
        /// <param name="sqlStatement">sql string to execute</param>
        /// <param name="parameters">Collection of <see cref="SqlParameter"/></param>
        /// <returns>Number of Affected rows</returns>
        protected abstract Task<int> ExecuteSQLNonQueryAsync(string sqlStatement, IEnumerable<SqlParameter> parameters);

        /// <summary>
        /// Executes sql statement asynchronously as NonQuery
        /// </summary>
        /// <param name="sqlStatement">sql string to execute</param>
        /// <param name="transactionManager"><see cref="SqlTransactionManager"/> in which need to execute sql statement</param>
        /// <returns>Number of Affected rows</returns>
        protected abstract Task<int> ExecuteSQLNonQueryAsync(string sqlStatement, SqlTransactionManager transactionManager);

        /// <summary>
        /// Executes sql statement asynchronously as NonQuery
        /// </summary>
        /// <param name="sqlStatement">sql string to execute</param>
        /// <param name="parameters">Collection of <see cref="SqlParameter"/></param>
        /// <param name="transactionManager"><see cref="SqlTransactionManager"/> in which need to execute sql statement</param>
        /// <returns>Number of Affected rows</returns>
        protected abstract Task<int> ExecuteSQLNonQueryAsync(string sqlStatement, IEnumerable<SqlParameter> parameters, SqlTransactionManager transactionManager);

        #endregion

        #region ExecuteSQLScalarAsync

        /// <summary>
        /// Executes sql statement asynchronously as Scalar and returns object
        /// </summary>
        /// <param name="sqlStatement">sqlStatement to execute</param>
        /// <returns>Execution result object</returns>
        protected abstract Task<object> ExecuteSQLScalarAsync(string sqlStatement);

        /// <summary>
        /// Executes sql statement asynchronously as Scalar and returns object
        /// </summary>
        /// <param name="sqlStatement">sqlStatement to execute</param>
        /// <param name="parameters">Collection of <see cref="SqlParameter"/></param>
        /// <returns>Execution result object</returns>
        protected abstract Task<object> ExecuteSQLScalarAsync(string sqlStatement, IEnumerable<SqlParameter> parameters);

        /// <summary>
        /// Executes sql statement asynchronously as Scalar and returns object
        /// </summary>
        /// <param name="sqlStatement">sqlStatement to execute</param>
        /// <param name="transactionManager"><see cref="SqlTransactionManager"/> in which need to execute sql statement</param>
        /// <returns>Execution result object</returns>
        protected abstract Task<object> ExecuteSQLScalarAsync(string sqlStatement, SqlTransactionManager transactionManager);

        /// <summary>
        /// Executes sql statement asynchronously as Scalar and returns object
        /// </summary>
        /// <param name="sqlStatement">sqlStatement to execute</param>
        /// <param name="parameters">Collection of <see cref="SqlParameter"/></param>
        /// <param name="transactionManager"><see cref="SqlTransactionManager"/> in which need to execute sql statement</param>
        /// <returns>Execution result object</returns>
        protected abstract Task<object> ExecuteSQLScalarAsync(string sqlStatement, IEnumerable<SqlParameter> parameters, SqlTransactionManager transactionManager);

        #endregion

        #region ExecuteSQLObjectAsync

        /// <summary>
        /// Executes sql statement asynchronously and returns an instance of <see cref="DataObject"/>
        /// </summary>
        /// <param name="sqlStatement">The sql statement to execute</param>
        /// <returns>Instance of generic <see cref="DataObject"/></returns>
        protected abstract Task<T> ExecuteSQLObjectAsync<T>(string sqlStatement) where T : DataObject;

        /// <summary>
        /// Executes sql statement asynchronously and returns an instance of <see cref="DataObject"/>
        /// </summary>
        /// <param name="sqlStatement">The sql statement to execute</param>
        /// <param name="parameters">Collection of <see cref="SqlParameter"/></param>
        /// <returns>Instance of generic <see cref="DataObject"/></returns>
        protected abstract Task<T> ExecuteSQLObjectAsync<T>(string sqlStatement, IEnumerable<DataParameterBase> parameters) where T : DataObject;

        /// <summary>
        /// Executes sql statement asynchronously and returns an instance of <see cref="DataObject"/>
        /// </summary>
        /// <param name="sqlStatement">The sql statement to execute</param>
        /// <param name="transactionManager"><see cref="SqlTransactionManager"/> in which need to execute sql statement</param>
        /// <returns>Instance of generic <see cref="DataObject"/></returns>
        protected abstract Task<T> ExecuteSQLObjectAsync<T>(string sqlStatement, SqlTransactionManager transactionManager) where T : DataObject;

        /// <summary>
        /// Executes sql statement asynchronously and returns an instance of <see cref="DataObject"/>
        /// </summary>
        /// <param name="sqlStatement">The sql statement to execute</param>
        /// <param name="parameters">Collection of <see cref="SqlParameter"/></param>
        /// <param name="transactionManager"><see cref="SqlTransactionManager"/> in which need to execute sql statement</param>
        /// <returns>Instance of generic <see cref="DataObject"/></returns>
        protected abstract Task<T> ExecuteSQLObjectAsync<T>(string sqlStatement, IEnumerable<DataParameterBase> parameters, SqlTransactionManager transactionManager) where T : DataObject;

        #endregion

        #region ExecuteSQLObjectsAsync

        /// <summary>
        /// Executes sql statement asynchronously and returns an <see cref="IEnumerable{T}"/> of <see cref="DataObject"/>
        /// </summary>
        /// <param name="sqlStatement">The sql statement to execute</param>
        /// <returns>IEnumerable of generic <see cref="DataObject"/></returns>
        protected abstract Task<IEnumerable<T>> ExecuteSQLObjectsAsync<T>(string sqlStatement) where T : DataObject;

        /// <summary>
        /// Executes sql statement asynchronously and returns an <see cref="IEnumerable{T}"/> of <see cref="DataObject"/>
        /// </summary>
        /// <param name="sqlStatement">The sql statement to execute</param>
        /// <param name="parameters">Collection of <see cref="SqlParameter"/></param>
        /// <returns>IEnumerable of generic <see cref="DataObject"/></returns>
        protected abstract Task<IEnumerable<T>> ExecuteSQLObjectsAsync<T>(string sqlStatement, IEnumerable<SqlParameter> parameters) where T : DataObject;

        /// <summary>
        /// Executes sql statement asynchronously and returns an <see cref="IEnumerable{T}"/> of <see cref="DataObject"/>
        /// </summary>
        /// <param name="sqlStatement">The sql statement to execute</param>
        /// <param name="transactionManager"><see cref="SqlTransactionManager"/> in which need to execute sql statement</param>
        /// <returns>IEnumerable of generic <see cref="DataObject"/></returns>
        protected abstract Task<IEnumerable<T>> ExecuteSQLObjectsAsync<T>(string sqlStatement, SqlTransactionManager transactionManager) where T : DataObject;

        /// <summary>
        /// Executes sql statement asynchronously and returns an <see cref="IEnumerable{T}"/> of <see cref="DataObject"/>
        /// </summary>
        /// <param name="sqlStatement">The sql statement to execute</param>
        /// <param name="parameters">Collection of <see cref="SqlParameter"/></param>
        /// <param name="transactionManager"><see cref="SqlTransactionManager"/> in which need to execute sql statement</param>
        /// <returns>IEnumerable of generic <see cref="DataObject"/></returns>
        protected abstract Task<IEnumerable<T>> ExecuteSQLObjectsAsync<T>(string sqlStatement, IEnumerable<SqlParameter> parameters, SqlTransactionManager transactionManager) where T : DataObject;

        #endregion

        #endregion

        #endregion
    }
}