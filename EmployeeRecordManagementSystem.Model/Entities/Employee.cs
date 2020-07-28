namespace EmployeeRecordManagementSystem.Model.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public DateTime JoinedOn { get; set; }

        public decimal MonthlySalary { get; set; }

        public int JobTitleId { get; set; }

        public JobTitle JobTitle { get; set; }

        public int DepartmentId { get; set; }

        public Department Department { get; set; }

        public int? ManagerId { get; set; }

        public Employee Manager { get; set; }

        public string Address { get; set; }

        public ICollection<Comment> Comments { get; set; }

        public bool IsActive { get; set; }
    }
}
