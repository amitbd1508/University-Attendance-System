using LogicLayer.BussinessObject;
using LogicLayer.DataLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer.BussinessLogic
{
    public class CourseHandeler
    {

        CourseDBAccess cousreDBAcess = null;
        public CourseHandeler()
        {
            cousreDBAcess = new CourseDBAccess();
        }
        // This fuction does not contain any business logic, it simply returns the 
        // list of employees, we can put some logic here if needed
        public List<Course> GetCourseStudentByTeacherIDAndCourseCode(string TeacherID,string CourseCode)
        {
            return cousreDBAcess.GetCourseStudentByTeacherIDAndCourseCode(TeacherID, CourseCode);
        }
        public bool TakeAttendanceByStudentID(string StudentID,string CourseCode)
        {
            return cousreDBAcess.TakeAttendenceByStudentID(StudentID, CourseCode);
        }
        public List<Course> GetCourseAndAttendenceByStudentID(string StudentID)
        {
            return cousreDBAcess.GetCourseAndAttendenceByStudentID(StudentID);
        }

    }
}
