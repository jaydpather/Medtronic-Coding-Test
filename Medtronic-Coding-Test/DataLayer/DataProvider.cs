using System;
using System.Data;
using System.Data.SqlClient;

namespace DataLayer
{
    public class DataProvider
    {
        private string _connectionString;
        public DataProvider(string connectionString)
        {
            _connectionString = connectionString;
        }

        public DataTable LoadEmployees()
        {
            //in a real app I would use Entity Framework to map the results of the sproc to a C# object
            DataTable retVal = new DataTable();
            using (var sqlConn = new SqlConnection(_connectionString))
            {
                sqlConn.Open();
                using(var sqlCmd = new SqlCommand("exec [dbo].[getEmployees]", sqlConn))
                {
                    using (var dataReader = sqlCmd.ExecuteReader())
                    {
                        retVal.Load(dataReader);
                    }
                }
            }

            return retVal;
        }
    }
}
