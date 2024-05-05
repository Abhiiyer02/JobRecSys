<%@ Page Title="" Language="C#" MasterPageFile="~/Guest/GuestMasterpage.Master" AutoEventWireup="true" CodeBehind="_CandidateLogin.aspx.cs" Inherits="staffingProblemProject.Guest._CandidateLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<%-- <link href="../ThemeBlue.css" rel="Stylesheet" type="text/css" />--%>
 <%--<script type="text/javascript">
     function preventBack() { window.history.forward(); }
     setTimeout("preventBack()", 0);
     window.onunload = function () { null };
    </script>--%>
    <style type="text/css">
        .auto-style1 {
            width: 368px;
            height: 57px;
        }
        .auto-style2 {
            width: 364px;
            height: 57px;
        }
        .auto-style3 {
            width: 154px;
            height: 57px;
        }
        .auto-style4 {
            width: 140px;
            height: 57px;
        }
        .auto-style5 {
            width: 100%;
            height: 302px;
        }
        .auto-style6 {
            width: 368px;
            height: 14px;
        }
        .auto-style7 {
            width: 364px;
            height: 14px;
        }
        .auto-style8 {
            width: 154px;
            height: 14px;
        }
        .auto-style9 {
            width: 140px;
            height: 14px;
        }
        .auto-style10 {
            width: 510px;
        }
        .auto-style11 {
            width: 364px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <asp:Panel ID="panelLogin" runat="server">

    <div class="container">

        <div class="section-title">
            <h2><span>CANDIDATES LOGIN </span> FORM!</h2>
        </div>

        <div class="row">

   
  
     

     

                      
            <table style="width: 45%; height: 302px;">
            <tr>
                <td align="center" valign="top" 
                    style="width: 510px;">
                    <table style="background-image: url('../images/loginbg10.jpg'); background-repeat: no-repeat" 
                        align="center" class="auto-style5">
                        <tr>
                            <td style="width: 368px">
                                &nbsp;</td>
                            <td style="text-align: left; color: #006699; " class="auto-style11">
                                &nbsp;</td>
                            <td style="width: 154px">
                                &nbsp;</td>
                            <td style="width: 140px">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td style="width: 368px">
                                &nbsp;</td>
                            <td style="text-align: center; color: #006699; " class="auto-style11">
                                &nbsp;</td>
                            <td style="width: 154px">
                                &nbsp;</td>
                            <td style="width: 140px">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td style="width: 368px">
                                &nbsp;</td>
                            <td style="text-align: left; " class="auto-style11">
                                &nbsp;</td>
                            <td style="width: 154px">
                                &nbsp;</td>
                            <td style="width: 140px">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td style="width: 368px">
                                &nbsp;</td>
                            <td style="text-align: left; color: #006699;" class="auto-style11">
                                <b>Candidate Id</b></td>
                            <td style="width: 154px">
                                &nbsp;</td>
                            <td style="width: 140px">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td style="width: 368px">
                                &nbsp;</td>
                            <td style="text-align: left; " class="auto-style11">
                                <asp:TextBox ID="txtUserId" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="text-align: left; width: 154px">
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                    ControlToValidate="txtUserId" ErrorMessage="Enter UserId" ToolTip="Enter UserId" 
                                    ValidationGroup="login" ForeColor="#FF3300">*</asp:RequiredFieldValidator>
                            </td>
                            <td style="width: 140px; text-align: left">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td style="width: 368px">
                                &nbsp;</td>
                            <td style="text-align: left; color: #006699;" class="auto-style11">
                                <b>Password</b></td>
                            <td style="text-align: left; width: 154px">
                                &nbsp;</td>
                            <td style="width: 140px; text-align: left">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td style="width: 368px">
                                &nbsp;</td>
                            <td style="text-align: left; " class="auto-style11">
                                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Width="200px"></asp:TextBox>
                            </td>
                            <td style="text-align: left; width: 154px">
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                    ControlToValidate="txtPassword" ErrorMessage="Enter Password" ToolTip="Enter Password" 
                                    ValidationGroup="login" ForeColor="#FF3300">*</asp:RequiredFieldValidator>
                            </td>
                            <td style="width: 140px; text-align: left">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style6">
                                </td>
                            <td style="text-align: left; " class="auto-style7">
                                <asp:ImageButton ID="btnLogin" runat="server" ImageUrl="../images/CAUVGTUR.jpg" 
                                    ValidationGroup="login" Height="34px" 
                                    Width="83px" onclick="btnLogin_Click" />
                            </td>
                            <td class="auto-style8">
                                </td>
                            <td class="auto-style9">
                                </td>
                        </tr>
                        <tr>
                            <td class="auto-style1">

                                </td>
                            <td style="text-align: left; " class="auto-style2">
                                Not Registered yet?&nbsp; <a href="UserRegister.aspx">Signup</a></td>
                            <td class="auto-style3">
                                &nbsp;</td>
                            <td class="auto-style4">
                                </td>
                        </tr>
                        
                    </table>
                </td>
            </tr>
                <tr>
                    <td>
                       <table ID="tblMessage" border="0" cellpadding="4" cellspacing="4" 
                        class="auto-style10" align="center">
                        <tr>
                            <td style="text-align: left">
                                <div ID="dvIcon" class="Error">
                                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                                        CssClass="failureNotification" ToolTip="Enter Fields" 
                                        ValidationGroup="login" />
                                    <asp:Label ID="lblError" runat="server"></asp:Label>
                                </div>
                            </td>
                        </tr>
                    </table></td>
                </tr>
        </table>
            
        
         </div>
         </div>

          <br />
           <marquee scrolldelay="50" behavior="alternate">
                        <asp:Image ID="Image1" runat="server" 
                            ImageUrl="~/images/job1.jpg" Height="200px" />
                          
                       
                        </marquee>

                         <br />
         <br />
         
    </asp:Panel>
</asp:Content>
