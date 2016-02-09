using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AbstractFactory.Test
{
    [TestClass]
    public class TestAbstractFactory
    {
        [TestMethod]
        public void Test_Type_SQLServerDatabase()
        {
            AbstractDataBase dataBase = new SqlServer();
            Assert.IsInstanceOfType(dataBase, typeof(SqlServer));
        }

        [TestMethod]
        public void Test_Type_OleDbServerDatabase()
        {
            AbstractDataBase dataBase = new OleDb();
            Assert.IsInstanceOfType(dataBase, typeof(OleDb));
        }
    }
}
