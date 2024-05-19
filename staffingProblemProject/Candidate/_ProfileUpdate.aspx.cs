using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Web.DynamicData;

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

            DataTable userParams = obj.GetMLParamsById(Session["UserId"].ToString());
            DropDownListSSLC.Items.FindByValue(userParams.Rows[0]["SSLC"].ToString()).Selected = true;
            DropDownListPUC.Items.FindByValue(userParams.Rows[0]["PUC"].ToString()).Selected = true;
            DropDownListCS.Items.FindByValue(userParams.Rows[0]["Communication"].ToString()).Selected = true;
            DropDownListPSolving.Items.FindByValue(userParams.Rows[0]["ProblemSolving"].ToString()).Selected = true;
            DropDownListNetworks.Items.FindByValue(userParams.Rows[0]["Networks"].ToString()).Selected = true;
            DropDownListOS.Items.FindByValue(userParams.Rows[0]["OS"].ToString()).Selected = true;
            DropDownListDBMS.Items.FindByValue(userParams.Rows[0]["DBMS"].ToString()).Selected = true;
            DropDownListDS.Items.FindByValue(userParams.Rows[0]["DSA"].ToString()).Selected = true;
            DropDownListCloud.Items.FindByValue(userParams.Rows[0]["CloudComputing"].ToString()).Selected = true;
            DropDownListContainers.Items.FindByValue(userParams.Rows[0]["Containers"].ToString()).Selected = true;
            DropDownListSD.Items.FindByValue(userParams.Rows[0]["SystemDesign"].ToString()).Selected = true;
            DropDownListM.Items.FindByValue(userParams.Rows[0]["Maths"].ToString()).Selected = true;
            DropDownListVCS.Items.FindByValue(userParams.Rows[0]["VersionControl"].ToString()).Selected = true;
            DropDownListPython.Items.FindByValue(userParams.Rows[0]["Python"].ToString()).Selected = true;
            DropDownListJS.Items.FindByValue(userParams.Rows[0]["JSTS"].ToString()).Selected = true;
            DropDownListCCCP.Items.FindByValue(userParams.Rows[0]["CC++"].ToString()).Selected = true;
            DropDownListJava.Items.FindByValue(userParams.Rows[0]["Java"].ToString()).Selected = true;
        }


        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try {
                BLL obj = new BLL();
                obj.UpdateMLParams(Session["UserId"].ToString(), int.Parse(DropDownListSSLC.SelectedItem.Value), int.Parse(DropDownListPUC.SelectedItem.Value), int.Parse(DropDownListCS.SelectedItem.Value), int.Parse(DropDownListPSolving.SelectedItem.Value), int.Parse(DropDownListNetworks.SelectedItem.Value), int.Parse(DropDownListOS.SelectedItem.Value), int.Parse(DropDownListDBMS.SelectedItem.Value), int.Parse(DropDownListDS.SelectedItem.Value), int.Parse(DropDownListCloud.SelectedItem.Value), int.Parse(DropDownListContainers.SelectedItem.Value), int.Parse(DropDownListSD.SelectedItem.Value), int.Parse(DropDownListM.SelectedItem.Value), int.Parse(DropDownListVCS.SelectedItem.Value), int.Parse(DropDownListPython.SelectedItem.Value), int.Parse(DropDownListJS.SelectedItem.Value), int.Parse(DropDownListCCCP.SelectedItem.Value), int.Parse(DropDownListJava.SelectedItem.Value));
                ClientScript.RegisterStartupScript(this.GetType(), "key", "<script>alert('User Profile Updated Successfull')</script>");

            }
            catch { 
            
            }
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
                    
                    obj.UpdateUser(txtUserId.Text, txtName.Text, txtAddress.Text, txtPhone.Text, txtEmailId.Text, tabUser.Rows[0]["Resume"].ToString(), txtSkills.Text, DateTime.Now.ToShortDateString());
                                       
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

                  
                    obj.UpdateUser(txtUserId.Text, txtName.Text, txtAddress.Text, txtPhone.Text, txtEmailId.Text, dbPath, txtSkills.Text, DateTime.Now.ToShortDateString());

                   
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