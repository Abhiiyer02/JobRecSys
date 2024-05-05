﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Candidate/CandidateMP.Master" AutoEventWireup="true" CodeBehind="CandidateAccount.aspx.cs" Inherits="staffingProblemProject.Candidate.CandidateAccount" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<%-- <link href="../ThemeBlue.css" rel="Stylesheet" type="text/css" />--%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<asp:Panel ID="panelAdminPassword" runat="server">

  <div class="container">

        <div class="section-title">
           <h2><span>CHANGE </span> PASSWORD !</h2>
        </div>

        <div class="row">

   

  
     
       <table style="width:55%;">
                    <tr>
                        <td>
                            &nbsp;</td>
                        <td>
                          <fieldset>
                <legend>Changepassword</legend>
                <table align="center" style="width: 95%;">
                    <tr>
                        <td class="style1">
                            <strong>Input Oldpassword</strong></td>
                        <td>
                            <asp:TextBox ID="txtOldpassword" runat="server" Width="200px" 
                                TextMode="Password"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                ControlToValidate="txtOldpassword" CssClass="failureNotification" 
                                ErrorMessage="Enter Old password" ToolTip="Enter Old password" 
                                ValidationGroup="password">*</asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="style1">
                            <strong>Input Newpassword</strong></td>
                        <td>
                            <asp:TextBox ID="txtNewpassword" runat="server" Width="200px" 
                                TextMode="Password"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                ControlToValidate="txtNewpassword" CssClass="failureNotification" 
                                ErrorMessage="Enter Newpassword" ToolTip="Enter Newpassword" 
                                ValidationGroup="password">*</asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="style1">
                            <strong>Confirm Password</strong></td>
                        <td>
                            <asp:TextBox ID="txtConfirmpassword" runat="server" Width="200px" 
                                TextMode="Password"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                ControlToValidate="txtConfirmpassword" CssClass="failureNotification" 
                                ErrorMessage="Enter Confirmpassword" ToolTip="Enter Confirmpassword" 
                                ValidationGroup="password">*</asp:RequiredFieldValidator>
                            <asp:CompareValidator ID="CompareValidator1" runat="server" 
                                ControlToCompare="txtNewpassword" ControlToValidate="txtConfirmpassword" 
                                ErrorMessage="Confirm password incorrect" ToolTip="Confirm password incorrect" 
                                ValidationGroup="password" CssClass="failureNotification">*</asp:CompareValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="style1">
                            &nbsp;</td>
                        <td>
                            <asp:ImageButton ID="imgbtnChangepwd" runat="server" Height="40px" 
                                ImageUrl="~/images/resetpwd.jpg" onclick="imgbtnChangepwd_Click" 
                                Width="150px" ValidationGroup="password" />
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
                                                                    <asp:Label ID="lblPasswordError" runat="server"></asp:Label>
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
                                                                    <asp:Label ID="lblPasswordSuccess" runat="server"></asp:Label>
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
