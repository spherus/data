using System;

namespace Spherus.Data.Attributes
{
    /// <summary>
    /// Attribute that represents the primary key
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
    public sealed class SqlDataObjectPrimaryKey : SqlDataObject
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of <see cref="SqlDataObjectPrimaryKey"/>
        /// Default ParameterDirection is ParameterDirection.InputOutput
        /// </summary>
        /// <param name="columnName">The name of column in the database</param>
        public SqlDataObjectPrimaryKey(string columnName)
            : base(columnName)
        {
            ParameterDirection = System.Data.ParameterDirection.InputOutput;
        }

        #endregion

    }
}
