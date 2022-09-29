using AutoMapper;
using Leave_Management_.NET_.Data;
using Leave_Management_.NET_.Models;

namespace Leave_Management_.NET_.Configuration
{
    public class MapperConfig:Profile
    {
        public MapperConfig()
        {
            CreateMap<LeaveType, LeaveTypeViewModel>().ReverseMap();
        }
    }
}
