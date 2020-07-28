namespace EmployeeRecordManagementSystem.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Model.Entities;
    using Models;
    using Service.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;
        private readonly IJobTitleService _jobTitleService;
        private readonly IDepartmentService _departmentService;
        private readonly ICommentService _commentService;

        public EmployeeController(IEmployeeService employeeService, IJobTitleService jobTitleService, IDepartmentService departmentService, ICommentService commentService)
        {
            _employeeService = employeeService;
            _jobTitleService = jobTitleService;
            _departmentService = departmentService;
            _commentService = commentService;
        }

        [HttpGet]
        public IActionResult Add()
        {
            EmployeeViewModel model = new EmployeeViewModel();

            model.JobTitles = _jobTitleService.ListAll().ToList();
            model.Departments = _departmentService.ListAll().ToList();
            model.Employees = _employeeService.ListAll().ToList();
            model.JoinedOn = DateTime.Now;
            model.Comments.Add(new Comment());
            return View(model);
        }

        [HttpPost]
        public IActionResult Add(EmployeeViewModel model)
        {
            model.JobTitles = _jobTitleService.ListAll().ToList();
            model.Departments = _departmentService.ListAll().ToList();
            model.Employees = _employeeService.ListAll().ToList();

            if (!ModelState.IsValid)
            {
                return View(model);
            }
            Employee entity = MapToEntity(model);
            int employeeId = _employeeService.Add(entity);
            if (employeeId < 1)
            {
                return View(model);
            }
            List<Comment> comments = model.Comments.ToList();
            comments = comments.Select(c => { c.CreatedOn = DateTime.UtcNow; c.EmployeeId = employeeId; return c; }).ToList();
            _commentService.Add(comments);

            return RedirectToAction("Index", "Home");
        }

        public IActionResult Details(int employeeId)
        {
            EmployeeViewModel model = new EmployeeViewModel();
            model.JobTitles = _jobTitleService.ListAll().ToList();
            model.Departments = _departmentService.ListAll().ToList();
            model.Employees = _employeeService.ListAll().ToList();

            Employee employee = _employeeService.GetById(employeeId);
            MapToViewModel(model, employee);
            model.Comments = employee.Comments.ToList();

            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(EmployeeViewModel model)
        {
            model.JobTitles = _jobTitleService.ListAll().ToList();
            model.Departments = _departmentService.ListAll().ToList();
            model.Employees = _employeeService.ListAll().ToList();

            if (!ModelState.IsValid)
            {
                return View("Details",model);
            }

            int result = _employeeService.MarkAsDeleted(model.Id);

            Employee entity = MapToEntity(model);
            int employeeId = _employeeService.Add(entity);
            if (employeeId < 1)
            {
                return View(model);
            }
            List<Comment> comments = model.Comments.ToList();

            comments = comments.Select(c => { c.CreatedOn = DateTime.UtcNow; c.EmployeeId = employeeId; return c; }).ToList();
            _commentService.Add(comments);

            return RedirectToAction("Index","Home");
        }

        [HttpPost]
        public JsonResult Delete([FromBody]int employeeId)
        {
            int result =_employeeService.MarkAsDeleted(employeeId);
            return Json(new { });
        }

        private Employee MapToEntity(EmployeeViewModel model)
        {
            Employee entity = new Employee()
            {
                Name = model.Name,
                JoinedOn = model.JoinedOn,
                MonthlySalary = model.MonthlySalary,
                JobTitleId = model.JobTitleId,
                DepartmentId = model.DepartmentId,
                ManagerId = model.ManagerId,
                Address = model.Address,
                IsActive = true
            };
            return entity;
        }

        private void MapToViewModel(EmployeeViewModel model, Employee employee)
        {
            model.Id = employee.Id;
            model.Name = employee.Name;
            model.MonthlySalary = employee.MonthlySalary;
            model.JoinedOn = employee.JoinedOn;
            model.Address = employee.Address;
            model.DepartmentId = employee.DepartmentId;
            model.JobTitleId = employee.JobTitleId;
            model.ManagerId = employee.ManagerId;
        }
    }
}
