namespace EmployeeRecordManagementSystem.Service.Interfaces
{
    using Model.Dtos;
    using Model.Entities;
    using System.Collections.Generic;

    public interface IEmployeeService
    {
        Employee GetById(int id);

        IEnumerable<Employee> ListAll();

        IEnumerable<EmployeeListDto> DtoListAll();

        int Add(Employee entity);

        int MarkAsDeleted(int id);
    }
}
