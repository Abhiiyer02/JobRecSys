using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace staffingProblemProject.Member
{
    public partial class _PostAds : System.Web.UI.Page
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
                {
                    txtJobSubtype.Focus();

                    if (Request.QueryString["adId"] == null)
                    {

                    }
                    else
                    {
                        LoadAd();
                    }
                }
            }
            
        }

        //function to load Ad details
        private void LoadAd()
        {
            BLL obj = new BLL();
            DataTable tab = new DataTable();
            tab = obj.GetAdsById(int.Parse(Request.QueryString["adId"]));

            Session["adId"] = null;
            Session["adId"] = Request.QueryString["adId"];

            if (tab.Rows.Count > 0)
            {
                txtJobSubtype.Text = tab.Rows[0]["SubType"].ToString();
                txtSkills.Text = tab.Rows[0]["SkillsRequired"].ToString();
                txtJobDesc.Text = tab.Rows[0]["JobDesc"].ToString();

                string dataTextField = ddlJobType.Items.FindByValue(tab.Rows[0]["JobType"].ToString()).ToString();

                ListItem item = new ListItem(dataTextField, dataTextField);
                int index = ddlJobType.Items.IndexOf(item);

                if (index != -1)

                    ddlJobType.SelectedIndex = index;


                string dataTextField1 = ddlStatus.Items.FindByValue(tab.Rows[0]["Status"].ToString()).ToString();

                ListItem item1 = new ListItem(dataTextField1, dataTextField1);
                int index1 = ddlStatus.Items.IndexOf(item1);

                if (index1 != -1)

                    ddlStatus.SelectedIndex = index1;  
              
            }

            btnAds.Text = "Update";
        }

        protected void btnAds_Click(object sender, EventArgs e)
        {
            try
            {
                BLL obj = new BLL();

                if (btnAds.Text.Equals("Submit"))
                {

                    obj.InsertNewAd(Session["MemberId"].ToString(), ddlJobType.SelectedItem.Text, txtJobSubtype.Text, txtSkills.Text, txtJobDesc.Text, DateTime.Now, ddlStatus.SelectedItem.Text);

                    lblSuccess.Font.Bold = true;
                    lblError.Text = " ";
                    lblSuccess.ForeColor = System.Drawing.Color.Green;
                    lblSuccess.Text = "Ad Posted Successfull";
                    ClientScript.RegisterStartupScript(this.GetType(), "key", "<script>alert('Ad Posted Successfull')</script>");
                    txtJobSubtype.Text = txtSkills.Text = txtJobDesc.Text = txtJobDesc.Text = txtSkills.Text = string.Empty;
                }
                else if (btnAds.Text.Equals("Update"))
                {
                    obj.UpdateAds(Session["MemberId"].ToString(), ddlJobType.SelectedItem.Text, txtJobSubtype.Text, txtSkills.Text, txtJobDesc.Text, DateTime.Now, ddlStatus.SelectedItem.Text,int.Parse(Session["adId"].ToString()));

                    ClientScript.RegisterStartupScript(this.GetType(), "Key", "<Script>alert('Ad Updated Successfully!!!')</script>");
                    lblSuccess.Font.Bold = true;
                    lblError.Text = " ";
                    lblSuccess.ForeColor = System.Drawing.Color.Green;
                    lblSuccess.Text = "Ad Updated Successfull";

                    btnAds.Text = "Submit";
                    txtJobSubtype.Text = txtSkills.Text = txtJobDesc.Text = txtJobDesc.Text = txtSkills.Text = string.Empty;

                }
            }
            catch
            {

            }
        }
    }
}