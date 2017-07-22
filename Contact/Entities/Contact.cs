namespace ContactMVC.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Contact
    {
        [Required]
        [Key]
        public int ContactId { get; set; }

        [Required(ErrorMessage="First Name is a required field")]
        [StringLength(50, ErrorMessage = "First Name must be less then 50 characters")]
        [DataType(DataType.Text)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is a required field")]
        [StringLength(50, ErrorMessage = "Last Name must be less then 50 characters")]
        [DataType(DataType.Text)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email is a required field")]
        [StringLength(100, ErrorMessage = "Email must be less then 100 characters")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is a required field")]
        [StringLength(30, ErrorMessage = "Password must be less then 30 characters")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Gender is a required field")]
        [StringLength(1, ErrorMessage = "Gender must be M or F")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "DOB is a required field")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MM-yyyy}")]
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }

        [Required(ErrorMessage = "Phone is a required field")]
        [StringLength(30, ErrorMessage = "Phone must be less then 30 characters")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Highest Qualification is a required field")]
        [StringLength(30, ErrorMessage = "Highest Qualification must be less then 30 characters")]
        [DataType(DataType.Text)]
        public string HighestQualification { get; set; }
    }
}