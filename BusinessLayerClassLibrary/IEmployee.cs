using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayerClassLibrary
{
    public interface IEmployee
    {
        int Add(int a, int b);
        void InsertEmployee(int Empid,string EmpName, int EmpAge);
        void UpdateEmployee(int Empid);
        void GetAllEmployees();
        void DeleteEmployee(int Empid);

    }
}
