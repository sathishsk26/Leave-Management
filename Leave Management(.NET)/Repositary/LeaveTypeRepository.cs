using Leave_Management_.NET_.Contracts;
using Leave_Management_.NET_.Data;

namespace Leave_Management_.NET_.Repositary
{
    public class LeaveTypeRepository : GenericRepository<LeaveType>, ILeaveTypeRepository
    {
        public LeaveTypeRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
