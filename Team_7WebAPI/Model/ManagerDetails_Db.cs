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
        public int Manager_Id { get; set; }
      
        
        public string Full_Name { get; set; }
        public string Email_Address { get; set; }
        public long Mobile_Number { get; set; }
    }
}
