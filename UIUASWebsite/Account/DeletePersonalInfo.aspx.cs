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
    public partial class DeletePersonalInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["Id"] != null)
                {
                    int id = Convert.ToInt32(Request.QueryString["Id"]);
                    UserHandeller personalInfoHandler = new UserHandeller();

                    User personalInfo = personalInfoHandler.GetById(id);
                    if (personalInfo != null)
                    {
                        lblId.Text = personalInfo.Id.ToString();
                        lblName.Text = personalInfo.Name;
                        lblDept.Text = personalInfo.Department;
                    }
                    else
                    {
                        Response.Redirect("~/Account/UserList.aspx");
                    }
                }
                else
                {
                    Response.Redirect("~/Account/UserList.aspx");
                }
            }

        }
        protected void btnNO_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Account/UserList.aspx");
        }

        protected void btnYES_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(lblId.Text);

            UserHandeller personalInfoHandler = new UserHandeller();
            if (personalInfoHandler.DeleteById(id) == true)
            {
                Response.Redirect("~/Account/UserList.aspx");
            }
        }
    }
}