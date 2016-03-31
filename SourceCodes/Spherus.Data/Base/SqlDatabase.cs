using Spherus.Data.Base;
using System.Data.Common;

namespace Spherus.Data
{
    /// <summary>
    /// Represents the base for all SQL Databases
    /// </summary>
    public class SqlDatabase : Database
    {
        /// <summary>
        /// Gets or sets the <see cref="SqlDatabase"/> Transaction
        /// </summary>
        public DbTransaction Transaction { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="DbConnection"/> Property of <see cref="SqlDatabase"/>
        /// </summary>
        public DbConnection Connection { get; set; }
    }
}
