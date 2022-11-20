using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassManagementSystemMAUIVersion;

namespace ClassManagementSystemMAUIVersion.Model
{
    public class Course
    {
        private string _courseCode;
        private string _courseName;
        private string _courseDescription;
        private List<string> _lecturerName;
        private DateTime _startDate;
        private string _room;

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

        public DateTime StartDate
        {
            get { return _startDate; }
            set { _startDate = value; }
        }
        public string CourseDescription
        {
            get { return _courseDescription; }
            set { _courseDescription = value; }
        }
        public List<string> LecturerName
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
    }
}
