using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace staffingProblemProject.Member
{
    public partial class MemberAccount : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["MemberId"] == null)
                {
                    Session.Abandon();
                    Response.Redirect("../Guest/Index.aspx");
                }
                else
                {
                    txtOldpassword.Focus();
                }
            }
            catch
            {

            }
        }

        //click event to change tourist password
        protected void imgbtnChangepwd_Click(object sender, ImageClickEventArgs e)
        {
            DataTable tab = new DataTable();
            BLL obj = new BLL();
            tab.Rows.Clear();

            tab = obj.GetMemberById(Session["MemberId"].ToString());
            string oldPassword = tab.Rows[0]["Password"].ToString();

            if (txtOldpassword.Text.Equals(oldPassword))
            {
                try
                {
                    obj.UpdateMemberPassword(txtNewpassword.Text, Session["MemberId"].ToString());

                    lblPasswordSuccess.Font.Bold = true;
                    lblPasswordError.Text = " ";
                    lblPasswordSuccess.ForeColor = System.Drawing.Color.Green;
                    lblPasswordSuccess.Text = "<b>Error:</b>Member Password changed successfully!!!";
                    ClientScript.RegisterStartupScript(this.GetType(), "key", "<script>alert('Member Password changed successfully')</script>");
                }
                catch
                {
                    lblPasswordError.Font.Bold = true;
                    lblPasswordSuccess.Text = " ";
                    lblPasswordError.ForeColor = System.Drawing.Color.Red;
                    lblPasswordError.Text = "<b>Error:</b> Server Error!!!";
                    ClientScript.RegisterStartupScript(this.GetType(), "key", "<script>alert('Server Error!')</script>");
                }
            }
            else
            {
                lblPasswordError.Font.Bold = true;
                lblPasswordSuccess.Text = " ";
                lblPasswordError.ForeColor = System.Drawing.Color.Red;
                lblPasswordError.Text = "<b>Error:</b>Member Old password incorrect!!!";
                ClientScript.RegisterStartupScript(this.GetType(), "key", "<script>alert('Member Old password incorrect')</script>");
            }
        }

        protected void lbtnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("MemberProfile.aspx");
        }
        

    }
}