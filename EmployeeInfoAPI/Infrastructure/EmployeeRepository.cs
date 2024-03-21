using EmployeeInfoAPI.Application;
using EmployeeInfoAPI.Domain;
using EmployeeInfoAPI.DTO;
using Microsoft.EntityFrameworkCore;

namespace EmployeeInfoAPI.Infrastructure
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeContext _employeeContext;

        public EmployeeRepository(EmployeeContext context)
        {
            _employeeContext = context;
        }

        public async Task<IEnumerable<EmployeeInformation>> GetAllEmployeeInformation()
        {
            return await _employeeContext.EmployeeInformations.OrderBy(e => e.Id).ToListAsync();
        }

        public async Task AddEmployeeInformation(EmployeeInformation employeeInformation)
        {
            _employeeContext.EmployeeInformations.Add(employeeInformation);
            await _employeeContext.SaveChangesAsync();
            
        }

        public async Task <EmployeeInformation> GetEmployeeID (int id)
        {
            return await _employeeContext.EmployeeInformations.Where(e => e.Id == id).SingleOrDefaultAsync();
        }

        public async Task<bool> UpdateEmployeeInformation(int id, EmployeeInformationDTO employeeInformationDTO)
        {
            EmployeeInformation employeeInformation = await _employeeContext.EmployeeInformations.FindAsync(id);
            if (employeeInformation != null)
            {
                employeeInformation.Firstname = employeeInformationDTO.Firstname;
                employeeInformation.Lastname = employeeInformationDTO.Lastname;
                employeeInformation.ContactNumber = employeeInformationDTO.ContactNumber;
                employeeInformation.EmailAddress = employeeInformationDTO.EmailAddress;
                employeeInformation.Position = employeeInformationDTO.Position;
                employeeInformation.Gender = employeeInformationDTO.Gender;
                employeeInformation.DateCreated = DateTime.Now;
            }
            return await _employeeContext.SaveChangesAsync() > 0;
        }




        public async Task<bool> DeleteEmployee (int id)
        {
            var employee = _employeeContext.EmployeeInformations.Where(e => e.Id == id).First();

             _employeeContext.EmployeeInformations.Remove(employee);

            return await _employeeContext.SaveChangesAsync() > 0;
        }

        public async Task<IEnumerable<EmployeeInformation>> GetEmployeeGenderMalebyId()
        {
            return await _employeeContext.EmployeeInformations.Where(g => g.Gender == 0).OrderBy(e => e.Id).ToListAsync();

        }

        public async Task<IEnumerable<EmployeeInformation>> GetEmployeeGenderFemalebyId()
        {
            return await _employeeContext.EmployeeInformations.Where(g => g.Gender == 1).OrderBy(e => e.Id).ToListAsync();
        }


    }
}   
