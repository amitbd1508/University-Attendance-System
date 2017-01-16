﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public static class Constraints
    {
        public  static string  SB_USER_INSERT= "tblUserInsert";
        public static string SB_USER_UPDATE_BY_ID = "tblUserUpdateById";
        public static string SB_USER_DELETE_BY_ID = "tblUserDeleteById";
        public static string SB_USER_GETALL = "tblUserGetAll";
        public static string SB_USER_GET_BY_ID = "tblUserGetById";
        public static string SB_USER_GET_BY_UID_PASS = "tblUserGetByUniversityIDANdPassWord";

        //for session
        public static string LoginID = "LoginID";
        public static string SessoinCourseCode = "SessoinCourseCode";

        //course taken
        public static string SB_CT_GET_STUDNET_BY_TID_AND_COURSE_CODE = "tblCTGetAllStudentByCourseAndTeachersID";

        public static string CT_Id = "Id";
        public static string CT_CourseCode = "CourseCode";
        public static string CT_CourseName = "CourseName";
        public static string CT_StudentID = "StudentID";
        public static string CT_TeacherID = "TeacherID";
        public static string CT_AttendanceCounter = "AttendanceCounter";
        public static string CT_Trimister = "Trimister";


    }
}
