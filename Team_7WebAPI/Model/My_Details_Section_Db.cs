using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Team_7WebAPI.Model
{
    public class My_Details_Section_Db
    {
        [Key]
        public int Employee_Id { get; set; }
        public string Password { get; set; }

        public string Full_Name { get; set; }

        public string Email_Address { get; set; }

        public long Mobile_Number { get; set; }

        public DateTime Date_Joined { get; set; }
        public string Department { get; set; }

        public int Available_Leave_Balance { get; set; }


    }
}
