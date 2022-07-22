using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Team_7WebAPI.Model;

namespace Team_7WebAPI.Repository
{
   public interface IEmployee
    {
        Task<List<EmployeeDetails_Db>> ShowAllEmployee();
        Task<EmployeeDetails_Db> SearchById(int Employee_Id);
        Task<int> AddNewEmp(EmployeeDetails_Db employeeDetails_Db);
        Task RemoveEmp(int? Employee_Id);
        Task UpdateEmp(int? Employee_Id, EmployeeDetails_Db employeeDetails_Db);

        Task<EmployeeDetails_Db> Login(string Email_Address, string Password);

    }
}
