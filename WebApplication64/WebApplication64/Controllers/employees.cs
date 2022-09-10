using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication64.internalinterface;
using Microsoft.EntityFrameworkCore;

namespace WebApplication64.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class employeesController : ControllerBase
    {
        private readonly EFcontext _context;

        public employeesController(EFcontext dbContext)
        {

            _context = dbContext;

        }

        [HttpGet]
        [Route("getemployees")]
        public async Task<ActionResult<employee>> Getemployee()
        {

            var emps = await _context.employees.Include(c => c.company).ToListAsync();
            return Ok(emps);
        }

        [HttpGet]
        [Route("getStudentById")]
        public async Task<ActionResult<employee>> GetEmployee(int Id)
        {
            var emp = await _context.employees.Include(c => c.company).Where(e => e.id == Id).FirstOrDefaultAsync();

            if (emp == null)
                return BadRequest("There is no employees found");

            return Ok(emp);
        }

        [HttpPost]
        [Route("addEmployee")]
        public async Task<ActionResult<employee>> AddEmployee(employee employee)
        {
            await _context.employees.AddAsync(employee);
            _context.SaveChanges();
            return Ok("");
        }

        [HttpPut]
        [Route("updateEmployee")]
        public async Task<ActionResult<employee>> UpdateEmployee(employee request)
        {   //var emp = await _context.employees(c => c.Company).Include.Where(i => i.id == request.id).FirstOrDefault();
           //   emp.name = employee.name;
            // emp.age = employee.age;
            // employees.Add(employee);

            return Ok();
        }


        [HttpDelete]
        [Route("deleteEmployee")]
        public async Task<ActionResult<employee>> DeleteEmployee(int Id)
        {
            var employee = await _context.employees.Include(c => c.company).Where(e => e.id == Id).FirstOrDefaultAsync();
            _context.Remove<employee>(employee);

            return Ok(employee);
        }
        [HttpGet]
        [Route("UpdateEmpCompany")]
        public async Task<ActionResult<employee>> UpdateEmpCompany(int Id, int countryid)
        {
            var emp = await _context.employees.Where(c => c.id == Id).FirstOrDefaultAsync();
            emp.countryid= countryid;
            _context.SaveChangesAsync();
            return Ok(emp);
        }


    }
}
