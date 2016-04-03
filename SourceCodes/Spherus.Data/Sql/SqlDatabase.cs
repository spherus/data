using Spherus.Data.Base;
using System;
using System.Data;
using System.Data.Common;

namespace Spherus.Data.Sql
{
    /// <summary>
    /// Represents the base for all SQL Databases
    /// </summary>
    public class SqlDatabase : Database, IDisposable
    {
        /// <summary>
        /// Gets or sets the <see cref="SqlDatabase"/> Transaction
        /// </summary>
        public DbTransaction Transaction { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="DbConnection"/> Property of <see cref="SqlDatabase"/>
        /// </summary>
        public DbConnection Connection { get; set; }

        public void Dispose()
        {
            if (Connection != null && Connection.State != ConnectionState.Closed)
            {
                Connection.Close();
                Connection.Dispose();
            }
        }
    }
}
