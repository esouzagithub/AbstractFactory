using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.Common;

namespace AbstractFactory.Test
{
    [TestClass]
    public class TestAbstractFactory
    {
        [TestMethod]
        public void Test_Type_SQLServerDatabase()
        {
            // Define tipo Sql
            AbstractDataBase dataBase = new SqlServer();
            // Atribuindo command
            DbCommand cmd = dataBase.Command;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT, DELETE, INSERT, UPDATE";
            cmd.Connection.Open();
            DbDataReader reader = cmd.ExecuteReader();
            reader.Close();
            cmd.Connection.Close();

            Assert.IsInstanceOfType(dataBase, typeof(SqlServer));
        }

        [TestMethod]
        public void Test_Type_OleDbServerDatabase()
        {
            // Define tipo OleDb
            AbstractDataBase dataBase = new OleDb();
            // Atribuindo command
            DbCommand cmd = dataBase.Command;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT, DELETE, INSERT, UPDATE";
            cmd.Connection.Open();
            DbDataReader reader = cmd.ExecuteReader();
            reader.Close();
            cmd.Connection.Close();

            Assert.IsInstanceOfType(dataBase, typeof(OleDb));
        }
    }
}
