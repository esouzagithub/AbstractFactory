using System.Configuration;
using System.Data.Common;
using System.Data.OleDb;

namespace AbstractFactory
{
    public class OleDb : AbstractDataBase
    {
        private DbConnection _connection;
        private DbCommand _command;
        public override DbConnection Connection
        {
            get
            {
                if (_connection != null) return _connection;
                var connectionString = ConfigurationManager.ConnectionStrings["SQLServerConnectionString"].ConnectionString;
                _connection = new OleDbConnection(connectionString);
                return _connection;
            }

            set
            {
                _connection = value;
            }
        }

        public override DbCommand Command
        {
            get
            {
                if (_command != null) return _command;
                _command = new OleDbCommand { Connection = (OleDbConnection)Connection };
                return _command;
            }

            set { _command = value; }
        }
    }
}
