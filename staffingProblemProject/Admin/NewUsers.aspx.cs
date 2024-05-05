using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace staffingProblemProject.Admin
{
    public partial class NewUsers : System.Web.UI.Page
    {
        BLL obj = new BLL();
        DataTable tab = new DataTable();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["AdminId"] == null)
            {
                Session.Abandon();
                Response.Redirect("../Guest/Index.aspx");
            }
            else
            {
                GetNewUsers();
            }
        }

        //function to load new registered users
        private void GetNewUsers()
        {
            tab.Rows.Clear();
            tab = obj.GetUsersByStatus("Pending");

            if (tab.Rows.Count > 0)
            {
                Table1.Rows.Clear();

                Table1.BorderStyle = BorderStyle.Double;
                Table1.GridLines = GridLines.Both;
                Table1.BorderColor = System.Drawing.Color.DarkGray;

                TableRow mainrow = new TableRow();
                mainrow.Height = 30;
                mainrow.ForeColor = System.Drawing.Color.WhiteSmoke;

                mainrow.BackColor = System.Drawing.Color.Gray;

                TableCell cell1 = new TableCell();
                cell1.Text = "<b>Check</b>";
                mainrow.Controls.Add(cell1);

                TableCell cell2 = new TableCell();
                cell2.Text = "<b>MemberId</b>";
                mainrow.Controls.Add(cell2);

                TableCell cell3 = new TableCell();
                cell3.Text = "<b>Name</b>";
                mainrow.Controls.Add(cell3);

                TableCell cell4 = new TableCell();
                cell4.Text = "<b>CompName</b>";
                mainrow.Controls.Add(cell4);

                TableCell cell5 = new TableCell();
                cell5.Text = "<b>Address</b>";
                mainrow.Controls.Add(cell5);

                TableCell cell6 = new TableCell();
                cell6.Text = "<b>ContactNo</b>";
                mainrow.Controls.Add(cell6);

                TableCell cell7 = new TableCell();
                cell7.Text = "<b>EmailId</b>";
                mainrow.Controls.Add(cell7);

                TableCell cell8 = new TableCell();
                cell8.Text = "<b>ReceiptNo</b>";
                mainrow.Controls.Add(cell8);

                TableCell cell9 = new TableCell();
                cell9.Text = "<b>RegisterDate</b>";
                mainrow.Controls.Add(cell9);
                
                Table1.Controls.Add(mainrow);

                for (int i = 0; i < tab.Rows.Count; i++)
                {
                    TableRow row = new TableRow();

                    TableCell cell_Check = new TableCell();

                    CheckBox che = new CheckBox();
                    che.ID = tab.Rows[i]["MemberId"].ToString();

                    cell_Check.Controls.Add(che);
                    row.Controls.Add(cell_Check);

                    TableCell cell_ID = new TableCell();
                    cell_ID.Width = 150;
                    cell_ID.Text = tab.Rows[i]["MemberId"].ToString();
                    row.Controls.Add(cell_ID);

                    TableCell cellName = new TableCell();
                    cellName.Width = 150;
                    cellName.Text = tab.Rows[i]["Name"].ToString();
                    row.Controls.Add(cellName);

                    TableCell cell_name = new TableCell();
                    cell_name.Width = 200;
                    cell_name.Text = tab.Rows[i]["CompanyName"].ToString();
                    row.Controls.Add(cell_name);

                    TableCell cell_address = new TableCell();
                    cell_address.Width = 200;
                    cell_address.Text = tab.Rows[i]["Address"].ToString();
                    row.Controls.Add(cell_address);
                    
                    TableCell cell_mobile = new TableCell();
                    cell_mobile.Width = 150;
                    cell_mobile.Text = tab.Rows[i]["ContactNo"].ToString();
                    row.Controls.Add(cell_mobile);

                    TableCell cell_Email = new TableCell();
                    cell_Email.Width = 150;
                    cell_Email.Text = tab.Rows[i]["EmailId"].ToString();
                    row.Controls.Add(cell_Email);

                    TableCell cellReceipt = new TableCell();
                    cellReceipt.Width = 100;
                    cellReceipt.Text = tab.Rows[i]["ReceiptNumber"].ToString();
                    row.Controls.Add(cellReceipt);

                    TableCell cellDate = new TableCell();
                    cellDate.Width = 150;
                    cellDate.Text = tab.Rows[i]["RegisteredDate"].ToString();
                    row.Controls.Add(cellDate);

                    Table1.Controls.Add(row);
                    
                }
            }
            else
            {
                Table1.Rows.Clear();
                Table1.GridLines = GridLines.None;

                TableRow rno = new TableRow();
                TableCell cellno = new TableCell();
                cellno.ColumnSpan = 10;
                cellno.ForeColor = System.Drawing.Color.Red;
                cellno.Font.Size = 10;
                cellno.Text = "<b>No New Users Found</b>";
                cellno.HorizontalAlign = HorizontalAlign.Center;
                rno.Controls.Add(cellno);
                Table1.Controls.Add(rno);
            }
        }

        //click event to approve the new registered users
        protected void btn_Approve_Click(object sender, EventArgs e)
        {
            BLL obj=new BLL ();
            DataTable tab1=new DataTable ();

            try
            {
                int q = 0;

                if (CheckSelection())
                {
                    for (int i = 1; i < Table1.Rows.Count; i++)
                    {
                        CheckBox chk = (CheckBox)Table1.FindControl(tab.Rows[q]["MemberId"].ToString());

                        tab1 = obj.GetMemberById(chk.ID.ToString());

                        if (chk.Checked)
                        {
                            obj.UpdateStatus("Approved", chk.ID.ToString());
                            //Emails.MailSender.SendEmail("soujanyapes@gmail.com", "sahasouju", tab1.Rows[0]["EmailId"].ToString(), "Approved", "Registration Details Approved Successfully", "");
                        }
                        ++q;

                       
                        
                    }
                    
                    ClientScript.RegisterStartupScript(this.GetType(), "Key", "<script>alert('Users Approved Successfully')</script>");
                    GetNewUsers();
                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "Key", "<script>alert('Select the users')</script>");

                }
            }
            catch
            {

            }
        }

        //click event to reject the new registered users
        protected void btn_Reject_Click(object sender, EventArgs e)
        {
            BLL obj = new BLL();
            DataTable tab1 = new DataTable();

            try
            {
                int q = 0;

                if (CheckSelection())
                {
                    for (int i = 1; i < Table1.Rows.Count; i++)
                    {
                        CheckBox chk = (CheckBox)Table1.FindControl(tab.Rows[q]["MemberId"].ToString());
                        tab1 = obj.GetMemberById(chk.ID.ToString());

                        if (chk.Checked)
                        {
                            obj.DeleteMember(chk.ID.ToString());
                            //Emails.MailSender.SendEmail("soujanyapes@gmail.com", "sahasouju", tab1.Rows[0]["EmailId"].ToString(), "Rejected", "Registration Details Rejected Successfully", "");
                        }
                        ++q;

                    }

                    ClientScript.RegisterStartupScript(this.GetType(), "Key", "<script>alert('Users Rejected Successfully')</script>");
                    GetNewUsers();
                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "Key", "<script>alert('Select the users')</script>");

                }
            }
            catch
            {

            }
        }

        //function to check the users selection
        public bool CheckSelection()
        {
            int q = 0;

            foreach (TableRow row in Table1.Rows)
            {
                if (q < Table1.Rows.Count - 1)
                {
                    CheckBox chk = (CheckBox)row.FindControl(tab.Rows[q]["MemberId"].ToString());

                    if (chk.Checked)
                    {
                        return true; ;
                    }

                    ++q;
                }
            }

            return false;
        }
        
    }
}