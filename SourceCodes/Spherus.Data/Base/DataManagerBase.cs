using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Spherus.Data.Base
{
    public abstract class DataManagerBase: DbEntity
    {
        Database Database { get; set; }
    }
}
