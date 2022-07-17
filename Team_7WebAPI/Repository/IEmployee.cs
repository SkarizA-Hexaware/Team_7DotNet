using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Team_7WebAPI.Model;

namespace Team_7WebAPI.Repository
{
   public interface IEmployee
    {
        Task<List<EmployeeDetails_Db>> GetAllEmployee();
        Task<EmployeeDetails_Db> SearchById(int EmployeeId);
        Task<int> AddNewEmp(EmployeeDetails_View employeeDetails_View);
        Task RemoveEmp(int? EmployeeId);
        Task UpdateEmp(int? EmployeeId, EmployeeDetails_Db employeeDetails_Db);
    }
}
