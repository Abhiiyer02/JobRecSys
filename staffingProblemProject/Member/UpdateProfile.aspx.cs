using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace staffingProblemProject.Member
{
    public partial class UpdateProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["MemberId"] == null)
            {
                Session.Abandon();
                Response.Redirect("../Guest/Index.aspx");
            }
            else
            {
                if (!this.IsPostBack)
                    GetMember();
            }
        }

        private void GetMember()
        {
            BLL obj = new BLL();
            DataTable tabUser = new DataTable();

            tabUser = obj.GetMemberById(Session["MemberId"].ToString());

            txtUserId.Text = tabUser.Rows[0]["MemberId"].ToString();
            txtUserId.Enabled = false;
            txtName.Text = tabUser.Rows[0]["Name"].ToString();
            txtCName.Text = tabUser.Rows[0]["CompanyName"].ToString();
            txtPhone.Text = tabUser.Rows[0]["ContactNo"].ToString();
            txtEmailId.Text = tabUser.Rows[0]["EmailId"].ToString();
            txtAddress.Text = tabUser.Rows[0]["Address"].ToString();
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                BLL obj = new BLL();

                obj.UpdateMProfile(txtUserId.Text, txtName.Text, txtCName.Text, txtAddress.Text, txtPhone.Text, txtEmailId.Text, Session["MemberId"].ToString());

                ClientScript.RegisterStartupScript(this.GetType(), "key", "<script>alert('User Profile Updated Successfull')</script>");
                txtAddress.Text = txtEmailId.Text = txtName.Text = txtPhone.Text = txtCName.Text = string.Empty;

                GetMember();

            }
            catch
            {

            }
        }

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
    }
}