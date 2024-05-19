using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace staffingProblemProject.Guest
{
    public partial class UserRegister : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtName.Focus();
        }

        protected void imagebtnRegister_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                BLL obj = new BLL();

                if (obj.CheckUserId(txtUserId.Text))
                {


                    string photoName = System.IO.Path.GetFileName(fileuploadPhoto.PostedFile.FileName);

                    int index = photoName.LastIndexOf('.');
                    string ext = photoName.Substring(index + 1);

                    string photoPath = Server.MapPath("~/Guest/Resumes/" + txtUserId.Text + "." + ext);
                    fileuploadPhoto.PostedFile.SaveAs(photoPath);

                    string dbPath = @"/Guest/Resumes/" + txtUserId.Text + "." + ext;

                    obj.NewUser(txtUserId.Text, txtPassword.Text, txtName.Text, txtAddress.Text, txtPhone.Text, txtEmailId.Text, dbPath, txtSkills.Text, DateTime.Now.ToShortDateString());

                    lblSuccess.Font.Bold = true;
                    lblError.Text = " ";
                    lblSuccess.ForeColor = System.Drawing.Color.Green;
                    lblSuccess.Text = "User Registration is Successfull";
                    //ClientScript.RegisterStartupScript(this.GetType(), "key", "<script>alert('User Registration is Successfull')</script>");
                    txtAddress.Text = txtEmailId.Text = txtName.Text = txtPhone.Text = txtSkills.Text = string.Empty;
                    obj.InsertMLParams(txtUserId.Text, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1);
                    Session["MLP"] = txtUserId.Text;
                    Response.Redirect("~/candidate/datasetaddition.aspx");
                }
                else
                {
                    lblError.Font.Bold = true;
                    lblError.ForeColor = System.Drawing.Color.Red;
                    lblError.Text = "UserId Already Exists";
                    ClientScript.RegisterStartupScript(this.GetType(), "key", "<script>alert('UserId Already Exists')</script>");
                }
            }
            catch
            {

            }

        }
    }
}