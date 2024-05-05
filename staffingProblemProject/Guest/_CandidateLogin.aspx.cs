using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace staffingProblemProject.Guest
{
    public partial class _CandidateLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                txtUserId.Focus();
            }
        }

        //click event to check the member login (member id & password)
        protected void btnLogin_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                BLL obj = new BLL();

                if (obj.CheckUserLogin(txtUserId.Text, txtPassword.Text))
                {
                    Session["UserId"] = txtUserId.Text;

                    Response.Redirect("~/Candidate/_Jobs.aspx?value=a");
                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "key", "<script>alert('Login Failed')</script>");
                }
            }
            catch
            {

            }
        }

        
    }
}