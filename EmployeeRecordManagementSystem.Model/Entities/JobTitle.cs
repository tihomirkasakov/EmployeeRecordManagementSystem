namespace EmployeeRecordManagementSystem.Model.Entities
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class JobTitle
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public bool IsActive { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}