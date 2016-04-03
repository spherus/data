using Spherus.Data.Base;
using System.Data;

namespace Spherus.Data.Attributes
{
    public class SqlDataObject : DataObjectAttribute
    {
        public ParameterDirection ParameterDirection { get; set; }

        public SqlDataObject(string columnName)
        {
            ColumnName = columnName;
        }

        public SqlDataObject(string columnName, ParameterDirection parameterDirection)
            : this(columnName)
        {
            ParameterDirection = parameterDirection;
        }
    }
}
