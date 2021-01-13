using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollCalculation.Api.Models
{
    public class TimeLog
    {
        public string LastName { get; set; }
        public DateTime Date { get; set; }
        public int WorkingHours { get; set; }
    }
}
