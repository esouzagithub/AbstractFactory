using System.Data.Common;

namespace AbstractFactory
{
    public abstract class AbstractDataBase
    {
        public virtual DbConnection Connection { get; set; }
        public virtual DbCommand Command { get; set; }
    }
}
