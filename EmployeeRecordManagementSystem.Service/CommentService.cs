namespace EmployeeRecordManagementSystem.Service
{
    using Data;
    using EmployeeRecordManagementSystem.Model.Entities;
    using Interfaces;
    using System.Collections.Generic;

    public class CommentService : ICommentService
    {
        private readonly ManagementSystemDbContext _context;

        public CommentService(ManagementSystemDbContext context)
        {
            _context = context;
        }

        public void Add(List<Comment> entities)
        {
            _context.Comments.AddRange(entities);
            _context.SaveChanges();
        }
    }
}
