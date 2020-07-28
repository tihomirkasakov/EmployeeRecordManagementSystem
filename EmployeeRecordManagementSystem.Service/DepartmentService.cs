namespace EmployeeRecordManagementSystem.Service
{
    using Data;
    using Model.Entities;
    using Interfaces;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Linq;

    public class DepartmentService : IDepartmentService
    {
        private readonly ManagementSystemDbContext _context;

        public DepartmentService(ManagementSystemDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Department> ListAll()
        {
            return _context.Departments.AsNoTracking().Where(x => x.IsActive).ToList();
        }
    }
}
