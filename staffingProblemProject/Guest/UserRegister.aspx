<%@ Page Title="" Language="C#" MasterPageFile="~/Guest/GuestMasterpage.Master" AutoEventWireup="true" CodeBehind="UserRegister.aspx.cs" Inherits="staffingProblemProject.Guest.UserRegister" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<asp:Panel ID="panelRegister" runat="server">

  <div class="container">

        <div class="section-title">
         <h2><span>REGISTER </span> FORM FOR NEW USERS!</h2>
        </div>

        <div class="row" >
            <table style="width:100%;">
                <tr>
                    <td>
                        <table style="width: 448px;">
                            <tr>
                                <td "501px;" align="center" valign="top" width:="">
                                    <fieldset>
                                        <legend>Create your Account</legend>
                                        <table style="width: 85%;">
                                            <tr>
                                                <td style="text-align: left; width: 127px; font-size: small;">
                                                    <strong>User Id</strong><span style="color:red"> *</span></td>
                                                <td style="text-align: left; width: 151px">
                                                    <asp:TextBox ID="txtUserId" runat="server" Width="200px"></asp:TextBox>
                                                </td>
                                                <td style="text-align: left">
                                                    &nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td style="text-align: left; width: 127px; font-size: small;">
                                                    <strong>Password</strong><span style="color:red"> *</span></td>
                                                <td style="text-align: left; width: 151px">
                                                    <asp:TextBox ID="txtPassword" runat="server" Width="200px" TextMode="Password"></asp:TextBox>
                                                </td>
                                                <td style="text-align: left">
                                                    &nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td style="text-align: left; width: 127px; font-size: small;">
                                                    &nbsp;</td>
                                                <td style="text-align: left; width: 151px">
                                                    &nbsp;</td>
                                                <td style="text-align: left">
                                                    &nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td style="text-align: left; width: 127px; font-size: small;">
                                                    <strong>Name</strong><span style="color:red"> *</span></td>
                                                <td style="text-align: left; width: 151px">
                                                    <asp:TextBox ID="txtName" runat="server" Width="200px"></asp:TextBox>
                                                </td>
                                                <td style="text-align: left">
                                                    &nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td style="text-align: left; width: 127px; font-size: small;">
                                                    <b>Address</b><span style="color:red"> *</span></td>
                                                <td style="text-align: left; width: 151px">
                                                    <asp:TextBox ID="txtAddress" runat="server" Font-Size="Small" Height="75px" 
                                                        TextMode="MultiLine" Width="200px"></asp:TextBox>
                                                </td>
                                                <td style="text-align: left">
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                                                        ControlToValidate="txtAddress" CssClass="failureNotification" 
                                                        ErrorMessage="Enter Street Address" Font-Size="Small" 
                                                        ToolTip="Enter StreetAddress" ValidationGroup="registration">*</asp:RequiredFieldValidator>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td style="text-align: left; width: 127px; font-size: small;">
                                                    <b>Phone Number</b><span style="color:red"> *</span></td>
                                                <td style="text-align: left; width: 151px">
                                                    <asp:TextBox ID="txtPhone" runat="server" Font-Size="Small" Width="200px"></asp:TextBox>
                                                </td>
                                                <td style="text-align: left">
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                                                        ControlToValidate="txtPhone" CssClass="failureNotification" 
                                                        ErrorMessage="Enter Phone Number" Font-Size="Small" 
                                                        ToolTip="Enter Phone Number" ValidationGroup="registration">*</asp:RequiredFieldValidator>
                                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                                                        ControlToValidate="txtPhone" CssClass="failureNotification" 
                                                        ErrorMessage="Invalid Number" Font-Size="Small" ToolTip="Invalid Number" 
                                                        ValidationExpression="\d{10}" ValidationGroup="registration">*</asp:RegularExpressionValidator>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td style="text-align: left; width: 127px; font-size: small;">
                                                    <b>Email ID</b><span style="color:red"> *</span></td>
                                                <td style="text-align: left; width: 151px">
                                                    <asp:TextBox ID="txtEmailId" runat="server" Font-Size="Small" Width="200px"></asp:TextBox>
                                                </td>
                                                <td style="text-align: left">
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                                        ControlToValidate="txtEmailId" CssClass="failureNotification" 
                                                        ErrorMessage="Enter Email Id" Font-Size="Small" ToolTip="Enter Email Id" 
                                                        ValidationGroup="registration">*</asp:RequiredFieldValidator>
                                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                                                        ControlToValidate="txtEmailId" CssClass="failureNotification" 
                                                        ErrorMessage="Invalid EmailId" Font-Size="Small" ToolTip="Invalid EmailId" 
                                                        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                                                        ValidationGroup="registration">*</asp:RegularExpressionValidator>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td style="text-align: left; width: 127px; font-size: small;">
                                                    <strong>Resume</strong><span style="color:red"> *</span></td>
                                                <td style="text-align: left; width: 151px">
                                                    <asp:FileUpload ID="fileuploadPhoto" runat="server" Width="200px" />
                                                </td>
                                                <td style="text-align: left">
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" 
                                                        ControlToValidate="fileuploadPhoto" CssClass="failureNotification" 
                                                        ErrorMessage="Upload Photo" ToolTip="Upload Photo" 
                                                        ValidationGroup="registration">*</asp:RequiredFieldValidator>
                                                </td>
                                            </tr>                                   
                                            <tr>
                                                <td style="text-align: left; width: 127px; font-size: small;">
                                                    <strong>Skills</strong><span style="color:red"> *</span></td>
                                                <td style="text-align: left; width: 151px">
                                                    <asp:TextBox ID="txtSkills" runat="server" Height="150px" TextMode="MultiLine" 
                                                        Width="200px"></asp:TextBox>
                                                </td>
                                                <td style="text-align: left">
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" 
                                                        ControlToValidate="txtSkills" CssClass="failureNotification" 
                                                        ErrorMessage="Enter Skills" ToolTip="Enter Skills" 
                                                        ValidationGroup="registration">*</asp:RequiredFieldValidator>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td style="width: 127px">
                                                    &nbsp;</td>
                                                <td align="left">
                                                    saperated by ,&nbsp;</td>
                                                <td>
                                                    &nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td style="width: 127px">
                                                    &nbsp;</td>
                                                <td align="left">
                                                    <asp:ImageButton ID="imagebtnRegister" runat="server" Height="55px" 
                                                        ImageUrl="~/images/registericon.png" onclick="imagebtnRegister_Click" 
                                                        ValidationGroup="registration" Width="180px" />
                                                </td>
                                                <td>
                                                    &nbsp;</td>
                                            </tr>
                                        </table>
                                    </fieldset>
                                    <br />
                                    <span style="color: #FF3300; font-weight: bold; font-size: small;">PLEASE NOTE 
                                    DOWN YOUR USER ID FOR FUTURE USE....<br /> </span>
                                    <br />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <table ID="tblMessage" border="0" cellpadding="4" cellspacing="4" class="Error">
                                        <tr>
                                            <td style="text-align: left">
                                                <div ID="dvIcon" class="Error">
                                                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                                                        CssClass="failureNotification" ToolTip="Enter Fields" 
                                                        ValidationGroup="registration" />
                                                    <asp:Label ID="lblError" runat="server"></asp:Label>
                                                </div>
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
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
                                    </table>
                                </td>
                            </tr>
                        </table>
                    </td>
                    <td>
        </div>                 
                       </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
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
