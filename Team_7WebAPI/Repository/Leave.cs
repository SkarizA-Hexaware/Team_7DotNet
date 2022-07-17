using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Team_7WebAPI.DataAccessLayer;
using Team_7WebAPI.Model;


namespace Team_7WebAPI.Repository
{
    public class Leave : ILeave
    {
        private readonly DataAccessLayer_Db dataAccessLayer_Db;
        private readonly IMapper mapper;

        public Leave(DataAccessLayer_Db dataAccessLayer_Db,IMapper mapper)
        {
            this.dataAccessLayer_Db = dataAccessLayer_Db;
            this.mapper = mapper;
        }
        public int ManagerState(int? id,LeaveDetails_View leaveDetails_View)
        {
            var data = dataAccessLayer_Db.leaveDetails_Dbs.Where(x => x. Leave_ID == id).FirstOrDefault();
            if (data != null)
            {
                data.Manager_comments = leaveDetails_View.Manager_comments;
                data.Status = leaveDetails_View.Status;
                dataAccessLayer_Db.SaveChanges();
            }

            return 1;
        }

        public async Task<int> NewLeave(LeaveDetails_View leaveDetails_View)
        {
            var data = mapper.Map<LeaveDetails_Db>(leaveDetails_View);
            await dataAccessLayer_Db.leaveDetails_Dbs.AddAsync(data);
            await dataAccessLayer_Db.SaveChangesAsync();

            return 1;

        }

        public List<LeaveDetails_View> ShowAllLeaves(int? id)
        {
            var all_leaves = dataAccessLayer_Db.leaveDetails_Dbs.Where(x => x.Leave_ID == id);
            var leaves = mapper.Map<List<LeaveDetails_View>>(all_leaves);
            return leaves;

        }

    }
}
