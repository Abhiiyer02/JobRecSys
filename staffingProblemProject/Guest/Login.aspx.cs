using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace staffingProblemProject
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                txtMemberId.Focus();                               
            }
        }

        //click event to check the member login (member id & password)
        protected void btnLogin_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                BLL obj = new BLL();

                if (obj.CheckMemberLogin(txtMemberId.Text, txtPassword.Text, "Approved"))
                {
                    Session["MemberId"] = txtMemberId.Text;

                    Response.Redirect("~/Member/_PostAds.aspx?value=a");
                }
                else
                {                    
                    ClientScript.RegisterStartupScript(this.GetType(), "key", "<script>alert('Invalid MemberId/Password/Yet to Approve')</script>");
                }
            }
            catch
            {

            }
        }
        
    }
}