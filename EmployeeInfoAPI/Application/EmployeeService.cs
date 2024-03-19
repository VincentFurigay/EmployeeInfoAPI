using EmployeeInfoAPI.Domain;
using EmployeeInfoAPI.DTO;

namespace EmployeeInfoAPI.Application
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _repository;

        public EmployeeService(IEmployeeRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<EmployeeInformation>> GetAllEmployeeInformation()
        {
            return await _repository.GetAllEmployeeInformation();
        }

        public async Task AddEmployeeInformation(EmployeeInformation employeeInformation)
        {
              await _repository.AddEmployeeInformation(employeeInformation);   
        }

        public async Task<EmployeeInformation> GetEmployeeID(int id)
        {
            return await _repository.GetEmployeeID(id);
        }

        public async Task<bool> UpdateEmployeeInformation (int id, EmployeeInformationDTO employeeInformationDTO)
        {
           return await _repository.UpdateEmployeeInformation(id, employeeInformationDTO);
        }

        public async Task<bool> DeleteEmployee(int id)
        {
            return await _repository.DeleteEmployee(id);
        }

        public async Task<IEnumerable<EmployeeInformation>> GetEmployeeGenderMalebyId()
        {
            return await _repository.GetEmployeeGenderMalebyId();
        }

    }
}
