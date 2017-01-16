using LogicLayer.BussinessLogic;
using LogicLayer.BussinessObject;
using LogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace UIUASWebsite.Dashboard
{
    public partial class StudentDashBoard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                User user = new User();
                UserHandeller userHandeler = new UserHandeller();
                user = userHandeler.GetByUniversityID((string)Session[Constraints.LoginID]);
                lblName.Text = user.Name;
                name.Text = user.Name;
                id.Text = user.University_id;
                email.Text = user.Email;
                department.Text = user.Department;
                accountType.Text = user.Designation;
                fillTable(user.University_id);

            }
            

        }

        

        void fillTable(string studentID)
        {
            List<Course> courseList = new List<Course>();
            CourseHandeler coursehandeler = new CourseHandeler();
            courseList = coursehandeler.GetCourseAndAttendenceByStudentID(studentID);

            var table = new DataTable();
            table.Columns.Add("Index");
            table.Columns.Add("CourseName");
            table.Columns.Add("CourseCode");
            table.Columns.Add("trimister");
            table.Columns.Add("attend");

            for (int i = 0; i < courseList.Count; i++)
            {
                table.Rows.Add(i + 1, courseList[i].CourseName,courseList[i].CourseCode,courseList[i].Trimister,courseList[i].AttendanceCounter);
            }




            ListView1.DataSource = table;
            ListView1.DataBind();

        }

        protected void btnGenarateReport_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Dashboard/AttendenceReport.aspx");
        }
    }
}