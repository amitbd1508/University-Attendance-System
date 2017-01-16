using LogicLayer.BussinessLogic;
using LogicLayer.BussinessObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer.DataLogic
{
    public class CourseDBAccess
    {
        internal List<Course> GetCourseStudentByTeacherIDAndCourseCode(string TeacherID,string CourseCode)
        {
            List<Course> listofStudent = new List<Course>();
            
            SqlParameter[] parameters = new SqlParameter[]
               {

                new SqlParameter("@TeacherID", TeacherID),
                new SqlParameter("@CourseCode", CourseCode)
               };

            using (DataTable table = SqlDBHelper.ExecuteSelectCommand(Constraints.SB_CT_GET_STUDNET_BY_TID_AND_COURSE_CODE, CommandType.StoredProcedure,parameters))
            {
                foreach (DataRow row in table.Rows)
                {
                    

                    //Lets go ahead and create the list of employees
                    Course course = new Course();

                    //Now lets populate the employee details into the list of employees                                           
                    course.Id = Convert.ToInt32(row[Constraints.CT_Id]);
                    course.AttendanceCounter = Convert.ToInt32(row["AttendanceCounter"]);
                    course.StudentID = row[Constraints.CT_StudentID].ToString();
                    course.TeacherID = row[Constraints.CT_TeacherID].ToString();
                    course.Trimister = row[Constraints.CT_Trimister].ToString();
                    course.CourseName = row[Constraints.CT_CourseName].ToString();
                    course.CourseCode = row[Constraints.CT_CourseCode].ToString();
                    listofStudent.Add(course);


                

                }
                
            
            }

            return listofStudent;
        }
        internal List<Course> GetCourseAndAttendenceByStudentID(string StudentID)
        {
            List<Course> listofStudent = new List<Course>();

            SqlParameter[] parameters = new SqlParameter[]
               {

                new SqlParameter("@StudentID", StudentID)
                
               };

            using (DataTable table = SqlDBHelper.ExecuteSelectCommand(Constraints.SB_CTGetAllCourse_And_Attendence_By_StudentID, CommandType.StoredProcedure, parameters))
            {
                foreach (DataRow row in table.Rows)
                {


                    //Lets go ahead and create the list of employees
                    Course course = new Course();

                    //Now lets populate the employee details into the list of employees                                           
                    course.Id = Convert.ToInt32(row[Constraints.CT_Id]);
                    course.AttendanceCounter = Convert.ToInt32(row["AttendanceCounter"]);
                    course.StudentID = row[Constraints.CT_StudentID].ToString();
                    course.TeacherID = row[Constraints.CT_TeacherID].ToString();
                    course.Trimister = row[Constraints.CT_Trimister].ToString();
                    course.CourseName = row[Constraints.CT_CourseName].ToString();
                    course.CourseCode = row[Constraints.CT_CourseCode].ToString();
                    listofStudent.Add(course);




                }


            }

            return listofStudent;
        }
        public bool TakeAttendenceByStudentID(string StudentID, string CourseCode)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@StudentID", StudentID),
                new SqlParameter("@CourseCode",CourseCode)
                
            };

            return SqlDBHelper.ExecuteNonQuery(Constraints.SB_TakeAttendance_By_StudentID, CommandType.StoredProcedure, parameters);
        }
    }
   
}
