using System;
using System.Web;
using System.Web.UI;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Owin;
using UIUASWebsite.Models;
using LogicLayer.BussinessLogic;
using LogicLayer.BussinessObject;
using LogicLayer;

namespace UIUASWebsite.Account
{
    public partial class Login : Page
    {
        public object UserDBhandeller { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            //    RegisterHyperLink.NavigateUrl = "Register";
            //    // Enable this once you have account confirmation enabled for password reset functionality
            //    //ForgotPasswordHyperLink.NavigateUrl = "Forgot";
            //    OpenAuthLogin.ReturnUrl = Request.QueryString["ReturnUrl"];
            //    var returnUrl = HttpUtility.UrlEncode(Request.QueryString["ReturnUrl"]);
            //    if (!String.IsNullOrEmpty(returnUrl))
            //    {
            //        RegisterHyperLink.NavigateUrl += "?ReturnUrl=" + returnUrl;
            //    }
        }

        protected void LogIn(object sender, EventArgs e)
        {
            string loginStatus = loginSucess();
            if (loginStatus!="")
            {
                Session[Constraints.LoginID] = txtUniversityID.Text;

                if (loginStatus == "Student")
                    Response.Redirect("~/Dashboard/StudentDashBoard.aspx");
                else if (loginStatus == "Faculty")
                    Response.Redirect("~/Dashboard/TeacherDashBoard.aspx");
                else if (loginStatus == "Admin")
                    Response.Redirect("~/Account/Register.aspx");
                else
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Please Try Again ')", true);
                




            }
            else ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Unsucessfull ')", true);

        }

        private string loginSucess()
        {
            UserHandeller handeller = new UserHandeller();
            string designation = handeller.LoginCheck(txtUniversityID.Text, txtPassword.Text);


            if (designation != "")
                return designation;
            return designation;
        }
    }
}