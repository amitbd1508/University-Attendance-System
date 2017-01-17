using LogicLayer.BussinessLogic;
using LogicLayer.BussinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UIUASWebsite.Account
{
    public partial class UserList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadPersonalInfo();
            }

        }

        protected void LoadPersonalInfo()
        {
            try
            {
                UserHandeller personalInfoHandler = new UserHandeller();
                List<User> personalInfoList = personalInfoHandler.GetAll();

                if (personalInfoList != null)
                {
                    gvPersonalInfo.DataSource = personalInfoList;
                    gvPersonalInfo.DataBind();
                }
                else
                {
                    gvPersonalInfo.DataSource = null;
                    gvPersonalInfo.DataBind();
                }
            }
            catch { }
        }

        protected void gvPersonalInfo_RowEditing(object sender, GridViewEditEventArgs e)
        {
            try
            {
                gvPersonalInfo.EditIndex = e.NewEditIndex;
                LoadPersonalInfo();
            }
            catch { }
        }

        protected void gvPersonalInfo_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            try
            {
                gvPersonalInfo.EditIndex = -1;
                LoadPersonalInfo();
            }
            catch { }
        }

        protected void gvPersonalInfo_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            
                Label lblId = gvPersonalInfo.Rows[e.RowIndex].FindControl("txtId") as Label;

                TextBox txtName = gvPersonalInfo.Rows[e.RowIndex].FindControl("txtName") as TextBox;
                TextBox txtDesignation = gvPersonalInfo.Rows[e.RowIndex].FindControl("txtDesignation") as TextBox;
                TextBox txtuniversity_id = gvPersonalInfo.Rows[e.RowIndex].FindControl("txtuniversity_id") as TextBox;
                TextBox txtPassword = gvPersonalInfo.Rows[e.RowIndex].FindControl("txtPassword") as TextBox;
                TextBox txtEmail = gvPersonalInfo.Rows[e.RowIndex].FindControl("txtEmail") as TextBox;
                TextBox txtDepartment = gvPersonalInfo.Rows[e.RowIndex].FindControl("txtDepartment") as TextBox;



                if (lblId != null && txtName != null && txtDepartment != null && txtPassword != null && txtDesignation != null && txtuniversity_id != null && txtEmail!=null)
                {
                    User personalInfo = new User();

                    personalInfo.Id = Convert.ToInt32(lblId.Text);
                    personalInfo.Name = txtName.Text;
                    personalInfo.Department = txtDepartment.Text;
                    personalInfo.Email = txtEmail.Text;
                    personalInfo.Password = txtPassword.Text;
                    personalInfo.Designation = txtDesignation.Text;
                    personalInfo.University_id = txtuniversity_id.Text;
                    personalInfo.Modify_by = "amit";
                    personalInfo.Modify_date = DateTime.Now;
                    
                    //Let us now update the database
                    UserHandeller personalInfoHandler = new UserHandeller();
                    if (personalInfoHandler.Update(personalInfo) == true)
                    {
                        lblResult.Text = "Record Updated Successfully";
                    }
                    else
                    {
                        lblResult.Text = "Failed to Update record";
                    }

                    //end the editing and bind with updated records.
                    gvPersonalInfo.EditIndex = -1;
                    LoadPersonalInfo();
                }
            
            

        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Account/Register.aspx");
        }
    }
}