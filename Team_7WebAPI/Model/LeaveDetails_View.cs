using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Team_7WebAPI.Model
{
    public class LeaveDetails_View
    {
        [Required]
        public int Leave_ID{ get; set; }
        [Required]
        public int Number_of_Days { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime  Start_Date { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime End_Date { get; set; }
        [Required]
        public string Leave_Type { get; set; }
        [Required]
        public string Status { get; set; }
        [Required]
        public string Reason{ get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime Applied_ON{ get; set; }
        [Required]
        public string Manager_comments { get; set; }
    }
}
