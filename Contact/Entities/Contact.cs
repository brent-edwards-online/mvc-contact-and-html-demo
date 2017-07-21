namespace ContactMVC.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Contact
    {
        [Required]
        [Key]
        public int ContactId { get; set; }

        [Required(ErrorMessage="FirstName is a required field")]
        [StringLength(50, ErrorMessage = "FirstName must be less then 50 characters")]
        [DataType(DataType.Text)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "LastName is a required field")]
        [StringLength(50, ErrorMessage = "LastName must be less then 50 characters")]
        [DataType(DataType.Text)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email is a required field")]
        [StringLength(100, ErrorMessage = "LastName must be less then 100 characters")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is a required field")]
        [StringLength(100, ErrorMessage = "LastName must be less then 100 characters")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Gender is a required field")]
        [StringLength(1, ErrorMessage = "Gender must be M or F")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "DOB is a required field")]
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }

        [Required(ErrorMessage = "Phone is a required field")]
        [StringLength(30, ErrorMessage = "Phone must be less then 30 characters")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
    }
}