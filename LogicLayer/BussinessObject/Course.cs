using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer.BussinessObject
{
    public class Course
    {
        public int Id {  get; set; }
        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public string StudentID { get; set; }
        public string TeacherID { get; set; }
        public int AttendanceCounter { get; set; }
        public string Trimister { get; set; }

    }
}
