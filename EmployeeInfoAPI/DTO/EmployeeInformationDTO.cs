using System.ComponentModel.DataAnnotations;

namespace EmployeeInfoAPI.DTO
{
    public class EmployeeInformationDTO
    {
       
        public int Id { get; set; }

        [Required(ErrorMessage = "FirstName is required")]
        public string Firstname { get; set; }

        [Required(ErrorMessage = "Lastname is required")]
        public string Lastname { get; set; }

        [Required(ErrorMessage = "Contact Number is required")]
        public string ContactNumber { get; set; }

        [Required(ErrorMessage = "Email Address Number is required")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "Position is required")]
        public string Position { get; set; }

        [Required(ErrorMessage = "Gender is required")]
        public EGenderDTO Gender { get; set; }
        public DateTime DateCreated { get; set; }   
    }
    public enum EGenderDTO
    {
        Male = 0, Female = 1
    }

}
