using System.Data.Common;
using System.Data.SqlClient;
using System.Configuration;

namespace AbstractFactory
{
    public class SqlServer : AbstractDataBase
    {
        private DbConnection _connection = null;
        private DbCommand _command = null;
        public override DbConnection Connection
        {
            get
            {
                if (_connection != null) return _connection;
                var connectionString = ConfigurationManager.ConnectionStrings["SQLServerConnectionString"].ConnectionString;
                _connection = new SqlConnection(connectionString);
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
                _command = new SqlCommand {Connection = (SqlConnection) Connection};
                return _command;
            }

            set { _command = value; }
        }
    }
}
