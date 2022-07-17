using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Team_7WebAPI.Model;
using Team_7WebAPI.DataAccessLayer;

namespace Team_7WebAPI.Repository
{
     public interface IManager
    {
        Task<List<ManagerDetails_Db>> GetAllManager();
        Task<ManagerDetails_Db> SearchById(int Manager_ID);
        Task<int> AddNewManager(ManagerDetails_View managerDetails_View);
        Task RemoveManager(int? Employee_Id);
        Task UpdateManager(int? Employee_Id, ManagerDetails_Db managerDetails_Db);
    }
}
