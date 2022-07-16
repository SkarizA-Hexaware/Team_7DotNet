using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Team_7WebAPI.Model;

namespace Team_7WebAPI.Helper
{
    public class ApplicationMapper : Profile
    {
        public ApplicationMapper()
        {
            CreateMap<EmployeeDetails_View, EmployeeDetails_Db>().ReverseMap();
            CreateMap<ManagerDetails_View, ManagerDetails_Db>().ReverseMap();
            CreateMap<LeaveDetails_View, LeaveDetails_Db>().ReverseMap();
        }
    }
}
