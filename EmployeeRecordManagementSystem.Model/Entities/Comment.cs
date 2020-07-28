namespace EmployeeRecordManagementSystem.Model.Entities
{
    using System;

    public class Comment
    {
        public int Id { get; set; }

        public string Note { get; set; }

        public DateTime CreatedOn { get; set; }

        public string Author { get; set; }

        public int EmployeeId { get; set; }

        public Employee Employee { get; set; }
    }
}