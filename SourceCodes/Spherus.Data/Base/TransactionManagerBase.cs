using System.Collections.Generic;

namespace Spherus.Data.Base
{
    public abstract class TransactionManagerBase : DbEntity
    {
        /// <summary>
        /// Collection of databases that are included in this transaction manager
        /// </summary>
        public List<Database> Databases = new List<Database>();
    }
}
