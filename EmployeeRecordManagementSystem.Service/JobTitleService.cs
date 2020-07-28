namespace EmployeeRecordManagementSystem.Service
{
    using Data;
    using Model.Entities;
    using Service.Interfaces;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Linq;

    public class JobTitleService : IJobTitleService
    {
        private readonly ManagementSystemDbContext _context;

        public JobTitleService(ManagementSystemDbContext context)
        {
            _context = context;
        }

        public IEnumerable<JobTitle> ListAll()
        {
            return _context.JobTitles.AsNoTracking().Where(x => x.IsActive).ToList();
        }
    }
}
