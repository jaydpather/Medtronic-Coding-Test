using System;
using System.Data;
using DataLayer;

namespace BusinessLayer
{
    public class EmployeeService
    {
        public DataTable LoadEmployees()
        {
            DataTable retVal = null; //this would be a strongly-typed list of employees in a real app

            try
            {
                //a real app would use dependency injection, and only and interface would be exposed to the business layer
                var dataProvider = new DataProvider("Data Source=(localdb)\\MSSQLLocalDB;Integrated Security=True"); //real app would use config file
                retVal = dataProvider.LoadEmployees();
            }
            catch (Exception ex)
            {
                //in a real app, I would log an exception here
            }


            return retVal; //null will indicate an error case, whereas an empty table indicates success with 0 records
        }
    }
}
