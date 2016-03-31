using System.Reflection;

namespace Spherus.Data.Base
{
    public abstract class DataObject : DbEntity
    {
        public string GetFieldNameByPropertyName(string propertyName)
        {
            string result = null;

            DataObjectAttributeBase[] attributes = (DataObjectAttributeBase[])GetType().GetProperty(propertyName).GetCustomAttributes(typeof(DataObjectAttributeBase), true);
            if (attributes.Length > 0)
            {
                return attributes[0].ColumnName;
            }

            return result;
        }
    }
}
