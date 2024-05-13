using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace staffingProblemProject.Member
{
    public partial class _ViewJobAds : System.Web.UI.Page
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
                GetCompanyAds();
            }
        }

        //function to load the Company Ads
        public void GetCompanyAds()
        {
            BLL obj = new BLL();

            DataTable tab = new DataTable();
            tab.Rows.Clear();
            tab = obj.GetAdsByCompany(Session["MemberId"].ToString());

            if (tab.Rows.Count > 0)
            {
                Table4.Rows.Clear();

                Table4.BorderStyle = BorderStyle.Double;
                Table4.GridLines = GridLines.Both;
                Table4.BorderColor = System.Drawing.Color.DarkGray;

                TableRow mainrow = new TableRow();
                mainrow.Height = 30;
                mainrow.ForeColor = System.Drawing.Color.WhiteSmoke;

                mainrow.BackColor = System.Drawing.Color.Gray;

                TableHeaderCell cell0 = new TableHeaderCell();
                cell0.Text = "AdId";
                mainrow.Controls.Add(cell0);

                TableHeaderCell cell1 = new TableHeaderCell();
                cell1.Text = "Job Domain";
                mainrow.Controls.Add(cell1);

                TableHeaderCell cell2 = new TableHeaderCell();
                cell2.Text = "Job Title";
                mainrow.Controls.Add(cell2);

                TableHeaderCell cell3 = new TableHeaderCell();
                cell3.Text = "Skills";
                mainrow.Controls.Add(cell3);

                TableHeaderCell cell4 = new TableHeaderCell();
                cell4.Text = "Job Description";
                mainrow.Controls.Add(cell4);

                TableHeaderCell cell5 = new TableHeaderCell();
                cell5.Text = "Posted on";
                mainrow.Controls.Add(cell5);

                TableHeaderCell cellStatus = new TableHeaderCell();
                cellStatus.Text = "Status";
                mainrow.Controls.Add(cellStatus);

                TableHeaderCell cellEdit = new TableHeaderCell();
                cellEdit.Text = "Edit";
                mainrow.Controls.Add(cellEdit);

                TableHeaderCell cell6 = new TableHeaderCell();
                cell6.Text = "Delete";
                mainrow.Controls.Add(cell6);

                TableHeaderCell cell61 = new TableHeaderCell();
                cell61.Text = "Applicants";
                mainrow.Controls.Add(cell61);

                Table4.Controls.Add(mainrow);

                for (int i = 0; i < tab.Rows.Count; i++)
                {
                    TableRow row = new TableRow();
                                  
                    TableCell cellName = new TableCell();
                    cellName.Width = 100;
                    cellName.Text = tab.Rows[i]["AdsId"].ToString();
                    row.Controls.Add(cellName);

                    TableCell cellCompanyName = new TableCell();
                    cellCompanyName.Width = 150;
                    cellCompanyName.Text = tab.Rows[i]["JobType"].ToString();
                    row.Controls.Add(cellCompanyName);

                    TableCell cellContactNo = new TableCell();
                    cellContactNo.Width = 300;
                    cellContactNo.Text = tab.Rows[i]["SubType"].ToString();
                    row.Controls.Add(cellContactNo);

                    TableCell cellSkills = new TableCell();
                    cellSkills.Width = 300;
                    cellSkills.Text = tab.Rows[i]["SkillsRequired"].ToString();
                    row.Controls.Add(cellSkills);

                    TableCell cellDesc = new TableCell();
                    cellDesc.Width = 300;
                    cellDesc.Text = tab.Rows[i]["JobDesc"].ToString();
                    row.Controls.Add(cellDesc);

                    TableCell cellDate = new TableCell();
                    cellDate.Width = 100;
                    cellDate.Text = tab.Rows[i]["PostedDate"].ToString();
                    row.Controls.Add(cellDate);

                    TableCell cellStatus1 = new TableCell();
                    cellStatus1.Width = 100;
                    cellStatus1.Text = tab.Rows[i]["Status"].ToString();
                    row.Controls.Add(cellStatus1);

                    TableCell cell_edit = new TableCell();

                    Button btn_edit123 = new Button();
                    btn_edit123.ID ="edit~" + tab.Rows[i]["AdsId"].ToString();
                    btn_edit123.Text = "Edit";
                    btn_edit123.Click += new EventHandler(btn_edit123_Click);
                    cell_edit.Controls.Add(btn_edit123);
                    row.Controls.Add(cell_edit);

                    TableCell cell_del = new TableCell();

                    Button btn_delete123 = new Button();
                    btn_delete123.ID = "del~" + tab.Rows[i]["AdsId"].ToString();
                    btn_delete123.Text = "Delete";
                    btn_delete123.OnClientClick = "return confirm('Are you sure want to delete ?')";
                    btn_delete123.Click += new EventHandler(btn_delete123_Click);
                    cell_del.Controls.Add(btn_delete123);
                    row.Controls.Add(cell_del);


                    TableCell cell_candidates = new TableCell();

                    Button btn_candidates = new Button();
                    btn_candidates.ID = "view~" + tab.Rows[i]["AdsId"].ToString();
                    btn_candidates.Text = "View Applicants";
                    btn_candidates.Click += new EventHandler(btn_candidates_Click);
                    cell_candidates.Controls.Add(btn_candidates);
                    row.Controls.Add(cell_candidates);

                    Table4.Controls.Add(row);
                }

            }
            else
            {
                Table4.Rows.Clear();
                Table4.GridLines = GridLines.None;

                TableHeaderRow row = new TableHeaderRow();
                TableHeaderCell cell = new TableHeaderCell();
                cell.ColumnSpan = 5;
                cell.ForeColor = System.Drawing.Color.Red;
                cell.Text = "No Ads Found";
                row.Controls.Add(cell);

                Table4.Controls.Add(row);

            }
        }

        void btn_candidates_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            BLL obj = new BLL();
            Button lbtn = (Button)sender;
            string[] s = lbtn.ID.ToString().Split('~');

            try
            {
                Response.Redirect(string.Format("_AppliedCandidates.aspx?adId={0}", s[1]));
            }
            catch
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Key", "<Script>alert('Server Error!!!')</script>");
            }
        }

        void btn_edit123_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            BLL obj = new BLL();
            Button lbtn = (Button)sender;
            string[] s = lbtn.ID.ToString().Split('~');

            try
            {
                Response.Redirect(string.Format("_PostAds.aspx?adId={0}", s[1]));
            }
            catch
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Key", "<Script>alert('Server Error!!!')</script>");
            }
        }

        //click event to delete user
        void btn_delete123_Click(object sender, EventArgs e)
        {
            try
            {
                BLL obj = new BLL();
                Button btn = (Button)sender;
                string[] s = btn.ID.Split('~');

                DataTable tabApplies = new DataTable();
                tabApplies = obj.GetCandidatesByAdId(int.Parse(s[1]));

                if (tabApplies.Rows.Count > 0)
                {
                    obj.DeleteApplyJobsByAd(int.Parse(s[1]));
                    obj.DeleteAd(int.Parse(s[1]));
                }
                else
                {
                    obj.DeleteAd(int.Parse(s[1]));
                }
                              

                ClientScript.RegisterStartupScript(this.GetType(), "key", "<script>alert('Ad and its Details Deleted Successfully')</script>");
                GetCompanyAds();
            }
            catch
            {

            }

        }      

    }
}