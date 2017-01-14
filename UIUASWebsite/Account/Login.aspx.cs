using System;
using System.Web;
using System.Web.UI;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Owin;
using UIUASWebsite.Models;
using LogicLayer.BussinessLogic;
using LogicLayer.BussinessObject;

namespace UIUASWebsite.Account
{
    public partial class Login : Page
    {
        public object UserDBhandeller { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            RegisterHyperLink.NavigateUrl = "Register";
            // Enable this once you have account confirmation enabled for password reset functionality
            //ForgotPasswordHyperLink.NavigateUrl = "Forgot";
            OpenAuthLogin.ReturnUrl = Request.QueryString["ReturnUrl"];
            var returnUrl = HttpUtility.UrlEncode(Request.QueryString["ReturnUrl"]);
            if (!String.IsNullOrEmpty(returnUrl))
            {
                RegisterHyperLink.NavigateUrl += "?ReturnUrl=" + returnUrl;
            }
        }

        protected void LogIn(object sender, EventArgs e)
        {
            
            if (loginSucess())
            {
               // Server.Transfer("/Default.aspx", true);
                Response.Redirect("/Default.aspx");
            }
            else ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Unsucessfull ')", true);

        }

        private bool loginSucess()
        {
            UserHandeller handeller = new UserHandeller();
            
            if(handeller.LoginCheck(txtUniversityID.Text, txtPassword.Text))
                return true;
            return false;
        }
    }
}