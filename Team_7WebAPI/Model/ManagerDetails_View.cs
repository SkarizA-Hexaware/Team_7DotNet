using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Team_7WebAPI.Model
{
    public class ManagerDetails_View
    {
        [Required]
        public int Employee_ID { get; set; }
        [Required]
        public string Full_Name { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email_Address { get; set; }
        [Required]
        public int Mobile_Number { get; set; }
    }
}
