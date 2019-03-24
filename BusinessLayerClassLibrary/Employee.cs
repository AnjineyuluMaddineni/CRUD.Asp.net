using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

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
            throw new NotImplementedException();
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
