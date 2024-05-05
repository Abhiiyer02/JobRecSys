<%@ Page Title="" Language="C#" MasterPageFile="~/Member/MemberMasterpage.Master" AutoEventWireup="true" CodeBehind="ViewUsers.aspx.cs" Inherits="staffingProblemProject.Member.ViewUsers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<asp:Panel ID="panelExistingUsers" runat="server">

 <div class="container">

        <div class="section-title">
           <h2><span>JOB SEEKERS</span> IN THE NETWORK </h2>
        </div>

        <div class="row">
          
                         <br />
                    <table align="center" style="width: 93%;">
                        <tr>
                            <td>
                             <div id="popup">
                         <div style="height:400px; width:auto; overflow:auto">
                                <asp:Table ID="Table4" runat="server" Font-Size="Small">
                                </asp:Table>
                                </div>
                                </div>
                            </td>
                        </tr>
                    </table>
                   
       
       </div>
       </div>
       <br />

      <br />
                   
       

    </asp:Panel>
</asp:Content>
