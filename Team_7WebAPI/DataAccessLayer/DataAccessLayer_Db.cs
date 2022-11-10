using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Team_7WebAPI.Model;

namespace Team_7WebAPI.DataAccessLayer
{
    public class DataAccessLayer_Db : DbContext
    {
        public DataAccessLayer_Db(DbContextOptions<DataAccessLayer_Db> options) : base(options)
        {

        }
        public DbSet<EmployeeDetails_Db> employeeDetails_Dbs { get; set; }
        public DbSet<ManagerDetails_Db> managerDetails_Dbs { get; set; }

        public DbSet<LeaveDetails_Db> leaveDetails_Dbs { get; set; } 
    }
}