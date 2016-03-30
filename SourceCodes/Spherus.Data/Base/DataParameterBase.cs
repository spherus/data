namespace Spherus.Data.Base
{
    /// <summary>
    /// DataParameterBase class. All Data Parameters should be descendants of this class
    /// </summary>
    public abstract class DataParameterBase : DbEntity
    {

        #region Constructors

        internal DataParameterBase()
        {

        }

        /// <summary>
        /// Initializes new instance of <see cref="DataParameterBase"/>
        /// </summary>
        /// <param name="name">Parameter Name</param>
        /// <param name="value">Parameter Value</param>
        public DataParameterBase(string name, object value)
            : base()
        {
            Name = name;
            Value = value;
        }

        /// <summary>
        /// Initializes new instance of <see cref="DataParameterBase"/>
        /// </summary>
        /// <param name="name">Parameter Name</param>
        /// <param name="value">Parameter Value</param>
        /// <param name="size">Size of parameter</param>
        public DataParameterBase(string name, object value, int size)
            : this(name, value)
        {
            Size = size;
        }

        #endregion

        #region Properties

        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Parameter Value
        /// </summary>
        public object Value { get; set; }

        /// <summary>
        /// Gets or Sets Parameter Size
        /// </summary>
        public int Size { get; set; }

        #endregion

    }
}
