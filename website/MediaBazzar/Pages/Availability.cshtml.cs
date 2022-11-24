using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using ClassLibraryProject.Class;
using ClassLibraryProject.dbClasses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MediaBazaarWebsite.Pages
{
    public class AvailabilityModel : PageModel
    {
        public dbLoginManager dbLogin = new dbLoginManager();

        [BindProperty]
        public Employee Employee { get; set; }

        [BindProperty]
        public DateTime Unavailable { get; set; }

        [BindProperty]
        public List<Unavailability> Unavailabilities { get; set; }

        public void OnGet()
        {
            Unavailabilities = new List<Unavailability>();
            // get current user
            var userEmail = User.FindFirstValue(ClaimTypes.Email);

            Employee = dbLogin.GetEmployeeByEmail(userEmail);

            IAvailabilityManager availabilityManager = new AvailabilityManager();

            List<Unavailability> checkUnavailabilites = availabilityManager.ReadAvailability(Employee);

            /* Check Date */
            DateTime today = DateTime.Now;
            DayOfWeek day = CultureInfo.InvariantCulture.Calendar.GetDayOfWeek(today);
            if (day >= DayOfWeek.Monday && day <= DayOfWeek.Wednesday)
            {
                today = today.AddDays(3);
            }
            int week = CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(today, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
            

            foreach(Unavailability u in checkUnavailabilites)
            {
                if (u.Week > week && u.Year >= today.Year)
                {
                    Unavailabilities.Add(u);
                }
            }
            GetList();
        }
        public IActionResult OnPost()
        {
            // get current user
            var userEmail = User.FindFirstValue(ClaimTypes.Email);
            Employee = dbLogin.GetEmployeeByEmail(userEmail);

            /* Week, Day and Year based on entered date */
            int weekNumber = GetWeekOfYear(Unavailable);
            string day = Unavailable.DayOfWeek.ToString();
            int year = Unavailable.Year;

            /* Create Unavailability */
            IAvailabilityManager availabilityManager = new AvailabilityManager();

            Unavailability unavailability = new Unavailability(year, weekNumber, day, Employee);

            /* Add Unavailability to database */
            if (availabilityManager.EnterAvailability(unavailability))
            {
                ViewData["Message"] = "Unavailability Entered";
            }

            GetList();

            return Page();
        }
        public int GetWeekOfYear(DateTime time)
        {
            DayOfWeek day = CultureInfo.InvariantCulture.Calendar.GetDayOfWeek(time);
            if (day >= DayOfWeek.Monday && day <= DayOfWeek.Wednesday)
            {
                time.AddDays(3);
            }

            return CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(time, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
        }

        public List<Unavailability> GetList()
        {
            Unavailabilities = new List<Unavailability>();
            // get current user
            var userEmail = User.FindFirstValue(ClaimTypes.Email);

            Employee = dbLogin.GetEmployeeByEmail(userEmail);

            IAvailabilityManager availabilityManager = new AvailabilityManager();

            List<Unavailability> checkUnavailabilites = availabilityManager.ReadAvailability(Employee);

            /* Check Date */
            DateTime today = DateTime.Now;
            DayOfWeek day = CultureInfo.InvariantCulture.Calendar.GetDayOfWeek(today);
            if (day >= DayOfWeek.Monday && day <= DayOfWeek.Wednesday)
            {
                today = today.AddDays(3);
            }
            int week = CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(today, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);


            foreach (Unavailability u in checkUnavailabilites)
            {
                if (u.Week > week && u.Year >= today.Year)
                {
                    Unavailabilities.Add(u);
                }
            }
            return Unavailabilities;
        }
    }
}
