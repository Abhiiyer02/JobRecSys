<%@ Page Title="" Language="C#" MasterPageFile="~/Member/MemberMasterpage.Master" AutoEventWireup="true" CodeBehind="_PostAds.aspx.cs" Inherits="staffingProblemProject.Member._PostAds" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<%-- <link href="../ThemeBlue.css" rel="Stylesheet" type="text/css" />--%>
    <style type="text/css">
        .style1
        {
            height: 36px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<asp:Panel ID="panelMemberAccount" runat="server">
 <div class="container">

        <div class="section-title">
           <h2><span>POST</span> NEW JOBS</h2>
        </div>

        <div class="row">

   


    
     
      <br />
     <table style="width:75%;">
                    <tr>
                        <td>
                            &nbsp;</td>
                        <td>
                          <fieldset>
                <%--<legend>Post Ads</legend>--%>
                <table align="center" style="width: 95%;">
                    <tr>
                        <td class="style1">
                            <strong>Job Domain</strong></td>
                        <td>
                            <asp:DropDownList ID="ddlJobType" runat="server" Width="250px">
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
                           
                        </td>
                    </tr>
                    <tr>
                        <td class="style1">
                            <strong>Job Title</strong></td>
                        <td>
                            <asp:TextBox ID="txtJobSubtype" runat="server" Width="250px" 
                                ></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                ControlToValidate="txtJobSubtype" CssClass="failureNotification" 
                                ErrorMessage="Enter JobSubType" ToolTip="Enter JobSubType" 
                                ValidationGroup="password">Enter JobSubType</asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="style1">
                            <strong>Skills</strong></td>
                        <td>
                            <asp:TextBox ID="txtSkills" runat="server" Width="250px" 
                                TextMode="MultiLine"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                ControlToValidate="txtSkills" CssClass="failureNotification" 
                                ErrorMessage="Enter Skills" ToolTip="Enter Skills" 
                                ValidationGroup="password">Enter Skills</asp:RequiredFieldValidator>
                            
                        </td>
                    </tr>
                    <tr>
                        <td class="style1">
                         <strong>   Job Description</strong></td>
                        <td>
                            <asp:TextBox ID="txtJobDesc" runat="server" TextMode="MultiLine" Width="259px"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                                ControlToValidate="txtJobDesc" CssClass="failureNotification" 
                                ErrorMessage="Enter Desc" ToolTip="Enter Desc" ValidationGroup="password">Enter Desc</asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="style1">
                           <strong> Status</strong></td>
                        <td class="style1">
                            <asp:DropDownList ID="ddlStatus" runat="server" Width="250px">
                                <asp:ListItem>Active</asp:ListItem>
                                <asp:ListItem>Closed</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td class="style1">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style1">
                        </td>
                        <td class="style1">
                        </td>
                        <td class="style1">
                        </td>
                    </tr>
                    <tr>
                        <td class="style1">
                            &nbsp;</td>
                        <td>
                            <asp:Button ID="btnAds" runat="server" Height="50px" onclick="btnAds_Click" 
                                Text="Submit" Width="150px" ValidationGroup="password" />
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                </table>
             </fieldset>
                           </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;</td>
                        <td><table ID="tblMessage" border="0" cellpadding="4" cellspacing="4" class="Error">
                                                        <tr>
                                                            <td style="text-align: left">
                                                                <div ID="dvIcon" class="Error">
                                                                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                                                                        CssClass="failureNotification" ToolTip="Enter Fields" ValidationGroup="password" />
                                                                    <asp:Label ID="lblError" runat="server"></asp:Label>
                                                                </div>
                                                            </td>
                                                        </tr>
                                                    </table>
                           </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;</td>
                        <td>
                            <table ID="tblMessage" border="0" cellpadding="4" cellspacing="4" 
                                                        class="Success">
                                                        <tr>
                                                            <td>
                                                                <div ID="dvIcon" class="Success">
                                                                    <asp:Label ID="lblSuccess" runat="server"></asp:Label>
                                                                </div>
                                                            </td>
                                                        </tr>
                                                    </table></td>
                        <td>
                            &nbsp;</td>
                    </tr>
                </table>
            
            </div>
            </div>

            <br />

            <br />
    </asp:Panel>

</asp:Content>
