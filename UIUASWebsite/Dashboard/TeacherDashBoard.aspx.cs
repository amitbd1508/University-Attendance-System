using LogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UIUASWebsite.Dashboard
{
    public partial class DashBoard : System.Web.UI.Page
    {
        string loginID;
        protected void Page_Load(object sender, EventArgs e)
        {
            loginID = (String)Session[Constraints.LoginID];
            
        }

        protected void btnSPL_Click(object sender, EventArgs e)
        {
            // get spl student of this course of this teacher
            Session[Constraints.SessoinCourseCode] = "CSI322";
            Response.Redirect("~/AttendenceTaker/AttendenceTaker.aspx");

        }

        protected void btnSoftware_Click(object sender, EventArgs e)
        {
            Session[Constraints.SessoinCourseCode] = "CSI121";
            Response.Redirect("~/AttendenceTaker/AttendenceTaker.aspx");
        }
    }
}