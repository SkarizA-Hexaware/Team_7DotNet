using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Team_7WebAPI.Model
{
    public class ManagerDetails_Db
    {
        [Key]
        [ForeignKey("Employee_ID")]
        public int Employee_ID { get; set; }
        public string Full_Name { get; set; }
        public string Email_Address { get; set; }
        public int Mobile_Number { get; set; }
    }
}
