using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Team_7WebAPI.Model
{
    public class Manager_Details_Section_Db
    {
        [Key]
        public int Employee_ID { get; set; }
        public string Full_Name { get; set; }
        public string Email_Address { get; set; }
        public int Mobile_Number { get; set; }
    }
}
