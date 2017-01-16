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
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

                fillTable();
               
            }

        }

        void fillTable()
        {
            string loginID =(string) Session[LogicLayer.Constraints.LoginID];
            string courseCode = (string)Session[LogicLayer.Constraints.SessoinCourseCode];
            List<Course> courseStudentList = new List<Course>();
            CourseHandeler coursehandeler = new CourseHandeler();
            courseStudentList = coursehandeler.GetCourseStudentByTeacherIDAndCourseCode(loginID, courseCode);

            var table = new DataTable();
            table.Columns.Add("Index");
            table.Columns.Add("StudentName");
            for(int i=0;i< courseStudentList.Count;i++)
            {
                table.Rows.Add(i + 1, courseStudentList[i].StudentID);
            }

            table.Rows.Add("1", "Item 1");
            table.Rows.Add("2", "Item 2");
            table.Rows.Add("3", "Item 3");

            ListView1.DataSource = table;
            ListView1.DataBind();
        }
        protected void GetChecked(object sender, EventArgs e)
        {
            var items = ListView1.Items.Where(i => ((CheckBox)i.FindControl("Checkbox")).Checked);
            foreach (ListViewItem item in items)
            {
                Label IdLabel = item.FindControl("Index") as Label;
                Label NameLabel = item.FindControl("StudentName") as Label;

                if (IdLabel != null && NameLabel != null)
                {
                    string id = IdLabel.Text;
                    string name = NameLabel.Text;
                }
            }
        }
    }
}