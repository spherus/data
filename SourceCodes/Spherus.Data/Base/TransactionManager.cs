using System.Collections.Generic;

namespace Spherus.Data.Base
{
    public abstract class TransactionManager : DbEntity
    {
        #region Constructors

        /// <summary>
        /// Iitializes a new instance of <see cref="TransactionManager"/> class
        /// </summary>
        public TransactionManager()
        {

        }

        /// <summary>
        /// Iitializes a new instance of <see cref="TransactionManager"/> class
        /// </summary>
        /// <param name="databases">An Enumerable of <see cref="Database"/> objects</param>
        public TransactionManager(IEnumerable<Database> databases)
        {
            Databases = databases;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Collection of databases that are included in this transaction manager
        /// </summary>
        public IEnumerable<Database> Databases { get; set; }

        #endregion
    }
}
