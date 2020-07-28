namespace EmployeeRecordManagementSystem.Service.Interfaces
{
    using EmployeeRecordManagementSystem.Model.Entities;
    using System.Collections.Generic;

    public interface ICommentService
    {
        void Add(List<Comment> entities);
    }
}
