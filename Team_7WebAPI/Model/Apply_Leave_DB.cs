using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team_7WebAPI.Model
{
    public class Apply_Leave_DB
    {
        public DateTime Start_Date { get; set; }
        public DateTime End_Date { get; set; }
        public int Number_of_Days { get; set; }
        public String Leave_Type { get; set; }
        public String Leave_Reason { get; set; }

    }
}
