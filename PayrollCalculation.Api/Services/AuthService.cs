using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PayrollCalculation.Api.Services
{
    public class AuthService
    {
        public AuthService()
        {
            Employees = new List<string>()
            {
                "Иванов",
                "Петров",
                "Валериков",
            };
        }
        
        public List<string> Employees { get; private set; }
        
        public bool Login(string lastName)
        {
            if (string.IsNullOrWhiteSpace(lastName)) return false;
            var isEmployeeExist = Employees.Contains(lastName);
            {
                UserSession.Sessions.Add(lastName);
            }
            return isEmployeeExist;
        }
    }

    public static class UserSession
    {
        static UserSession()
        {
            Sessions = new HashSet<string>();
        }
        public static HashSet<string> Sessions { get; set; }
    }
}
