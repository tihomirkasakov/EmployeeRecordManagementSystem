namespace EmployeeRecordManagementSystem.Model.Dtos
{
    using Entities;
    using System.Collections.Generic;

    public class EmployeeListDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Department { get; set; }

        public string JobTitle { get; set; }

        public string Manager { get; set; }

        public string Address { get; set; }
    }
}
