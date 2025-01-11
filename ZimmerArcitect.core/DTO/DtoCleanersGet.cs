using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZimmerArcitect.core.DTO
{
    public class DtoCleanersGet
    { 
        public string Tz { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int Total_for_an_hour_of_work { get; set; }
        public int Total_salary { get; set; }
        public int Total_working_hours { get; set; }
    }
}
