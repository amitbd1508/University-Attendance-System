using System;
using System.Linq;
using System.Web;
using System.Web.UI;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Owin;
using UIUASWebsite.Models;
using LogicLayer.BussinessObject;
using LogicLayer.BussinessLogic;

namespace UIUASWebsite.Account
{
    public partial class Register : Page
    {
        protected void CreateUser_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Created_by = "Unknown User";
            user.Created_by = txtName.Text;
            user.Created_date = DateTime.Now;
            user.Modify_date = DateTime.Now;
            user.Name = txtName.Text;
            user.Password = txtPassword.Text;
            user.University_id = txtUniversityID.Text;
            user.Department = ddDepertment.SelectedItem.Text;
            user.Designation = ddDesignation.SelectedItem.Text;
            user.Email = txtEmail.Text;
            try
            {
                UserHandeller userHandeller = new UserHandeller();
                if (userHandeller.Insert(user))
                {
                    ErrorMessage.Text = "Sucess";
                    Response.Redirect("~/Account/Admin.aspx");
                }
                else ErrorMessage.Text = "Not Sucess";
            }
            catch (Exception ee)
            {
                ErrorMessage.Text = user.Created_date+ ee.Message;
            }
            



        }

        
    }
}