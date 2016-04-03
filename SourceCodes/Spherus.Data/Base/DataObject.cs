using System.Reflection;

namespace Spherus.Data.Base
{
    public abstract class DataObject : DbEntity
    {
        public string GetFieldNameByPropertyName(string propertyName)
        {
            string result = null;

            DataObjectAttribute[] attributes = (DataObjectAttribute[])GetType().GetProperty(propertyName).GetCustomAttributes(typeof(DataObjectAttribute), true);
            if (attributes.Length > 0)
            {
                return attributes[0].ColumnName;
            }

            return result;
        }
    }
}
