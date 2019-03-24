using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace BusinessLayerClassLibrary
{
    public class Employee : IEmployee
    {
        //Deafult constructor
        public Employee()
        {

        }
        public int Add(int a, int b)
        {
            return a + b;
        }

        public void DeleteEmployee(int Empid)
        {
            string connString = ConfigurationManager.ConnectionStrings["AnjiSQLConnectionString"].ConnectionString;
            //Step 1:Connect to DB and Open the connection
            //string connString = "Data source=Anji\\SQLEXPRESS; Initial catalog=chanduDB;User ID=sa;Password=12345";
            SqlConnection sqlConn = new SqlConnection(connString);
            sqlConn.Open();
            //Step 2:Execute insertCommand by passing insertQuery
            string deletequery = "delete EmployeeList where EmpID='" + Empid + "'";
            SqlCommand deletecommand = new SqlCommand(deletequery, sqlConn);
            deletecommand.ExecuteNonQuery();
            //Step 3:Dispose SqlCommand and close the connection 
            deletecommand.Dispose();
            sqlConn.Close();
            
        }

        public void GetAllEmployees()
        {
            throw new NotImplementedException();
        }

        public void UpdateEmployee(int Empid)
        {
            throw new NotImplementedException();
        }

        int IEmployee.Add(int a, int b)
        {
            throw new NotImplementedException();
        }

        void IEmployee.DeleteEmployee(int Empid)
        {
            throw new NotImplementedException();
        }

        void IEmployee.GetAllEmployees()
        {
            throw new NotImplementedException();
        }

        void IEmployee.InsertEmployee(int Empid,string EmpName, int EmpAge)
        {
           
            

          
        }

        void IEmployee.UpdateEmployee(int Empid)
        {
            throw new NotImplementedException();
        }
    }
}
