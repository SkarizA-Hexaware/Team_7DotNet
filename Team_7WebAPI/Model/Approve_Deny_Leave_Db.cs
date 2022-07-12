using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team_7WebAPI.Model
{
    public class Approve_Deny_Leave_Db
    {
        public int Employee_Id { get; set; }
        public String Employee_Name { get; set; }
        public int Leave_Balance { get; set; }
        public DateTime Start_Date { get; set; }
        public DateTime End_Date { get; set; }
        public int Number_Of_Days { get; set; }
        public string Leave_types { get; set; }
        public string Reason { get; set; }
    }
}
