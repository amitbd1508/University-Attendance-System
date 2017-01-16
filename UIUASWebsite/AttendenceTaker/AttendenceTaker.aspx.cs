using LogicLayer.BussinessLogic;
using LogicLayer.BussinessObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace UIUASWebsite.AttendenceTaker
{
    public partial class AttendenceTaker : System.Web.UI.Page
    {
        string loginID;
        string courseCode;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

                fillTable();
               
            }

        }

        void fillTable()
        {
            loginID =(string) Session[LogicLayer.Constraints.LoginID];
            courseCode = (string)Session[LogicLayer.Constraints.SessoinCourseCode];
            List<Course> courseStudentList = new List<Course>();
            CourseHandeler coursehandeler = new CourseHandeler();
            courseStudentList = coursehandeler.GetCourseStudentByTeacherIDAndCourseCode(loginID, courseCode);

            var table = new DataTable();
            table.Columns.Add("Index");
            table.Columns.Add("StudentID");
           
            for (int i=0;i< courseStudentList.Count;i++)
            {
                table.Rows.Add(i + 1, courseStudentList[i].StudentID);
            }

            
            

            ListView1.DataSource = table;
            ListView1.DataBind();
        }
        protected void GetChecked(object sender, EventArgs e)
        {
            var items = ListView1.Items.Where(i => ((CheckBox)i.FindControl("Checkbox")).Checked);
            foreach (ListViewItem item in items)
            {
                
                Label index = item.FindControl("Index") as Label;
                Label studentID = item.FindControl("StudentID") as Label;
                
                

                if (index != null && studentID != null)
                {
                    string idx = index.Text;
                    string id = studentID.Text;
                    if (takeAttendance(id))
                        btnGetChecked.Text = id;
                    else
                        btnGetChecked.Text = idx;
                    

                }
            }
        }

        bool takeAttendance(string StudentID)
        {
            CourseHandeler coursehandeler = new CourseHandeler();


            return coursehandeler.TakeAttendanceByStudentID(StudentID, (string)Session[LogicLayer.Constraints.SessoinCourseCode]);
        }
    }
}