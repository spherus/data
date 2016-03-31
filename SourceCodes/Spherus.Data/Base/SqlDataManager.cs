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
        /// Executes sql statement and returns data
        /// </summary>
        /// <param name="sqlStatement">sql statement</param>
        /// <param name="resultSet">DataTable to return rows</param>
        /// <returns>Number of affected rows</returns>
        protected abstract dynamic ExecuteSQL(string sqlStatement);

        /// <summary>
        /// Executes sql statement and returns data
        /// </summary>
        /// <param name="sqlStatement">sql statement</param>
        /// <param name="resultSet">DataTable to return rows</param>
        /// <param name="parameters">Collection of data parameters</param>
        /// <returns>Number of affected rows</returns>
        protected abstract dynamic ExecuteSQL(string sqlStatement, IEnumerable<SqlParameter> parameters);

        /// <summary>
        /// Executes sql statement and returns data
        /// </summary>
        /// <param name="sqlStatement">sql statement</param>
        /// <param name="resultSet">DataTable to return rows</param>
        /// <param name="transactionManager">Tranaction manager in which need to execute sql statement</param>
        /// <returns>Number of affected rows</returns>
        protected abstract dynamic ExecuteSQL(string sqlStatement, SqlTransactionManager transactionManager);

        /// <summary>
        /// Executes sql statement and returns data
        /// </summary>
        /// <param name="sqlStatement">sql statement</param>
        /// <param name="resultSet">DataTable to return rows</param>
        /// <param name="parameters">Collection of data parameters</param>
        /// <param name="transactionManager">Tranaction manager in which need to execute sql statement</param>
        /// <returns>Number of affected rows</returns>
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
        /// <param name="parameters">Collection of data parameters</param>
        /// <returns>Number of Affected rows</returns>
        protected abstract int ExecuteSQLNonQuery(string sqlStatement, IEnumerable<SqlParameter> parameters);

        /// <summary>
        /// Executes sql statement 
        /// </summary>
        /// <param name="sqlStatement">sql string to execute</param>
        /// <param name="transactionManager">Tranaction manager in which need to execute sql statement</param>
        /// <returns>Number of Affected rows</returns>
        protected abstract int ExecuteSQLNonQuery(string sqlStatement, SqlTransactionManager transactionManager);

        /// <summary>
        /// Executes sql statement 
        /// </summary>
        /// <param name="sqlStatement">sql string to execute</param>
        /// <param name="parameters">Collection of data parameters</param>
        /// <param name="transactionManager">Tranaction manager in which need to execute sql statement</param>
        /// <returns>Number of Affected rows</returns>
        protected abstract int ExecuteSQLNonQuery(string sqlStatement, IEnumerable<SqlParameter> parameters, SqlTransactionManager transactionManager);

        #endregion

        #region ExecuteSQLScalar

        /// <summary>
        /// Executes sqlStatement scalar and returns object
        /// </summary>
        /// <param name="sqlStatement">sqlStatement to execute</param>
        /// <returns>Execution result object</returns>
        protected abstract object ExecuteSQLScalar(string sqlStatement);

        /// <summary>
        /// Executes sqlStatement scalar and returns object
        /// </summary>
        /// <param name="sqlStatement">sqlStatement to execute</param>
        /// <param name="parameters">Collection of data parameters</param>
        /// <returns>Execution result object</returns>
        protected abstract object ExecuteSQLScalar(string sqlStatement, IEnumerable<SqlParameter> parameters);

        /// <summary>
        /// Executes sqlStatement scalar and returns object
        /// </summary>
        /// <param name="sqlStatement">sqlStatement to execute</param>
        /// <param name="transactionManager">Tranaction manager in which need to execute sql statement</param>
        /// <returns>Execution result object</returns>
        protected abstract object ExecuteSQLScalar(string sqlStatement, SqlTransactionManager transactionManager);

        /// <summary>
        /// Executes sqlStatement scalar and returns object
        /// </summary>
        /// <param name="sqlStatement">sqlStatement to execute</param>
        /// <param name="parameters">Collection of data parameters</param>
        /// <param name="transactionManager">Tranaction manager in which need to execute sql statement</param>
        /// <returns>Execution result object</returns>
        protected abstract object ExecuteSQLScalar(string sqlStatement, IEnumerable<SqlParameter> parameters, SqlTransactionManager transactionManager);

        #endregion

        #region ExecuteSQLObject

        /// <summary>
        /// Executes a sql statement and returns a object
        /// </summary>
        /// <param name="sqlStatement">The sql statement to execute</param>
        /// <param name="dataObject">the object to parse</param>
        /// <param name="dataParameters">the parameters passed</param>
        /// <returns>A <see cref="DBEntity"/> of specified type</returns>
        protected abstract T ExecuteSQLObject<T>(string sqlStatement) where T : DataObject;

        /// <summary>
        /// Executes a sql statement and returns a object
        /// </summary>
        /// <param name="sqlStatement">The sql statement to execute</param>
        /// <param name="dataObject">the object to parse</param>
        /// <param name="dataParameters">the parameters passed</param>
        /// <returns>A <see cref="DBEntity"/> of specified type</returns>
        protected abstract T ExecuteSQLObject<T>(string sqlStatement, IEnumerable<SqlParameter> dataParameters) where T : DataObject;

        /// <summary>
        /// Executes a sql statement and returns a object
        /// </summary>
        /// <param name="sqlStatement">The sql statement to execute</param>
        /// <param name="dataObject">the object to parse</param>
        /// <param name="dataParameters">the parameters passed</param>
        /// <returns>A <see cref="DBEntity"/> of specified type</returns>
        protected abstract T ExecuteSQLObject<T>(string sqlStatement, SqlTransactionManager transactionManager) where T : DataObject;

        /// <summary>
        /// Executes a sql statement and returns a object
        /// </summary>
        /// <param name="sqlStatement">The sql statement to execute</param>
        /// <param name="dataObject">the object to parse</param>
        /// <param name="dataParameters">the parameters passed</param>
        /// <returns>A <see cref="DBEntity"/> of specified type</returns>
        protected abstract T ExecuteSQLObject<T>(string sqlStatement, IEnumerable<SqlParameter> dataParameters, SqlTransactionManager transactionManager) where T : DataObject;

        #endregion

        #region ExecuteSQLObjects

        /// <summary>
        /// Executes a sql statement and returns a list of objects
        /// </summary>
        /// <param name="sqlStatement">The sql statement to execute</param>
        /// <returns>A list of <see cref="DBEntity"/> of specified type</returns>
        protected abstract IEnumerable<T> ExecuteSQLObjects<T>(string sqlStatement) where T : DataObject;

        /// <summary>
        /// Executes a sql statement and returns a list of objects
        /// </summary>
        /// <param name="sqlStatement">The sql statement to execute</param>
        /// <param name="dataParameters">the parameters passed</param>
        /// <returns>A list of <see cref="DBEntity"/> of specified type</returns>
        protected abstract IEnumerable<T> ExecuteSQLObjects<T>(string sqlStatement, IEnumerable<SqlParameter> dataParameters) where T : DataObject;

        /// <summary>
        /// Executes a sql statement and returns a list of objects
        /// </summary>
        /// <param name="sqlStatement">The sql statement to execute</param>
        /// <param name="dataParameters">the parameters passed</param>
        /// <returns>A list of <see cref="DBEntity"/> of specified type</returns>
        protected abstract IEnumerable<T> ExecuteSQLObjects<T>(string sqlStatement, SqlTransactionManager transactionManager) where T : DataObject;

        /// <summary>
        /// Executes a sql statement and returns a list of objects
        /// </summary>
        /// <param name="sqlStatement">The sql statement to execute</param>
        /// <param name="dataParameters">the parameters passed</param>
        /// <returns>A list of <see cref="DBEntity"/> of specified type</returns>
        protected abstract IEnumerable<T> ExecuteSQLObjects<T>(string sqlStatement, IEnumerable<SqlParameter> dataParameters, SqlTransactionManager transactionManager) where T : DataObject;

        #endregion

        #endregion

        #region Asynchronous

        #region ExecuteSQLAsync

        /// <summary>
        /// Executes sql statement and returns data
        /// </summary>
        /// <param name="sqlStatement">sql statement</param>
        /// <param name="resultSet">DataTable to return rows</param>
        /// <returns>Number of affected rows</returns>
        protected abstract Task<dynamic> ExecuteSQLAsync(string sqlStatement);

        /// <summary>
        /// Executes sql statement and returns data
        /// </summary>
        /// <param name="sqlStatement">sql statement</param>
        /// <param name="resultSet">DataTable to return rows</param>
        /// <param name="parameters">Collection of data parameters</param>
        /// <returns>Number of affected rows</returns>
        protected abstract Task<dynamic> ExecuteSQLAsync(string sqlStatement, IEnumerable<SqlParameter> parameters);

        /// <summary>
        /// Executes sql statement and returns data
        /// </summary>
        /// <param name="sqlStatement">sql statement</param>
        /// <param name="resultSet">DataTable to return rows</param>
        /// <param name="transactionManager">Tranaction manager in which need to execute sql statement</param>
        /// <returns>Number of affected rows</returns>
        protected abstract Task<dynamic> ExecuteSQLAsync(string sqlStatement, SqlTransactionManager transactionManager);

        /// <summary>
        /// Executes sql statement and returns data
        /// </summary>
        /// <param name="sqlStatement">sql statement</param>
        /// <param name="resultSet">DataTable to return rows</param>
        /// <param name="parameters">Collection of data parameters</param>
        /// <param name="transactionManager">Tranaction manager in which need to execute sql statement</param>
        /// <returns>Number of affected rows</returns>
        protected abstract Task<dynamic> ExecuteSQLAsync(string sqlStatement, IEnumerable<SqlParameter> parameters, SqlTransactionManager transactionManager);

        #endregion

        #region ExecuteSQLNonQueryAsync

        /// <summary>
        /// Executes sql statement 
        /// </summary>
        /// <param name="sqlStatement">sql string to execute</param>
        /// <returns>Number of Affected rows</returns>
        protected abstract Task<int> ExecuteSQLNonQueryAsync(string sqlStatement);

        /// <summary>
        /// Executes sql statement as NonQuery with parameters
        /// </summary>
        /// <param name="sqlStatement">sql string to execute</param>
        /// <param name="parameters">Collection of data parameters</param>
        /// <returns>Number of Affected rows</returns>
        protected abstract Task<int> ExecuteSQLNonQueryAsync(string sqlStatement, IEnumerable<SqlParameter> parameters);

        /// <summary>
        /// Executes sql statement 
        /// </summary>
        /// <param name="sqlStatement">sql string to execute</param>
        /// <param name="transactionManager">Tranaction manager in which need to execute sql statement</param>
        /// <returns>Number of Affected rows</returns>
        protected abstract Task<int> ExecuteSQLNonQueryAsync(string sqlStatement, SqlTransactionManager transactionManager);

        /// <summary>
        /// Executes sql statement 
        /// </summary>
        /// <param name="sqlStatement">sql string to execute</param>
        /// <param name="parameters">Collection of data parameters</param>
        /// <param name="transactionManager">Tranaction manager in which need to execute sql statement</param>
        /// <returns>Number of Affected rows</returns>
        protected abstract Task<int> ExecuteSQLNonQueryAsync(string sqlStatement, IEnumerable<SqlParameter> parameters, SqlTransactionManager transactionManager);

        #endregion

        #region ExecuteSQLScalarAsync

        /// <summary>
        /// Executes sqlStatement scalar and returns object
        /// </summary>
        /// <param name="sqlStatement">sqlStatement to execute</param>
        /// <returns>Execution result object</returns>
        protected abstract Task<object> ExecuteSQLScalarAsync(string sqlStatement);

        /// <summary>
        /// Executes sqlStatement scalar and returns object
        /// </summary>
        /// <param name="sqlStatement">sqlStatement to execute</param>
        /// <param name="parameters">Collection of data parameters</param>
        /// <returns>Execution result object</returns>
        protected abstract Task<object> ExecuteSQLScalarAsync(string sqlStatement, IEnumerable<SqlParameter> parameters);

        /// <summary>
        /// Executes sqlStatement scalar and returns object
        /// </summary>
        /// <param name="sqlStatement">sqlStatement to execute</param>
        /// <param name="transactionManager">Tranaction manager in which need to execute sql statement</param>
        /// <returns>Execution result object</returns>
        protected abstract Task<object> ExecuteSQLScalarAsync(string sqlStatement, SqlTransactionManager transactionManager);

        /// <summary>
        /// Executes sqlStatement scalar and returns object
        /// </summary>
        /// <param name="sqlStatement">sqlStatement to execute</param>
        /// <param name="parameters">Collection of data parameters</param>
        /// <param name="transactionManager">Tranaction manager in which need to execute sql statement</param>
        /// <returns>Execution result object</returns>
        protected abstract Task<object> ExecuteSQLScalarAsync(string sqlStatement, IEnumerable<SqlParameter> parameters, SqlTransactionManager transactionManager);

        #endregion

        #region ExecuteSQLObjectAsync

        /// <summary>
        /// Executes a sql statement and returns a object
        /// </summary>
        /// <param name="sqlStatement">The sql statement to execute</param>
        /// <param name="dataObject">the object to parse</param>
        /// <param name="dataParameters">the parameters passed</param>
        /// <returns>A <see cref="DBEntity"/> of specified type</returns>
        protected abstract Task<T> ExecuteSQLObjectAsync<T>(string sqlStatement) where T : DataObject;

        /// <summary>
        /// Executes a sql statement and returns a object
        /// </summary>
        /// <param name="sqlStatement">The sql statement to execute</param>
        /// <param name="dataObject">the object to parse</param>
        /// <param name="dataParameters">the parameters passed</param>
        /// <returns>A <see cref="DBEntity"/> of specified type</returns>
        protected abstract Task<T> ExecuteSQLObjectAsync<T>(string sqlStatement, IEnumerable<DataParameterBase> dataParameters) where T : DataObject;

        /// <summary>
        /// Executes a sql statement and returns a object
        /// </summary>
        /// <param name="sqlStatement">The sql statement to execute</param>
        /// <param name="dataObject">the object to parse</param>
        /// <param name="dataParameters">the parameters passed</param>
        /// <returns>A <see cref="DBEntity"/> of specified type</returns>
        protected abstract Task<T> ExecuteSQLObjectAsync<T>(string sqlStatement, SqlTransactionManager transactionManager) where T : DataObject;

        /// <summary>
        /// Executes a sql statement and returns a object
        /// </summary>
        /// <param name="sqlStatement">The sql statement to execute</param>
        /// <param name="dataObject">the object to parse</param>
        /// <param name="dataParameters">the parameters passed</param>
        /// <returns>A <see cref="DBEntity"/> of specified type</returns>
        protected abstract Task<T> ExecuteSQLObjectAsync<T>(string sqlStatement, IEnumerable<DataParameterBase> dataParameters, SqlTransactionManager transactionManager) where T : DataObject;

        #endregion

        #region ExecuteSQLObjectsAsync

        /// <summary>
        /// Executes a sql statement and returns a list of objects
        /// </summary>
        /// <param name="sqlStatement">The sql statement to execute</param>
        /// <returns>A list of <see cref="DBEntity"/> of specified type</returns>
        protected abstract Task<IEnumerable<T>> ExecuteSQLObjectsAsync<T>(string sqlStatement) where T : DataObject;

        /// <summary>
        /// Executes a sql statement and returns a list of objects
        /// </summary>
        /// <param name="sqlStatement">The sql statement to execute</param>
        /// <param name="dataParameters">the parameters passed</param>
        /// <returns>A list of <see cref="DBEntity"/> of specified type</returns>
        protected abstract Task<IEnumerable<T>> ExecuteSQLObjectsAsync<T>(string sqlStatement, IEnumerable<SqlParameter> dataParameters) where T : DataObject;

        /// <summary>
        /// Executes a sql statement and returns a list of objects
        /// </summary>
        /// <param name="sqlStatement">The sql statement to execute</param>
        /// <param name="dataParameters">the parameters passed</param>
        /// <returns>A list of <see cref="DBEntity"/> of specified type</returns>
        protected abstract Task<IEnumerable<T>> ExecuteSQLObjectsAsync<T>(string sqlStatement, SqlTransactionManager transactionManager) where T : DataObject;

        /// <summary>
        /// Executes a sql statement and returns a list of objects
        /// </summary>
        /// <param name="sqlStatement">The sql statement to execute</param>
        /// <param name="dataParameters">the parameters passed</param>
        /// <returns>A list of <see cref="DBEntity"/> of specified type</returns>
        protected abstract Task<IEnumerable<T>> ExecuteSQLObjectsAsync<T>(string sqlStatement, IEnumerable<SqlParameter> dataParameters, SqlTransactionManager transactionManager) where T : DataObject;

        #endregion

        #endregion

        #endregion
    }
}
