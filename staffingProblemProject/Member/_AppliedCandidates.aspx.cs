using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Collections;

namespace staffingProblemProject.Member
{
    public partial class _AppliedCandidates : System.Web.UI.Page
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
                    GetAppliedUsers();
                }
            }
            catch
            {

            }
        }


        //function to load the users
        public void GetAppliedUsers()
        {
            BLL obj = new BLL();

            DataTable tabAds = new DataTable();
            tabAds.Rows.Clear();
            tabAds = obj.GetCandidatesByAdId(int.Parse(Request.QueryString["adId"].ToString()));

            if (tabAds.Rows.Count > 0)
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

               

                Table4.Controls.Add(mainrow);

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

                for (int i = 0; i < arrayRecords.Count; i++)
                {
                    TableRow row = new TableRow();

                    DataTable tab = new DataTable();
                    tab = obj.GetUserById(arrayRecords[i].ToString());

                    TableCell cellResume = new TableCell();
                    cellResume.Width = 150;
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

       

    }
}