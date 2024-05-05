using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace staffingProblemProject
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                txtMemberId.Focus();
            }
        }

        //function to clear the contents of the textboxes
        private void Cleartxtboxes()
        {
            txtAddress.Text = string.Empty;
            txtConfirm.Text = string.Empty;
            txtMemberId.Text = string.Empty;
            txtEmailId.Text = string.Empty;
            txtName.Text = string.Empty;
            txtCompanyName.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtPhone.Text = string.Empty; 

        }

        //click event to get register to the application
        protected void imagebtnRegister_Click(object sender, ImageClickEventArgs e)
        {
            try
            {

                BLL obj = new BLL();

                if (obj.CheckMemberId(txtMemberId.Text))
                {
                    if (obj.CheckReceiptNumber(txtReceipt.Text))
                    {
                        string photoName = System.IO.Path.GetFileName(fileuploadPhoto.PostedFile.FileName);

                        int index = photoName.LastIndexOf('.');
                        string ext = photoName.Substring(index + 1);

                        string photoPath = Server.MapPath("~/Guest/CompanyLogos/" + txtMemberId.Text + "." + ext);
                        fileuploadPhoto.PostedFile.SaveAs(photoPath);

                        string dbPath = @"/Guest/CompanyLogos/" + txtMemberId.Text + "." + ext;

                        obj.InsertMemberr(txtMemberId.Text, txtPassword.Text, txtName.Text, txtCompanyName.Text, txtAddress.Text, txtPhone.Text, txtEmailId.Text, dbPath, txtReceipt.Text, DateTime.Now.ToShortDateString(), "Pending");

                        lblSuccess.Font.Bold = true;
                        lblError.Text = " ";
                        lblSuccess.ForeColor = System.Drawing.Color.Green;
                        lblSuccess.Text = "Member Registration is Successfull";
                        ClientScript.RegisterStartupScript(this.GetType(), "key", "<script>alert('Member Registration is Successfull')</script>");
                        Cleartxtboxes();
                    }
                    else
                    {
                        lblError.Font.Bold = true;
                        lblError.ForeColor = System.Drawing.Color.Red;
                        lblError.Text = "Receipt Number Exists";
                        ClientScript.RegisterStartupScript(this.GetType(), "key", "<script>alert('Receipt Number Exists')</script>");
                    }

                }
                else
                {
                    lblError.Font.Bold = true;
                    lblError.ForeColor = System.Drawing.Color.Red;
                    lblError.Text = "MemberId Already Exists";
                    ClientScript.RegisterStartupScript(this.GetType(), "key", "<script>alert('MemberId Already Exists')</script>");
                }
            }
            catch
            {

            }

        }


    }
}