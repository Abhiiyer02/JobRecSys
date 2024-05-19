using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace staffingProblemProject.Candidate
{
    public partial class DatasetAddition : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Visible = false;
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                BLL obj = new BLL();
                String userId = Session["MLP"].ToString() ;
                bool ok = true;
                int[] values = { int.Parse(DropDownListSSLC.SelectedItem.Value), int.Parse(DropDownListPUC.SelectedItem.Value), int.Parse(DropDownListCS.SelectedItem.Value), int.Parse(DropDownListPSolving.SelectedItem.Value), int.Parse(DropDownListNetworks.SelectedItem.Value), int.Parse(DropDownListOS.SelectedItem.Value), int.Parse(DropDownListDBMS.SelectedItem.Value), int.Parse(DropDownListDS.SelectedItem.Value), int.Parse(DropDownListCloud.SelectedItem.Value), int.Parse(DropDownListContainers.SelectedItem.Value), int.Parse(DropDownListSD.SelectedItem.Value), int.Parse(DropDownListM.SelectedItem.Value), int.Parse(DropDownListVCS.SelectedItem.Value), int.Parse(DropDownListPython.SelectedItem.Value), int.Parse(DropDownListJS.SelectedItem.Value), int.Parse(DropDownListCCCP.SelectedItem.Value), int.Parse(DropDownListJava.SelectedItem.Value) };
                for(int i = 0; i < values.Length; i++)
                {
                    if (values[i] == -1) {
                        ok = false;
                        Label1.Visible = true;
                        break;
                    }
                }
                if (ok)
                {
                    obj.UpdateMLParams(userId, int.Parse(DropDownListSSLC.SelectedItem.Value), int.Parse(DropDownListPUC.SelectedItem.Value), int.Parse(DropDownListCS.SelectedItem.Value), int.Parse(DropDownListPSolving.SelectedItem.Value), int.Parse(DropDownListNetworks.SelectedItem.Value), int.Parse(DropDownListOS.SelectedItem.Value), int.Parse(DropDownListDBMS.SelectedItem.Value), int.Parse(DropDownListDS.SelectedItem.Value), int.Parse(DropDownListCloud.SelectedItem.Value), int.Parse(DropDownListContainers.SelectedItem.Value), int.Parse(DropDownListSD.SelectedItem.Value), int.Parse(DropDownListM.SelectedItem.Value), int.Parse(DropDownListVCS.SelectedItem.Value), int.Parse(DropDownListPython.SelectedItem.Value), int.Parse(DropDownListJS.SelectedItem.Value), int.Parse(DropDownListCCCP.SelectedItem.Value), int.Parse(DropDownListJava.SelectedItem.Value));
                    ClientScript.RegisterStartupScript(this.GetType(), "key", "<script>alert('User Registration is Complete')</script>");
                    Response.Redirect("~/guest/_candidatelogin.aspx");
                }
            }
            catch {
            
            }

        }
    }
}