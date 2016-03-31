using System.Data;

namespace Spherus.Data.Base
{
    public class SqlTransactionManager : TransactionManagerBase
    {

        #region Constructors

        ///// <summary>
        ///// Iitializes a new instance of <see cref="SqlTransactionManager"/> class
        ///// </summary>
        //public SqlTransactionManager()
        //{

        //}

        /// <summary>
        /// Iitializes a new instance of <see cref="TransactionManager"/> class
        /// </summary>
        /// <param name="transactionIsolationLevel"><see cref="System.Data.IsolationLevel"/> of manager transactions</param>
        public SqlTransactionManager(IsolationLevel isolationLevel = IsolationLevel.ReadCommitted)
        {
            IsolationLevel = isolationLevel;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets isolation level of transaction manager
        /// </summary>
        public IsolationLevel IsolationLevel { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Starts transaction for all manager databases with <see cref="TransactionManager"/> specified isolation level
        /// </summary>
        public void BeginTransaction()
        {
            foreach (SqlDatabase database in Databases)
            {
                if (database.Transaction == null)
                {
                    database.Transaction = database.Connection.BeginTransaction(IsolationLevel);
                }
            }
        }

        /// <summary>
        /// Commits transaction for all manager databases
        /// </summary>
        public void CommitTransaction()
        {
            foreach (SqlDatabase database in Databases)
            {
                database.Transaction.Commit();
                database.Transaction.Dispose();
                database.Transaction = null;
            }
        }

        /// <summary>
        /// Rollbacks transaction for all manager databases
        /// </summary>
        public void RollbackTransaction()
        {
            foreach (SqlDatabase database in Databases)
            {
                if (database.Transaction != null)
                {
                    database.Transaction.Rollback();
                    database.Transaction.Dispose();
                    database.Transaction = null;
                }
            }
        }

        #endregion

    }
}
