using System.ComponentModel.DataAnnotations;

namespace EmployeeInfoAPI.Domain
{
    public class EmployeeInformation
    {
        private int _gender;
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
                if(value == 0 || value == 1)
                {
                    _gender = value;
                }
                else
                {
                    throw new ArgumentException("Invalid gender value.");
                }
            }
        }

        public DateTime DateCreated { get; set; }
    }

}
