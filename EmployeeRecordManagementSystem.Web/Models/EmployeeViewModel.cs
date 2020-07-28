namespace EmployeeRecordManagementSystem.Web.Models
{
    using Model.Entities;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class EmployeeViewModel
    {
        public EmployeeViewModel()
        {
            Departments = new List<Department>();
            JobTitles = new List<JobTitle>();
            Employees = new List<Employee>();
            Comments = new List<Comment>();
        }

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Range(0.0, Double.MaxValue, ErrorMessage ="The field must be positive.")]
        public decimal MonthlySalary { get; set; }

        [Required]
        [DataType(DataType.DateTime, ErrorMessage ="Invalid date")]
        public DateTime JoinedOn { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public int DepartmentId { get; set; }

        public IList<Department> Departments { get; set; }

        [Required]
        public int JobTitleId { get; set; }

        public IList<JobTitle> JobTitles { get; set; }

        public int? ManagerId { get; set; }

        public IList<Employee> Employees { get; set; }

        //public IList<string> Comments { get; set; }
        public IList<Comment> Comments { get; set; }
    }
}
