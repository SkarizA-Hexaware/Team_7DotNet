using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Team_7WebAPI.Model;
using Team_7WebAPI.DataAccessLayer;
using Team_7WebAPI.Controllers;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Team_7WebAPI.Repository
{
    public class Manager : IManager
    {
        private readonly DataAccessLayer_Db dataAccessLayer_Db;
        private readonly IMapper mapper;

        public Manager(DataAccessLayer_Db dataAccessLayer_Db,IMapper mapper)
        {
            this.dataAccessLayer_Db = dataAccessLayer_Db;
            this.mapper = mapper;
        }
        public async Task<int> AddNewManager(ManagerDetails_View managerDetails_View)
        {
            var data = mapper.Map<ManagerDetails_Db>( managerDetails_View);
            dataAccessLayer_Db.managerDetails_Dbs.Add(data);
            await dataAccessLayer_Db.SaveChangesAsync();
            return 1;

        }

        public async Task<List<ManagerDetails_Db>> GetAllManager()
        {
            var data = await dataAccessLayer_Db.managerDetails_Dbs.ToListAsync();
            return data;
        }

        public async Task RemoveManager(int? Employee_Id)
        {
            var data = await dataAccessLayer_Db.managerDetails_Dbs.FirstOrDefaultAsync(x => x.Manager_Id == Employee_Id);
            if (data != null)
            {
                dataAccessLayer_Db.Remove(data);
            }
            await dataAccessLayer_Db.SaveChangesAsync();
        }

        public async Task<ManagerDetails_View> SearchById(int Employee_Id)
        {
            var data = await dataAccessLayer_Db.managerDetails_Dbs.FirstOrDefaultAsync(x => x.Manager_Id == Employee_Id);
            var maped = mapper.Map<ManagerDetails_View>(data);
            return maped;
        }

        public async Task UpdateManager(int? Employee_Id, ManagerDetails_Db  managerDetails_Db)
        {
            var data = await dataAccessLayer_Db.managerDetails_Dbs.FirstOrDefaultAsync(x => x.Manager_Id == Employee_Id);
            if (data != null)
            {
                data.Full_Name = managerDetails_Db.Full_Name;
                
                data.Email_Address = managerDetails_Db.Email_Address;
                data.Mobile_Number = managerDetails_Db.Mobile_Number;
                
                await dataAccessLayer_Db.SaveChangesAsync();
            }
        }
    }
}
