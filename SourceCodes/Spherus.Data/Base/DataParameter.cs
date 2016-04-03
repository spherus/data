namespace Spherus.Data.Base
{
    /// <summary>
    /// DataParameter base class. All Data Parameters should be descendants of this class
    /// </summary>
    public abstract class DataParameter : DbEntity
    {

        #region Constructors

        internal DataParameter()
        {

        }

        /// <summary>
        /// Initializes new instance of <see cref="DataParameter"/>
        /// </summary>
        /// <param name="name">Parameter Name</param>
        /// <param name="value">Parameter Value</param>
        public DataParameter(string name, object value)
        {
            Name = name;
            Value = value;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or Sets Parameter Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Parameter Value
        /// </summary>
        public object Value { get; set; }

        #endregion

    }
}
