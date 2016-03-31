using System;
using System.Data;

namespace Spherus.Data.Attributes
{
    /// <summary>
    /// Attribute that represents the simple data property
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
    public class SqlDataObjectColumn : SqlDataObject
    {

        /// <summary>
        /// Initializes a new instance of <see cref="DataField"/>
        /// Default ParameterDirection is ParameterDirection.Input
        /// </summary>
        /// <param name="columnName">The name of column in the database</param>
        public SqlDataObjectColumn(string columnName)
            : base(columnName)
        {

        }
        /// <summary>
        /// Initializes a new instance of <see cref="DataField"/>
        /// with columnName and ParameterDirection defined
        /// </summary>
        /// <param name="columnName">The name of column in the database</param>
        /// /// <param name="parameterDirection">The ParameterDirection used in queries</param>
        public SqlDataObjectColumn(string columnName, ParameterDirection parameterDirection)
            : base(columnName, parameterDirection)
        {

        }

    }
}
