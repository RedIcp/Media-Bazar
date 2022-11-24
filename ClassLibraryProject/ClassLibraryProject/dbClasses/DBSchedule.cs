using ClassLibraryProject.Class;
using ClassLibraryProject.dbClasses.IDB;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace ClassLibraryProject.dbClasses
{
    public class DBSchedule: IDBSchedule
    {
        public string UPDATE_SCHEDULE = "UPDATE schedule SET Morning = @Morning, Afternoon = @Afternoon, Evening = @Evening WHERE Day = @Day AND Department = @Department AND Week = @Week AND Year = @Year;";
        public string CREATE_WEEK = "INSERT INTO `schedule` (`Department`, `Year`, `Week`, `Day`, `Morning`, `Afternoon`, `Evening`) VALUES (@Department, @Year, @Week, 'Monday', '0', '0', '0'), (@Department,  @Year, @Week, 'Tuesday', '0', '0', '0'), (@Department,  @Year, @Week, 'Wednesday', '0', '0', '0'), (@Department,  @Year, @Week, 'Thursday', '0', '0', '0'), (@Department,  @Year, @Week, 'Friday', '0', '0', '0'), (@Department,  @Year, @Week, 'Saturday', '0', '0', '0'), (@Department,  @Year, @Week, 'Sunday', '0', '0', '0');";
        public string GET_ALL_SCHEDULES = "SELECT * FROM Schedule;";

        private List<Schedule> schedules;

        public List<Schedule> GetSchedules()
        {
            return schedules;
        }

        public DBSchedule()
        {
            schedules = new List<Schedule>();
            GetAllSchedules();
        }

        //Read
        private void GetAllSchedules()
        {
            schedules.Clear();

            MySqlConnection conn = Utils.GetConnection();

            string sql = GET_ALL_SCHEDULES;


            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                Schedule schedule;

                while (reader.Read())
                {
                    string department = reader.GetString("Department");
                    int year = reader.GetInt32("Year");
                    int week = reader.GetInt32("Week");
                    string day = reader.GetString("Day");
                    int morningAmount = reader.GetInt32("Morning");
                    int afternoonAmount = reader.GetInt32("Afternoon");
                    int eveningAmount = reader.GetInt32("Evening");

                    schedule = new Schedule(department, year, week, day, morningAmount, afternoonAmount, eveningAmount);
                    schedules.Add(schedule);
                }
            }
            catch (Exception)
            {
            }
            finally
            {
                conn.Close();
            }
        }

        //Update
        public bool UpdateSchedule(string department, int year, int week, string day, int morningAmount, int afternoonAmount, int eveningAmount)
        {
            MySqlConnection conn = Utils.GetConnection();
            string sql = UPDATE_SCHEDULE;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Department", department);
                cmd.Parameters.AddWithValue("@Year", year);
                cmd.Parameters.AddWithValue("@Week", week);
                cmd.Parameters.AddWithValue("@Day", day);
                cmd.Parameters.AddWithValue("@Morning", morningAmount);
                cmd.Parameters.AddWithValue("@Afternoon", afternoonAmount);
                cmd.Parameters.AddWithValue("@Evening", eveningAmount);               
                
                conn.Open();

                int numAffectedRows = cmd.ExecuteNonQuery();

                if (numAffectedRows > 0)
                {
                    foreach(Schedule schedule in schedules)
                    {
                        if(schedule.Department == department && schedule.Year == year && schedule.Week == week && schedule.Day == day)
                        {
                            schedule.MorningAmount = morningAmount;
                            schedule.AfternoonAmount = afternoonAmount;
                            schedule.EveningAmount = eveningAmount;
                        }
                    }
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        //Create
        public bool CreateWeek(string department, int year, int week)
        {
            MySqlConnection conn = Utils.GetConnection();

            string sql = CREATE_WEEK;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Department", department);
                cmd.Parameters.AddWithValue("@Year", year);
                cmd.Parameters.AddWithValue("@Week", week);
                conn.Open();

                int numAffectedRows = cmd.ExecuteNonQuery();

                if (numAffectedRows > 0)
                {
                    Schedule schedule2 = new Schedule(department, year, week, "Monday");
                    Schedule schedule3 = new Schedule(department, year, week, "Tuesday");
                    Schedule schedule4 = new Schedule(department, year, week, "Wednesday");
                    Schedule schedule5 = new Schedule(department, year, week, "Thursday");
                    Schedule schedule6 = new Schedule(department, year, week, "Friday");
                    Schedule schedule7 = new Schedule(department, year, week, "Saturday");
                    Schedule schedule1 = new Schedule(department, year, week, "Sunday");

                    schedules.Add(schedule1);
                    schedules.Add(schedule2);
                    schedules.Add(schedule3);
                    schedules.Add(schedule4);
                    schedules.Add(schedule5);
                    schedules.Add(schedule6);
                    schedules.Add(schedule7);

                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
