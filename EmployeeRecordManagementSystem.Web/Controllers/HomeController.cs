namespace EmployeeRecordManagementSystem.Web.Controllers
{
    using EmployeeRecordManagementSystem.Model.Dtos;
    using EmployeeRecordManagementSystem.Service.Interfaces;
    using EmployeeRecordManagementSystem.Web.Models;
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;

    public class HomeController : Controller
    {
        private readonly IEmployeeService _employeeService;

        public HomeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        public IActionResult Index()
        {
            List<EmployeeListDto> model = _employeeService.DtoListAll().ToList();

            return View(model);
        }

        public IActionResult Search([FromBody] string searchText)
        {
            string text = searchText.ToLower();
            List<EmployeeListDto> model = _employeeService.DtoListAll().ToList();
            model = model.Where(x => x.Name.ToLower().Contains(text) || x.Department.ToLower().Contains(text) || x.JobTitle.ToLower().Contains(text) || x.Address.ToLower().Contains(text)||(x.Manager != null && x.Manager.ToLower().Contains(text))).ToList();

            return PartialView("_EmployeeListPartial", model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
