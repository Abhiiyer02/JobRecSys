using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace staffingProblemProject.Candidate
{
    public partial class _ProfileUpdate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserId"] == null)
            {
                Session.Abandon();
                Response.Redirect("../Guest/Index.aspx");
            }
            if (!this.IsPostBack)
                GetUser();
        }

        private void GetUser()
        {
            BLL obj = new BLL();
            DataTable tabUser = new DataTable();

            tabUser = obj.GetUserById(Session["UserId"].ToString());

            txtUserId.Text = tabUser.Rows[0]["UserId"].ToString();
            txtUserId.Enabled = false;
            txtName.Text = tabUser.Rows[0]["Name"].ToString();
            txtPhone.Text = tabUser.Rows[0]["ContactNo"].ToString();
            txtEmailId.Text = tabUser.Rows[0]["EmailId"].ToString();
            txtAddress.Text = tabUser.Rows[0]["Address"].ToString();
            txtSkills.Text = tabUser.Rows[0]["Skills"].ToString();
            

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                BLL obj = new BLL();

                if (fileuploadPhoto.PostedFile.FileName=="")
                {
                    DataTable tabUser = new DataTable();

                    tabUser = obj.GetUserById(Session["UserId"].ToString());
                    
                    obj.UpdateUser(txtUserId.Text, tabUser.Rows[0]["Password"].ToString(), txtName.Text, txtAddress.Text, txtPhone.Text, txtEmailId.Text, tabUser.Rows[0]["Resume"].ToString(), txtSkills.Text, DateTime.Now.ToShortDateString());
                                       
                    ClientScript.RegisterStartupScript(this.GetType(), "key", "<script>alert('User Profile Updated Successfull')</script>");
                    txtAddress.Text = txtEmailId.Text = txtName.Text = txtPhone.Text = txtSkills.Text = string.Empty;

                }
                else
                {
                    DataTable tabUser = new DataTable();

                    tabUser = obj.GetUserById(Session["UserId"].ToString());

                    string photoName = System.IO.Path.GetFileName(fileuploadPhoto.PostedFile.FileName);

                    int index = photoName.LastIndexOf('.');
                    string ext = photoName.Substring(index + 1);

                    string photoPath = Server.MapPath("~/Guest/Resumes/" + txtUserId.Text + "." + ext);
                    fileuploadPhoto.PostedFile.SaveAs(photoPath);

                    string dbPath = @"/Guest/Resumes/" + txtUserId.Text + "." + ext;

                  
                      obj.UpdateUser(txtUserId.Text, tabUser.Rows[0]["Password"].ToString(), txtName.Text, txtAddress.Text, txtPhone.Text, txtEmailId.Text, dbPath, txtSkills.Text, DateTime.Now.ToShortDateString());

                   
                    ClientScript.RegisterStartupScript(this.GetType(), "key", "<script>alert('User Profile Updated Successfully with Resume')</script>");
                    txtAddress.Text = txtEmailId.Text = txtName.Text = txtPhone.Text = txtSkills.Text = string.Empty;


                }

                GetUser();
                
            }
            catch
            {

            }
        }

        protected void imgbtnChangepwd_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                DataTable tab = new DataTable();
                BLL obj = new BLL();
                tab.Rows.Clear();

                tab = obj.GetUserById(Session["UserId"].ToString());
                string oldPassword = tab.Rows[0]["Password"].ToString();

                if (txtOldpassword.Text.Equals(oldPassword))
                {
                    try
                    {
                        obj.UpdateCandidatePassword(txtNewpassword.Text, Session["UserId"].ToString());

                        lblPasswordSuccess.Font.Bold = true;
                        lblPasswordError.Text = " ";
                        lblPasswordSuccess.ForeColor = System.Drawing.Color.Green;
                        lblPasswordSuccess.Text = "<b>Success:</b>Candidate Password changed successfully!!!";
                        ClientScript.RegisterStartupScript(this.GetType(), "key", "<script>alert('Candidate Password changed successfully')</script>");
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
                    lblPasswordError.Text = "<b>Error:</b> Candidate Old password incorrect!!!";
                    ClientScript.RegisterStartupScript(this.GetType(), "key", "<script>alert('Candidate Old password incorrect')</script>");
                }
            }
            catch
            {

            }
        }
    }
}