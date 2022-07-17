using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Team_7WebAPI.DataAccessLayer;
using Team_7WebAPI.Model;
using AutoMapper;

namespace Team_7WebAPI.Repository
{
    public class Employee : IEmployee
    {
        private readonly DataAccessLayer_Db dataAccessLayer_Db;
        private readonly IMapper mapper;

        public Employee(DataAccessLayer_Db dataAccessLayer_Db,IMapper mapper)
        {
            this.dataAccessLayer_Db = dataAccessLayer_Db;
            this.mapper = mapper;
        }
        public async Task<int> AddNewEmp(EmployeeDetails_View employeeDetails_View)
        {
            var data = mapper.Map<EmployeeDetails_Db>(employeeDetails_View);
            dataAccessLayer_Db.employeeDetails_Dbs.Add(data);
            await dataAccessLayer_Db.SaveChangesAsync();
            return 1;

        }

        public async Task<List<EmployeeDetails_Db>> ShowAllEmployee()
        {
            var data = await dataAccessLayer_Db.employeeDetails_Dbs.ToListAsync();
            return data;
        }

        public async Task RemoveEmp(int? Employee_Id)
        {
            var data = await dataAccessLayer_Db.employeeDetails_Dbs.FirstOrDefaultAsync(x => x.Employee_Id == Employee_Id);
            if (data != null)
            {
                dataAccessLayer_Db.Remove(data);
            }
            await dataAccessLayer_Db.SaveChangesAsync();
        }

        public async Task<EmployeeDetails_Db> SearchById(int Employee_Id)
        {
            var data = await dataAccessLayer_Db.employeeDetails_Dbs.FirstOrDefaultAsync(x => x.Employee_Id == Employee_Id);
            var maped = mapper.Map<EmployeeDetails_Db>(data);
            return data;
        }

        public async Task UpdateEmp(int? Employee_Id,EmployeeDetails_Db employeeDetails_Db)
        {
            var data = await dataAccessLayer_Db.employeeDetails_Dbs.FirstOrDefaultAsync(x => x.Employee_Id == Employee_Id);
            if (data != null)
            {
                data.Full_Name = employeeDetails_Db.Full_Name;
                data.Email_Address = employeeDetails_Db.Email_Address;
                data.Mobile_Number = employeeDetails_Db.Mobile_Number;
                data.Date_Joined = employeeDetails_Db.Date_Joined;
                data.Department = employeeDetails_Db.Department;
                data.Available_Leave_Balance = employeeDetails_Db.Available_Leave_Balance;
                await  dataAccessLayer_Db.SaveChangesAsync();
            }
        }

    }
}
