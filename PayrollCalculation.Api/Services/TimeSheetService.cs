﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PayrollCalculation.Api.Models;

namespace PayrollCalculation.Api.Services
{
    public class TimeSheetService
    {
        public bool TrackTime(TimeLog timeLog)
        {
            bool isValid = timeLog.WorkingHours > 0
                           && timeLog.WorkingHours <= 24;

            if (!isValid)
            {
                return false;
            }
            TimeSheets.TimeLogs.Add(timeLog);
            
            return true;
        }
    }
    
    public static class TimeSheets
    {
        public static List<TimeLog> TimeLogs { get; set; } = new List<TimeLog>();
    }
}
