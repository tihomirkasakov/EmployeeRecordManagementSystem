namespace EmployeeRecordManagementSystem.Service
{
    using EmployeeRecordManagementSystem.Data;
    using EmployeeRecordManagementSystem.Model.Dtos;
    using EmployeeRecordManagementSystem.Model.Entities;
    using Interfaces;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Linq;

    public class EmployeeService : IEmployeeService
    {
        private readonly ManagementSystemDbContext _context;

        public EmployeeService(ManagementSystemDbContext context)
        {
            _context = context;
        }

        public Employee GetById(int id)
        {
            var entity = _context.Employees.AsNoTracking().Include(x => x.Department).Include(x => x.JobTitle).Include(x => x.Manager).Include(x=>x.Comments).Where(x => x.Id == id).FirstOrDefault();

            return entity;
        }

        public IEnumerable<Employee> ListAll()
        {
            return _context.Employees.AsNoTracking().Where(x=>x.IsActive).ToList();
        }

        public IEnumerable<EmployeeListDto> DtoListAll()
        {
            List<Employee> entities = _context.Employees.AsNoTracking().Include(x => x.Department).Include(x => x.JobTitle).Include(x => x.Manager).Where(x=>x.IsActive).ToList();
            List<EmployeeListDto> result = new List<EmployeeListDto>();
            foreach (Employee entity in entities)
            {
                result.Add(MapToDto(entity));
            }

            return result;
        }

        private EmployeeListDto MapToDto(Employee entity)
        {
            EmployeeListDto dto = new EmployeeListDto()
            {
                Id = entity.Id,
                Name = entity.Name,
                Department = entity.Department.Name,
                JobTitle = entity.JobTitle.Name,
                Manager = entity.Manager?.Name,
                Address = entity.Address
            };
            return dto;
        }

        public int Add(Employee entity)
        {
            _context.Employees.Add(entity);
            _context.SaveChanges();
            return entity.Id;
        }

        public int MarkAsDeleted(int id)
        {
            Employee entity = GetById(id);
            entity.IsActive = false;
            _context.Entry(entity).State = EntityState.Modified;
            return _context.SaveChanges();
        }
    }
}
