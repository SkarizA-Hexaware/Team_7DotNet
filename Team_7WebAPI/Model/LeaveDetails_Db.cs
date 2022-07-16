using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Team_7WebAPI.Model
{
    public class LeaveDetails_Db
    {
        [Key]
        public int Leave_ID { get; set; }
        [ForeignKey("Employee_Id")]
        public int EmployeeId { get; set; }
        public int Number_of_Days { get; set; }
        public DateTime Start_Date { get; set; }
        public DateTime End_Date { get; set; }
        public string Leave_Type { get; set; }
        public string Status { get; set; }
        public string Reason { get; set; }
        public DateTime Applied_ON { get; set; }
        public string Manager_comments { get; set; }
    }

    
}
