<%@ Page Title="" Language="C#" MasterPageFile="~/Candidate/CandidateMP.Master" AutoEventWireup="true" CodeBehind="_Jobs.aspx.cs" Inherits="staffingProblemProject.Candidate._Search" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 126px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<asp:Panel ID="panelExistingUsers" runat="server">

 <div class="container">

        <div class="section-title">
           <h2><span>JOB POSTINGS</span> </h2>
        </div>

        <div class="row">
          
                         <table align="center" style="width: 95%;">
                             <tr>
                                 <td class="auto-style1">
                                     <strong>Job Domain</strong></td>
                                 <td>
                                     <asp:DropDownList ID="ddlJobType" runat="server" Width="250px">
                                      <asp:ListItem Selected="True">All Jobs</asp:ListItem>
                                         <asp:ListItem>Web Development</asp:ListItem>
                                         <asp:ListItem>DevOps</asp:ListItem>
                                         <asp:ListItem>Data Science</asp:ListItem>
                                         <asp:ListItem>Networks Engineering</asp:ListItem>
                                         <asp:ListItem>Cybersecurity</asp:ListItem>
                                         <asp:ListItem>Software Development</asp:ListItem>
                                         <asp:ListItem>Software Testing</asp:ListItem>
                                         <asp:ListItem>UI/UX Development</asp:ListItem>
                                         <asp:ListItem>Quality and Assurance</asp:ListItem>
                                         <asp:ListItem>Embedded Systems Development</asp:ListItem>
                                     </asp:DropDownList>
                                 </td>
                                 <td>
                                     <asp:Button ID="btnSearch" runat="server" onclick="btnSearch_Click" 
                                         Text="Search" />
                                 </td>
                             </tr>
                         </table>
          
                         <br />
                         <br />
          
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
       &nbsp;<br />
      <br />
                   
       

    </asp:Panel>
</asp:Content>
