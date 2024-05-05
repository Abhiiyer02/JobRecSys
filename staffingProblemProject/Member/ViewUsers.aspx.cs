using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace staffingProblemProject.Member
{
    public partial class ViewUsers : System.Web.UI.Page
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
                    GetAllUsers();
                }
            }
            catch
            {

            }
        }


        //function to load the users
        public void GetAllUsers()
        {
            BLL obj = new BLL();

            DataTable tab = new DataTable();
            tab.Rows.Clear();
            tab = obj.GetAllUsers();

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
                cell0.Text = "Resume";
                mainrow.Controls.Add(cell0);
                                
                TableHeaderCell cell2 = new TableHeaderCell();
                cell2.Text = "Name";
                mainrow.Controls.Add(cell2);
               
                TableHeaderCell cell4 = new TableHeaderCell();
                cell4.Text = "ContactNo";
                mainrow.Controls.Add(cell4);

                TableHeaderCell cell5 = new TableHeaderCell();
                cell5.Text = "Email ID";
                mainrow.Controls.Add(cell5);

                TableHeaderCell cell51 = new TableHeaderCell();
                cell51.Text = "Skills";
                mainrow.Controls.Add(cell51);

                //TableHeaderCell cell6 = new TableHeaderCell();
                //cell6.Text = "Delete";
                //mainrow.Controls.Add(cell6);

                Table4.Controls.Add(mainrow);

                for (int i = 0; i < tab.Rows.Count; i++)
                {
                    TableRow row = new TableRow();

                    TableCell cellResume = new TableCell();
                    cellResume.Width = 150;
                    cellResume.Font.Bold = true;
                    LinkButton lbtnResume = new LinkButton();
                    lbtnResume.ID ="res~" + tab.Rows[i]["UserId"].ToString();
                    lbtnResume.Text = "Download Resume";
                    lbtnResume.OnClientClick = "return confirm('Are you sure want to Download ?')";
                    lbtnResume.Click += new EventHandler(lbtnResume_Click);
                    cellResume.Controls.Add(lbtnResume);
                    row.Controls.Add(cellResume);

                    TableCell cellMemberId = new TableCell();
                    cellMemberId.Width = 100;
                    cellMemberId.Text = "<a href='#'>" + tab.Rows[i]["Name"].ToString() + "<span>Name : " + tab.Rows[i]["Name"].ToString() + ".</br>Address : " + tab.Rows[i]["Address"].ToString() + ".</br>Email ID : " + tab.Rows[i]["EmailId"].ToString() + "</span></a>";
                    row.Controls.Add(cellMemberId);

                                      
                    TableCell cellContactNo = new TableCell();
                    cellContactNo.Width = 100;
                    cellContactNo.Text = tab.Rows[i]["ContactNo"].ToString();
                    row.Controls.Add(cellContactNo);

                    TableCell cellEmailId = new TableCell();
                    cellEmailId.Width = 100;
                    cellEmailId.Text = tab.Rows[i]["EmailId"].ToString();
                    row.Controls.Add(cellEmailId);

                    TableCell cellSkills = new TableCell();
                    cellSkills.Width = 550;
                    cellSkills.Text = tab.Rows[i]["Skills"].ToString();
                    row.Controls.Add(cellSkills);

                    //TableCell cell_del = new TableCell();

                    //Button btn_delete123 = new Button();
                    //btn_delete123.ID = "del~" + tab.Rows[i]["UserId"].ToString();
                    //btn_delete123.Text = "Delete";
                    //btn_delete123.OnClientClick = "return confirm('Are you sure want to delete ?')";
                    //btn_delete123.Click += new EventHandler(btn_delete123_Click);
                    //cell_del.Controls.Add(btn_delete123);
                    //row.Controls.Add(cell_del);

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
                cell.Text = "No Users Found!!";
                row.Controls.Add(cell);

                Table4.Controls.Add(row);

            }
        }

        void lbtnResume_Click(object sender, EventArgs e)
        {
            try
            {
                //throw new NotImplementedException();
                BLL obj = new BLL();
                LinkButton btn = (LinkButton)sender;
                string[] s = btn.ID.Split('~');

                DataTable tab = new DataTable();
                tab = obj.GetUserById(s[1]);

                string[] resume = tab.Rows[0]["Resume"].ToString().Split('/');

                System.Web.HttpResponse response = System.Web.HttpContext.Current.Response;
                response.ClearContent();
                response.Clear();
                response.ContentType = "text/plain";
                response.AddHeader("Content-Disposition", "attachment; filename=" + resume[3] + ";");
                response.TransmitFile(Server.MapPath(tab.Rows[0]["Resume"].ToString()));
                response.Flush();
                response.End();
            }
            catch
            {

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

                obj.DeleteUser(s[1]);

                ClientScript.RegisterStartupScript(this.GetType(), "key", "<script>alert('User Deleted Successfully')</script>");
                GetAllUsers();
            }
            catch
            {

            }

        }      

    }
}