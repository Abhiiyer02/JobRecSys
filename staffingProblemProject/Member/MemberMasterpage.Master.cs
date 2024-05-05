using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace staffingProblemProject.Member
{
    public partial class MemberMasterpage : System.Web.UI.MasterPage
    {
        static string value = null;

        protected void Page_Load(object sender, EventArgs e)
        {

            if (Request.QueryString["value"] == null)
            {

            }
            else
            {
                value = Request.QueryString["value"].ToString();

                if (value.Equals("a"))
                {
                    ads.Style.Value = "color:#FFFFFF;font-style:italic;font-weight:bold;background: #629fd3;";
                }
                else if (value.Equals("b"))
                {
                    view.Style.Value = "color:#FFFFFF;font-style:italic;font-weight:bold;background: #629fd3;";
                }
                else if (value.Equals("c"))
                {
                    candidates.Style.Value = "color:#FFFFFF;font-style:italic;font-weight:bold;background: #629fd3;";
                }

                
                else if (value.Equals("d"))
                {
                    search.Style.Value = "color:#FFFFFF;font-style:italic;font-weight:bold;background: #629fd3;";
                }
                else if (value.Equals("e"))
                {
                    profile.Style.Value = "color:#FFFFFF;font-style:italic;font-weight:bold;background: #629fd3;";
                }

                Response.AppendHeader("Cache-Control", "no-store");
            }
        }
    }
}