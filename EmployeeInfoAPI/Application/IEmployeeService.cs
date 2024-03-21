using EmployeeInfoAPI.Domain;
using EmployeeInfoAPI.DTO;

namespace EmployeeInfoAPI.Application
{
        public interface IEmployeeService
        {
            Task<IEnumerable<EmployeeInformation>> GetAllEmployeeInformation();
            Task AddEmployeeInformation(EmployeeInformation employeeInformation);
            Task<EmployeeInformation> GetEmployeeID(int id);
            Task<bool> UpdateEmployeeInformation(int id, EmployeeInformationDTO employeeInformationDTO);
            Task <bool> DeleteEmployee(int id);
            Task<IEnumerable<EmployeeInformation>> GetEmployeeGenderMalebyId();
            Task<IEnumerable<EmployeeInformation>> GetEmployeeGenderFemalebyId();
    }
}
