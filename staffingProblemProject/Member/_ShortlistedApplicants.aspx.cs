using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace staffingProblemProject.Member
{
    public partial class _ShortlistedApplicants : System.Web.UI.Page
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
                    GetShortlistedUsers();
                }
            }
            catch
            {

            }
        }

        public void GetShortlistedUsers()
        {
            BLL obj = new BLL();

            DataTable tabAds = new DataTable();
            tabAds.Rows.Clear();
            tabAds = obj.GetShortlistsByAdId(int.Parse(Request.QueryString["adId"].ToString()));

            if (tabAds.Rows.Count > 0)
            {
                Table5.Rows.Clear();

                ArrayList _arrayUserId = new ArrayList();
                ArrayList _arrayCnt = new ArrayList();

                _arrayCnt.Clear();
                _arrayUserId.Clear();

                //code to find suitable candidates.
                for (int i = 0; i < tabAds.Rows.Count; i++)
                {
                    int _skillsCnt = 0;

                    DataTable tabUser = new DataTable();
                    tabUser = obj.GetUserById(tabAds.Rows[i]["UserId"].ToString());

                    DataTable tabAd = new DataTable();
                    tabAd = obj.GetAdsById(int.Parse(tabAds.Rows[i]["AdsId"].ToString()));

                    string[] AdsSkills = tabAd.Rows[0]["SkillsRequired"].ToString().Split(',').Select(skill => skill.Trim()).ToArray();

                    string[] UserSkills = tabUser.Rows[0]["Skills"].ToString().Split(',').Select(skill => skill.Trim()).ToArray();

                    for (int j = 0; j < AdsSkills.Length; j++)
                    {
                        //skills matching
                        //array.Contains("str", StringComparer.CurrentCultureIgnoreCase);
                        //array.Contains("str", StringComparer.InvariantCultureIgnoreCase);

                        if (UserSkills.Contains(AdsSkills[j], StringComparer.OrdinalIgnoreCase))
                        {
                            ++_skillsCnt;
                        }
                    }

                    //add cnt and user id
                    if (_skillsCnt > 0)
                    {
                        _arrayUserId.Add(tabAds.Rows[i]["UserId"].ToString());
                        _arrayCnt.Add(_skillsCnt);
                    }
                }

                //check users with more matchings
                ArrayList temp = new ArrayList();
                ArrayList arrayRecords = new ArrayList();

                ArrayList arrayExists = new ArrayList();
                int d = 0;

                for (int x = 0; x < _arrayCnt.Count; x++)
                {
                    temp.Add(_arrayCnt[x]);
                }

                temp.Sort();
                temp.Reverse();

                for (int y = 0; y < _arrayCnt.Count; y++)
                {
                    d = 0;

                    for (int z = 0; z < _arrayCnt.Count; z++)
                    {
                        if (_arrayCnt[z].Equals(temp[y]))
                        {
                            if (d == 0 && !arrayExists.Contains(_arrayUserId[z]))
                            {
                                arrayRecords.Add(_arrayUserId[z]);

                                arrayExists.Add(_arrayUserId[z]);

                                ++d;
                            }
                        }
                    }
                }

                if (arrayRecords.Count > 0)
                {
                    Table5.BorderStyle = BorderStyle.Double;
                    Table5.GridLines = GridLines.Both;
                    Table5.BorderColor = System.Drawing.Color.DarkGray;

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
                    cell4.Text = "Contact No";
                    mainrow.Controls.Add(cell4);

                    TableHeaderCell cell5 = new TableHeaderCell();
                    cell5.Text = "Email ID";
                    mainrow.Controls.Add(cell5);

                    TableHeaderCell cell6 = new TableHeaderCell();
                    cell6.Text = "Skills";
                    mainrow.Controls.Add(cell6);

                    TableHeaderCell cell7 = new TableHeaderCell();
                    cell7.Text = "Offer Job";
                    mainrow.Controls.Add(cell7);

                    Table5.Controls.Add(mainrow);

                    for (int i = 0; i < arrayRecords.Count; i++)
                    {
                        TableRow row = new TableRow();

                        DataTable tab = new DataTable();
                        tab = obj.GetUserById(arrayRecords[i].ToString());

                        TableCell cellResume = new TableCell();
                        cellResume.Width = 250;
                        cellResume.Font.Bold = true;
                        LinkButton lbtnResume = new LinkButton();
                        lbtnResume.ID = "res~" + tab.Rows[0]["UserId"].ToString();
                        lbtnResume.Text = "Download Resume";
                        lbtnResume.OnClientClick = "return confirm('Are you sure want to Download ?')";
                        lbtnResume.Click += new EventHandler(lbtnResume_Click);
                        cellResume.Controls.Add(lbtnResume);
                        row.Controls.Add(cellResume);

                        TableCell cellMemberId = new TableCell();
                        cellMemberId.Width = 100;
                        cellMemberId.Text = "<a href='#'>" + tab.Rows[0]["Name"].ToString() + "<span>Name : " + tab.Rows[0]["Name"].ToString() + ".</br>Address : " + tab.Rows[0]["Address"].ToString() + ".</br>Email ID : " + tab.Rows[0]["EmailId"].ToString() + "</span></a>";
                        row.Controls.Add(cellMemberId);


                        TableCell cellContactNo = new TableCell();
                        cellContactNo.Width = 100;
                        cellContactNo.Text = tab.Rows[0]["ContactNo"].ToString();
                        row.Controls.Add(cellContactNo);

                        TableCell cellEmailId = new TableCell();
                        cellEmailId.Width = 100;
                        cellEmailId.Text = tab.Rows[0]["EmailId"].ToString();
                        row.Controls.Add(cellEmailId);

                        TableCell cellSkills = new TableCell();
                        cellSkills.Width = 550;
                        cellSkills.Text = tab.Rows[0]["Skills"].ToString();
                        row.Controls.Add(cellSkills);

                        TableCell cell_shortlist = new TableCell();
                        Button btn_shortlist = new Button();
                        btn_shortlist.ID = "offer~" + tab.Rows[0]["UserId"].ToString();

                        if (obj.CheckJobOffer(tab.Rows[0]["UserId"].ToString(), int.Parse(Request.QueryString["adId"].ToString())))
                        {
                            btn_shortlist.Text = "OFFER JOB";
                            btn_shortlist.OnClientClick = "return confirm('Are you sure want to send a JOB OFFER to this Applicant ?')";
                        }
                        else
                        {
                            btn_shortlist.Text = "JOB OFFERED";
                            btn_shortlist.BackColor = System.Drawing.Color.Lime;
                        }

                        btn_shortlist.Click += new EventHandler(btn_offerJob_Click);
                        cell_shortlist.Controls.Add(btn_shortlist);
                        row.Controls.Add(cell_shortlist);

                        Table5.Controls.Add(row);
                    }
                }
            }
            else
            {
                Table5.Rows.Clear();
                Table5.GridLines = GridLines.None;

                TableHeaderRow row = new TableHeaderRow();
                TableHeaderCell cell = new TableHeaderCell();
                cell.ColumnSpan = 5;
                cell.ForeColor = System.Drawing.Color.Red;
                cell.Text = "Shortlist Applicants to initiate hiring...";
                row.Controls.Add(cell);

                Table5.Controls.Add(row);
            }
        }

        void lbtnResume_Click(object sender, EventArgs e)
        {
            try
            {
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

        void btn_offerJob_Click(object sender, EventArgs e)
        {
            BLL obj = new BLL();
            Button lbtn = (Button)sender;
            string[] s = lbtn.ID.ToString().Split('~');

            try
            {
                if (obj.CheckJobOffer(s[1], int.Parse(Request.QueryString["adId"].ToString())))
                {
                    DataTable Ad = obj.GetAdsById(int.Parse(Request.QueryString["adId"].ToString()));
                    DataTable User = obj.GetUserById(s[1]);
                    obj.InsertJobOffer(s[1], int.Parse(Request.QueryString["adId"].ToString()));

                    // TODO: Add code for updating the dataset (DYNAMIC DATASET for ML Decisions)

                    MailMessage mail = new MailMessage();
                    mail.To.Add(User.Rows[0][5].ToString());
                    mail.From = new MailAddress("onlinenotes56@gmail.com", "Job Portal", System.Text.Encoding.UTF8);
                    mail.Subject = "Job Offer for Job ID" + Ad.Rows[0][0];
                    mail.SubjectEncoding = System.Text.Encoding.UTF8;
                    mail.Body = "<h3> Congratulations " + User.Rows[0]["Name"] + " !!!</h3>" + "Happy News! <strong>" + Ad.Rows[0][1] + "</strong> " + "has offered you their latest opening/position as <strong>" + Ad.Rows[0][3] + "</strong>" +
                    "<br>Job Application details are as follows:<br>Job ID " + Ad.Rows[0][0] + "<br> Posted by: " + Ad.Rows[0][1] + "<br> Role:" + Ad.Rows[0][3] + "<br>";
                    mail.BodyEncoding = System.Text.Encoding.UTF8;
                    mail.IsBodyHtml = true;
                    mail.Priority = MailPriority.High;
                    SmtpClient client = new SmtpClient();
                    client.Credentials = new System.Net.NetworkCredential("onlinenotes56@gmail.com", "kwaaisxwvqjwbdnz");
                    client.Port = 587;
                    client.Host = "smtp.gmail.com";
                    client.EnableSsl = true;
                    client.Send(mail);
                    ClientScript.RegisterStartupScript(this.GetType(), "Key", "<Script>alert('Job Offer mail sent successfully!')</script>");
                    GetShortlistedUsers();
                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "Key", "<Script>alert('Job has already been Offered to this Applicant!')</script>");
                }
            }
            catch (Exception ex)
            {
                Exception ex2 = ex;
                string errorMessage = string.Empty;
                while (ex2 != null)
                {
                    errorMessage += ex2.ToString();
                    ex2 = ex2.InnerException;
                }
                ClientScript.RegisterStartupScript(this.GetType(), "Key", "<script>alert('Sending Failed...');}</script>");
            }
        }
    }
}