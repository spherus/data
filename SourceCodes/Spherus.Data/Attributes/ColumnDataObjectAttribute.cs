using Spherus.Data.Base;
using System;

namespace Spherus.Data.Attributes
{

    /// <summary>
    /// Attribute that serves as base for all column attributes
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
    public class ColumnDataObjectAttribute : DataObjectAttribute
    {

        #region Constructor
        /// <summary>
        /// Initializes a new instance of <see cref="ColumnDataObjectAttribute"/>
        /// </summary>
        public ColumnDataObjectAttribute()
        {

        }

        /// <summary>
        /// Initializes a new instance of <see cref="ColumnDataObjectAttribute"/>
        /// </summary>
        /// <param name="columnName">The name of attribute column</param>
        public ColumnDataObjectAttribute(string columnName)
        {
            ColumnName = columnName;
        }
        #endregion
    }
}
