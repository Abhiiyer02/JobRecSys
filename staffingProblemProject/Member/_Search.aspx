<%@ Page Title="" Language="C#" MasterPageFile="~/Member/MemberMasterpage.Master" AutoEventWireup="true" CodeBehind="_Search.aspx.cs" Inherits="staffingProblemProject.Member._Search" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="panelExistingUsers" runat="server">

 <div class="container">

        <div class="section-title">
           <h2><span>SEARCH JOB SEEKER BY SKILL</span> </h2>
        </div>

        <div class="row">
          
                         <table style="width:100%;">
                             <tr>
                                 <td>
                                     Enter Skill</td>
                                 <td>
                                     <asp:TextBox ID="TextBox1" runat="server" Width="650px"></asp:TextBox>
                                 </td>
                                 <td>
                                     <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                         ControlToValidate="TextBox1" CssClass="failureNotification" 
                                         ErrorMessage="Enter Skills Saperated By Comma" Font-Size="Small"></asp:RequiredFieldValidator>
                                 </td>
                             </tr>
                             <tr>
                                 <td>
                                     &nbsp;</td>
                                 <td>
                                     Enter Skills Saperated By Comma</td>
                                 <td>
                                     &nbsp;</td>
                             </tr>
                             <tr>
                                 <td>
                                     &nbsp;</td>
                                 <td>
                                     <asp:Button ID="btnSearch" runat="server" onclick="btnSearch_Click" 
                                         Text="Search" />
                                 </td>
                                 <td>
                                     &nbsp;</td>
                             </tr>
                         </table>
          
                         <br />
                    <table align="center" style="width: 93%;">
                        <tr>
                            <td>
                             <div id="popup">
                         <div style="height:400px; width:auto; overflow:auto">
                                <asp:Table ID="Table4" runat="server" Font-Size="Small" Font-Names="poppins" HorizontalAlign="Center">
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
