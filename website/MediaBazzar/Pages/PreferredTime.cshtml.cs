using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using ClassLibrary1;
using ClassLibraryProject;
using ClassLibraryProject.Class;
using ClassLibraryProject.dbClasses;
using ClassLibraryProject.Enum;
using ClassLibraryProject.ManagmentClasses;
using MediaBazzar.Pages;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MySql.Data.MySqlClient;
using Employee = ClassLibraryProject.Class.Employee;

namespace MediaBazaarWebsite.Pages
{
    [Authorize]
    public class PreferedtimeModel : PageModel
    {
        [BindProperty]
        [Required]
        public bool Prefered { get; set; }

        public dbLoginManager dbLogin = new dbLoginManager();

        public int prefered;

        [BindProperty]
        public string Preferred { get; set; }

        [BindProperty]
        [Required]
        public string WeekDay { get; set; }

        [BindProperty]
        [Required]
        public string shift { get; set; }

        public SelectList Prefereds { get; set; }

        public Days Day = Days.Monday;
        public Shifts Shift = Shifts.Morning;
        public Shifts Shift2 = Shifts.Morning;

        public List<PreferedWorkTime> pwt { get; set; }

        private CookieOptions cookieOptions = new CookieOptions
        {
            Expires = DateTime.Now.AddMinutes(5)
        };

        public IActionResult OnGetLogout()
        {
            HttpContext.Session.Remove("User");
            return new RedirectToPageResult("Login");
        }

        public void OnGet()
        {

        }


        public bool ShiftIncrease()
        {
            try
            {
                Shift++;
                return true;
            }
            catch { return true; }
        }

        public int IsWorkingToday()
        {
            var userEmail = User.FindFirstValue(ClaimTypes.Email);

            Employee ee = dbLogin.GetEmployeeByEmail(userEmail);

            MySqlConnection conn = Utils.GetConnection();

            string sql = $"SELECT `Prefered` FROM `preferedtime` WHERE `EmployeeID` = {ee.EmployeeID} and `Day`= '{Day}' and Shift = '{Shift2}'";

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                if (Shift2 == Shifts.Evening)
                {
                    Shift2 = Shifts.Morning;
                    Day++;
                }
                else 
                {
                    Shift2++;
                }

                while (reader.Read())
                {
                    prefered = Convert.ToInt16(reader[0]);
                    return prefered;
                }
                prefered = 2;
            }
            catch (MySqlException msqEx)
            {
                Debug.WriteLine(msqEx);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

            return 2;
        }

        public void OnPost()
        {
            DBPreferredShift dbPreferredShift = new DBPreferredShift();
            PreferredShiftManagment prm = new PreferredShiftManagment(dbPreferredShift);

            var userEmail = User.FindFirstValue(ClaimTypes.Email);

            Employee ee = dbLogin.GetEmployeeByEmail(userEmail);

            if (Preferred == "Not specified")
            {
                MySqlConnection conn = Utils.GetConnection();
                string sql = $"DELETE FROM preferedtime Where day = '{WeekDay}' AND shift= '{shift}' AND employeeID = {ee.EmployeeID}";

                try
                {
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    conn.Open();

                    int numCreatedRows = cmd.ExecuteNonQuery();
                }
                catch (MySqlException msqEx)
                {
                    Debug.WriteLine(msqEx);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                }
                finally
                {
                    if (conn != null)
                    {
                        conn.Close();
                    }
                }
            }

            else if (Preferred == "Preferred")
            {
                prm.PreferAShift(WeekDay, shift, ee, true);
            }
            else 
            { 
                prm.PreferAShift(WeekDay, shift, ee, false); 
            }
        }
    }
}
