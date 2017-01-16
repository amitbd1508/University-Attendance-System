using LogicLayer;
using LogicLayer.BussinessLogic;
using LogicLayer.BussinessObject;
using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UIUASWebsite.Dashboard
{
    public partial class AttendenceReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                try
                {
                    List<Course> courseList = new List<Course>();
                    CourseHandeler coursehandeler = new CourseHandeler();
                    courseList = coursehandeler.GetCourseAndAttendenceByStudentID((string)Session[Constraints.LoginID]);

                    if (courseList.Count > 0)
                    {
                        rvStudenReport.LocalReport.DataSources.Clear();
                        rvStudenReport.LocalReport.ReportPath = Server.MapPath("StudentReport.rdlc");
                        ReportDataSource rds = new ReportDataSource("DataSet1", courseList);
                        rvStudenReport.LocalReport.DataSources.Add(rds);


                    }

                }
                catch (Exception ex)
                {

                }
            }
        }
    }
}