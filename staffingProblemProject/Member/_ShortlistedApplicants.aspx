<%@ Page Title="" Language="C#" MasterPageFile="~/Member/MemberMasterpage.Master" AutoEventWireup="true" CodeBehind="_ShortlistedApplicants.aspx.cs" Inherits="staffingProblemProject.Member._ShortlistedApplicants" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="panelExistingUsers" runat="server">
         <div class="container">

               <div class="section-title">
                  <h2><span>SHORTLISTED</span> APPLICANTS </h2>
               </div>

               <div class="row">
     
                                <br />
                           <table align="center" style="width: 93%;">
                               <tr>
                                   <td>
                                    <div id="popup">
                                        <div style="height:400px; width:auto; overflow:auto">
                                               
                                            <asp:Table ID="Table5" runat="server" Font-Size="Small">
                                            </asp:Table>
                                               
                                        </div>
                                    </div>
                                   </td>
                               </tr>
                           </table>
               </div>
          </div>
               
   

    </asp:Panel>
</asp:Content>
