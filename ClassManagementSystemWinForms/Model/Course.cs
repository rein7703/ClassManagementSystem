using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassManagementSystemWinForms
{
    public class Course
    {
        private string _courseCode;
        private string _courseName;
        private string _courseDescription;
        private string _lecturerName;
        private string _day;
        private TimeOnly _startTime;
        private string _room;

        public Course(string courseCode, string courseName, string courseDescription, string lecturerName, string day, TimeOnly startTime, string room)
        {
            _courseCode = courseCode;
            _courseName = courseName;
            _courseDescription = courseDescription;
            _lecturerName = lecturerName;
            _day = day;
            _startTime = startTime;
            _room = room;
        }

        public string CourseCode
        {
            get { return _courseCode; }
            set { _courseCode = value; }
        }

        public string CourseName
        {
            get { return _courseName; }
            set { _courseName = value; }
        }
        
        public string Day
        {
            
                get { return _day; }
                set { _day = value; }
            
        }

        public TimeOnly StartTime
        {
            get { return _startTime; }
            set { _startTime = value; }
        }
        public string CourseDescription
        {
            get { return _courseDescription; }
            set { _courseDescription = value; }
        }
        public string LecturerName
        {
            get { return _lecturerName; }
            set
            {
                _lecturerName = value;
            }
        }
        public string Room
        {
            get { return _room; }
            set { _room = value; }
        }

        public bool createAtDatabase() {
            try
            {
                {
                    NpgsqlConnection conn = new NpgsqlConnection(ConnString.connString);
                    conn.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO \"Course\" (\"Code\", \"Name\", \"Description\", \"Lecturer\", \"Day\", \"StartTime\", \"Room\") VALUES (@code, @name, @description, @lecturer, @day, @startTime, @room)", conn);
                    cmd.Parameters.AddWithValue("code", _courseCode);
                    cmd.Parameters.AddWithValue("name", _courseName);
                    cmd.Parameters.AddWithValue("description", _courseDescription);
                    cmd.Parameters.AddWithValue("lecturer", _lecturerName);
                    cmd.Parameters.AddWithValue("day", _day);
                    cmd.Parameters.AddWithValue("startTime", _startTime);
                    cmd.Parameters.AddWithValue("room", _room);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    return true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
    }
}
