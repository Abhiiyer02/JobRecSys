using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace staffingProblemProject.Admin
{
    public partial class ExistingUsers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["AdminId"] == null)
            {
                Session.Abandon();
                Response.Redirect("../Guest/Index.aspx");
            }
            else
            {
                GetExistingUsers();
            }
        }

        //function to load the existing users
        public void GetExistingUsers()
        {
            BLL obj = new BLL();

            DataTable tab = new DataTable();
            tab.Rows.Clear();
            tab = obj.GetUsersByStatus("Approved");

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
                cell0.Text = "Logo";
                mainrow.Controls.Add(cell0);

                TableHeaderCell cell1 = new TableHeaderCell();
                cell1.Text = "Member Id";
                mainrow.Controls.Add(cell1);

                TableHeaderCell cell2 = new TableHeaderCell();
                cell2.Text = "Name";
                mainrow.Controls.Add(cell2);

                TableHeaderCell cell3 = new TableHeaderCell();
                cell3.Text = "Company Name";
                mainrow.Controls.Add(cell3);
                                
                TableHeaderCell cell4 = new TableHeaderCell();
                cell4.Text = "ContactNo";
                mainrow.Controls.Add(cell4);

                TableHeaderCell cell5 = new TableHeaderCell();
                cell5.Text = "Email ID";
                mainrow.Controls.Add(cell5);

                TableHeaderCell cell6 = new TableHeaderCell();
                cell6.Text = "Delete";
                mainrow.Controls.Add(cell6);

                Table4.Controls.Add(mainrow);

                for (int i = 0; i < tab.Rows.Count; i++)
                {
                    TableRow row = new TableRow();

                    TableCell cellPhoto = new TableCell();
                    cellPhoto.VerticalAlign = VerticalAlign.Top;
                    cellPhoto.Width = 50;
                    cellPhoto.Height = 50;
                    Image imgPhoto = new Image();
                    imgPhoto.Width = 50;
                    imgPhoto.Height = 50;
                    imgPhoto.ImageUrl = tab.Rows[i]["CompanyLogo"].ToString();
                    cellPhoto.Controls.Add(imgPhoto);
                    row.Controls.Add(cellPhoto);

                    TableCell cellMemberId = new TableCell();
                    cellMemberId.Width = 100;
                    cellMemberId.Text = "<a href='#'>" + tab.Rows[i]["MemberId"].ToString() + "<span>Name : " + tab.Rows[i]["Name"].ToString() + ".</br>Address : " + tab.Rows[i]["Address"].ToString() + ".</br>Email ID : " + tab.Rows[i]["EmailId"].ToString() + "</span></a>";
                    row.Controls.Add(cellMemberId);

                    TableCell cellName = new TableCell();
                    cellName.Width = 150;
                    cellName.Text = tab.Rows[i]["Name"].ToString();
                    row.Controls.Add(cellName);
                                       
                    TableCell cellCompanyName = new TableCell();
                    cellCompanyName.Width = 200;
                    cellCompanyName.Text = tab.Rows[i]["CompanyName"].ToString();
                    row.Controls.Add(cellCompanyName);
                                      
                    TableCell cellContactNo = new TableCell();
                    cellContactNo.Width = 100;
                    cellContactNo.Text = tab.Rows[i]["ContactNo"].ToString();
                    row.Controls.Add(cellContactNo);

                    TableCell cellEmailId = new TableCell();
                    cellEmailId.Width = 100;
                    cellEmailId.Text = tab.Rows[i]["EmailId"].ToString();
                    row.Controls.Add(cellEmailId);
                                        
                    TableCell cell_del = new TableCell();

                    Button btn_delete123 = new Button();
                    btn_delete123.ID = tab.Rows[i]["MemberId"].ToString();
                    btn_delete123.Text = "Delete";
                    btn_delete123.OnClientClick = "return confirm('Are you sure want to delete ?')";
                    btn_delete123.Click += new EventHandler(btn_delete123_Click);
                    cell_del.Controls.Add(btn_delete123);
                    row.Controls.Add(cell_del);

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
                cell.Text = "No Existing Users Found";
                row.Controls.Add(cell);

                Table4.Controls.Add(row);

            }
        }

        //click event to delete user
        void btn_delete123_Click(object sender, EventArgs e)
        {
            try
            {
                BLL obj = new BLL();
                Button btn = (Button)sender;
                               

               
                obj.DeleteMember(btn.ID);

                ClientScript.RegisterStartupScript(this.GetType(), "key", "<script>alert('User & realted details Deleted Successfully')</script>");
                GetExistingUsers();
            }
            catch
            {

            }

        }      

    }
}