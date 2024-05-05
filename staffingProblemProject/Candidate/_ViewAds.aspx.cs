using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace staffingProblemProject.Candidate
{
    public partial class _ViewAds : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserId"] == null)
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
            tab = obj.GetAllNewAds();

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

                TableHeaderCell comp = new TableHeaderCell();
                comp.Text = "Company Id";
                mainrow.Controls.Add(comp);

                TableHeaderCell cell1 = new TableHeaderCell();
                cell1.Text = "Job Type";
                mainrow.Controls.Add(cell1);

                TableHeaderCell cell2 = new TableHeaderCell();
                cell2.Text = "SubType";
                mainrow.Controls.Add(cell2);

                TableHeaderCell cell3 = new TableHeaderCell();
                cell3.Text = "Skills Required";
                mainrow.Controls.Add(cell3);

                TableHeaderCell cell4 = new TableHeaderCell();
                cell4.Text = "Job Desc";
                mainrow.Controls.Add(cell4);

                TableHeaderCell cell5 = new TableHeaderCell();
                cell5.Text = "Posted Date";
                mainrow.Controls.Add(cell5);

                TableHeaderCell cellStatus = new TableHeaderCell();
                cellStatus.Text = "Status";
                mainrow.Controls.Add(cellStatus);

                TableHeaderCell cellEdit = new TableHeaderCell();
                cellEdit.Text = "Apply";
                mainrow.Controls.Add(cellEdit);

               
                Table4.Controls.Add(mainrow);

                for (int i = 0; i < tab.Rows.Count; i++)
                {
                    TableRow row = new TableRow();

                    TableCell cellName = new TableCell();
                    cellName.Width = 100;
                    cellName.Text = tab.Rows[i]["AdsId"].ToString();
                    row.Controls.Add(cellName);

                    TableCell cellCompId = new TableCell();
                    cellCompId.Width = 100;
                    cellCompId.Text = tab.Rows[i]["MemberId"].ToString();
                    row.Controls.Add(cellCompId);

                    TableCell cellCompanyName = new TableCell();
                    cellCompanyName.Width = 150;
                    cellCompanyName.Text = tab.Rows[i]["JobType"].ToString();
                    row.Controls.Add(cellCompanyName);

                    TableCell cellContactNo = new TableCell();
                    cellContactNo.Width = 200;
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
                    btn_edit123.ID = "edit~" + tab.Rows[i]["AdsId"].ToString();
                    btn_edit123.Text = "APPLY";
                    btn_edit123.OnClientClick = "return confirm('Are you sure want to APPLY ?')";
                    btn_edit123.Click += new EventHandler(btn_edit123_Click);
                    cell_edit.Controls.Add(btn_edit123);
                    row.Controls.Add(cell_edit);

                   

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

      

        void btn_edit123_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            BLL obj = new BLL();
            Button lbtn = (Button)sender;
            string[] s = lbtn.ID.ToString().Split('~');

            try
            {
                if (obj.CheckUserAd(Session["UserId"].ToString(), int.Parse(s[1])))
                {
                    obj.InsertApplyJob(Session["UserId"].ToString(), int.Parse(s[1]));
                    ClientScript.RegisterStartupScript(this.GetType(), "Key", "<Script>alert('Job Applied Successfully')</script>");
                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "Key", "<Script>alert('Already Applied')</script>");
                }
            }
            catch
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Key", "<Script>alert('Server Error!!!')</script>");
            }
        }

     

    }
}