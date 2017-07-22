namespace ContactMVC.Entities
{
    using System.ComponentModel.DataAnnotations;

    public class Address
    {
        [Required]
        [Key]
        public int AddressID { get; set; }

        [StringLength(50, ErrorMessage = "Maximum length is 50 characters")]
        public string Address1 { get; set; }

        [StringLength(50, ErrorMessage = "Maximum length is 50 characters")]
        public string Address2 { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "Maximum length is 20 characters")]
        public string Suburb { get; set; }

        [StringLength(20, ErrorMessage = "Maximum length is 20 characters")]
        public string City { get; set; }

        [Required]
        [StringLength(4, ErrorMessage = "Maximum length is 4 characters")]
        public string PostCode { get; set; }

        public int ContactId { get; set; }

        public virtual Contact Contact { get; set; }
    }
}