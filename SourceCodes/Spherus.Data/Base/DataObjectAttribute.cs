using System;

namespace Spherus.Data.Base
{
    public class DataObjectAttribute: Attribute
    {
        /// <summary>
        /// ColumnName property
        /// </summary>
        public string ColumnName { get; set; }
    }
}
