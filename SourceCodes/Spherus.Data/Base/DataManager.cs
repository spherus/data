namespace Spherus.Data.Base
{
    public abstract class DataManager : DbEntity
    {
        Database Database { get; set; }
    }
}
