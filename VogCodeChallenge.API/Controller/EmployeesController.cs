using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VogCodeChallenge.API.Models;

namespace VogCodeChallenge.API.Controller
{
    [ApiController]
    public class EmployeesController
    {
        IList<Employees> emplst;
        public EmployeesController()
        {
            emplst = Enumerable.Range(1, 5).Select(index => new Employees
            {
                FirstName = "veena" + index,
                LastName = "kb" + index,
                JobTitle = "developer" + index,
                Address = "Bangalore" + index,
                DepartmentId = index,
            })
               .ToArray();
        }

        [HttpGet]
        [Route("api/[Controller]")]
        //[ActionName("GetAll")]
        public IEnumerable<Employees> GetAll()
        {
            return emplst;
        }

        [HttpGet("{departmentId}")]
        [Route("api/[action]")]
        [ActionName("employees/department/{departmentId}")]
        public Employees GetByDepartment(int departmentId)
        {
            var emp = emplst.Where(e => e.DepartmentId == departmentId).FirstOrDefault();
            if (emp == null)
            {
                return null;
            }
            return emp;
        }

        [HttpGet]
        [Route("api/[Controller]/[action]")]
        //[ActionName("ListAll")]
        public IList<Employees> ListAll()
        {
            return emplst;
        }
    }
}
