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
        public DataAccessLayer_Db(DbContextOptions<DataAccessLayer_Db> options): base(options)
        {

        }
        public DbSet<My_Details_Section_Db> my_Details_Section_Dbs { get; set; }  
        public DbSet<Manager_Details_Section_Db> manager_Details_Section_Dbs { get; set; }

        public  DbSet<My_Leave_Application_Section_Db> My_Leave_Application_Section_Dbs { get; set; }
    }
}
