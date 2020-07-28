namespace EmployeeRecordManagementSystem.Service.Interfaces
{
    using Model.Entities;
    using System.Collections.Generic;

    public interface IJobTitleService
    {
        IEnumerable<JobTitle> ListAll();
    }
}
