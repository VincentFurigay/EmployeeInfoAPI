using EmployeeInfoAPI.Application;
using EmployeeInfoAPI.Domain;
using EmployeeInfoAPI.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace EmployeeInfoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _service;

        public EmployeeController(IEmployeeService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<EmployeeInformation>> GetAllEmployeeInformation()
        {
            var Information = await _service.GetAllEmployeeInformation();
            return Ok(Information);
        }

        [HttpPost]

        public async Task<ActionResult> AddEmployeeInformation(EmployeeInformation employeeInformation)
        {
             await _service.AddEmployeeInformation(employeeInformation);
             return Ok(); 
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<EmployeeInformation>> GetEmployeeID (int id)
        {
            var employee = await _service.GetEmployeeID(id);
            if(employee == null) 
            {
                return BadRequest("ID IS NOT EXIST!");
            }
            return Ok(employee);
        }

        [HttpPut]
        public async Task<ActionResult> UpdateEmployeeInformation(int id, EmployeeInformationDTO employeeInformationDTO)
        {
           var employee = await _service.UpdateEmployeeInformation(id, employeeInformationDTO);
            return Ok(employee);
        }

        [HttpDelete]
        public async Task<ActionResult<bool>> DeleteEmployee(int id)
        {
            var delete = await _service.DeleteEmployee(id);
            return Ok(delete);
        }

        [HttpGet("Gender-Male")]
        public async Task<ActionResult<EmployeeInformation>> GetEmployeeGenderMalebyId()
        {
            var gender = await _service.GetEmployeeGenderMalebyId();
            return Ok(gender);
        }

        [HttpGet("Gender-Female")]
        public async Task<ActionResult<EmployeeInformation>> GetEmployeeGenderFemalebyId()
        {
            var gender = await _service.GetEmployeeGenderFemalebyId();
            return Ok(gender);
        }

        [HttpGet("Search-Firstname")]
        public async Task<ActionResult<EmployeeInformation>> GetEmployeebyFirstname(string firstname)
        {

            var f = await _service.GetEmployeebyFirstName(firstname);
            return Ok(f);
        }


    }
}
