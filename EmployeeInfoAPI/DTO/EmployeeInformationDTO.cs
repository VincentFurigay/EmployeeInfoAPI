using System.ComponentModel.DataAnnotations;

namespace EmployeeInfoAPI.DTO
{
    public class EmployeeInformationDTO
    {
        private int _gender;
        private int _isActive;
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
        public int Gender
        {
            get => _gender;

            set
            {
                if (value == 0 || value == 1)
                {
                    _gender = value;
                }
                else
                {
                    throw new ArgumentException("Invalid gender value.");
                }
            }
        }
        public int IsActive
        {
            get => _isActive;

            set
            {
                if (value == 0 || value == 1)
                {
                    _isActive = value;
                }
                else
                {
                    throw new ArgumentException("Invalid isActive value.");
                }
            }
        }
        public DateTime DateCreated { get; set; }   
    }

}
