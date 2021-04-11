using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Content_Management_System.Models
{
    public class TrainingApplications
    {
        [Key]
        public int ApplicationId { get; set; }
        [Required(ErrorMessage = "Event Name is Required")]
        [DisplayName(" Event Name: ")]

        public string EventName { get; set; }
        [Required(ErrorMessage = "First Name is Required")]
        [DisplayName(" Last Name: ")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last Name is Required")]
        [DisplayName(" Last Name: ")]
        public string LastName { get; set; }
        [DisplayName("Email: ")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Email is Required")]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Incorrect Email Format")]
        [MaxLength(50)]

        public string email { get; set; }
    }
}