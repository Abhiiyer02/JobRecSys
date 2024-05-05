<%@ Page Title="" Language="C#" MasterPageFile="~/Member/MemberMasterpage.Master" AutoEventWireup="true" CodeBehind="UpdateProfile.aspx.cs" Inherits="staffingProblemProject.Member.UpdateProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<asp:Panel ID="panelRegister" runat="server">

  <div class="container">

        <div class="section-title">
         <h2>MY PROFILE</h2>
        </div>

        <div class="row">


      
     
            <table style="width:100%;">
                <tr>
                    <td>
                        <table style="width: 650px;">
                            <tr>
                                <td "501px;" align="center" valign="top" width:="">
                                    <fieldset>
                                        <table style="width: 85%;">
                                            <tr>
                                                <td style="text-align: left; width: 127px; font-size: small;">
                                                    <strong>UserId</strong></td>
                                                <td style="text-align: left; width: 151px">
                                                    <asp:TextBox ID="txtUserId" runat="server" Width="200px"></asp:TextBox>
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
                                                    <strong>Oldpassword</strong></td>
                                                <td style="text-align: left; width: 151px">
                                                    <asp:TextBox ID="txtOldpassword" runat="server" TextMode="Password" 
                                                        Width="200px"></asp:TextBox>
                                                </td>
                                                <td style="text-align: left">
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                                        ControlToValidate="txtOldpassword" CssClass="failureNotification" 
                                                        ErrorMessage="Enter Old password" Font-Size="Small" 
                                                        ToolTip="Enter Old password" ValidationGroup="registration">*</asp:RequiredFieldValidator>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td style="text-align: left; width: 127px; font-size: small;">
                                                    <strong>Newpassword</strong></td>
                                                <td style="text-align: left; width: 151px">
                                                    <asp:TextBox ID="txtNewpassword" runat="server" TextMode="Password" 
                                                        Width="200px"></asp:TextBox>
                                                </td>
                                                <td style="text-align: left">
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                                        ControlToValidate="txtNewpassword" CssClass="failureNotification" 
                                                        ErrorMessage="Enter Newpassword" Font-Size="Small" ToolTip="Enter Newpassword" 
                                                        ValidationGroup="registration">*</asp:RequiredFieldValidator>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td style="text-align: left; width: 127px; font-size: small;">
                                                    <strong>Confirm </strong>
                                                </td>
                                                <td style="text-align: left; width: 151px">
                                                    <asp:TextBox ID="txtConfirmpassword" runat="server" TextMode="Password" 
                                                        Width="200px"></asp:TextBox>
                                                </td>
                                                <td style="text-align: left">
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" 
                                                        ControlToValidate="txtConfirmpassword" CssClass="failureNotification" 
                                                        ErrorMessage="Enter Confirmpassword" Font-Size="Small" 
                                                        ToolTip="Enter Confirmpassword" ValidationGroup="registration">*</asp:RequiredFieldValidator>
                                                    &nbsp;<asp:CompareValidator ID="CompareValidator1" runat="server" 
                                                        ControlToCompare="txtNewpassword" ControlToValidate="txtConfirmpassword" 
                                                        CssClass="failureNotification" ErrorMessage="Confirm password incorrect" 
                                                        Font-Size="Small" ToolTip="Confirm password incorrect" 
                                                        ValidationGroup="registration">*</asp:CompareValidator>
                                                </td>
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
                                                    <strong>Name</strong></td>
                                                <td style="text-align: left; width: 151px">
                                                    <asp:TextBox ID="txtName" runat="server" Width="200px"></asp:TextBox>
                                                </td>
                                                <td style="text-align: left">
                                                    &nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td style="text-align: left; width: 127px; font-size: small;">
                                                    <strong>Company Name</strong></td>
                                                <td style="text-align: left; width: 151px">
                                                    <asp:TextBox ID="txtCName" runat="server" Width="200px"></asp:TextBox>
                                                </td>
                                                <td style="text-align: left">
                                                    &nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td style="text-align: left; width: 127px; font-size: small;">
                                                    <b>Address</b></td>
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
                                                    <b>Phone Number</b></td>
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
                                                    <b>Email ID</b></td>
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
                                                <td style="width: 127px">
                                                    &nbsp;</td>
                                                <td align="left">
                                                    &nbsp;</td>
                                                <td>
                                                    &nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td style="width: 127px">
                                                    &nbsp;</td>
                                                <td align="left">
                                                    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                                                        Text="Update My Profile" ValidationGroup="registration" />
                                                </td>
                                                <td>
                                                    &nbsp;</td>
                                            </tr>
                                        </table>
                                    </fieldset>
                                    <br />
                                    <br />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td>
                                    &nbsp;</td>
                            </tr>
                        </table>
                    </td>
                    <td>
                       
                        &nbsp;<tr>
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
                </tr>
                        <caption>
                            <br />
                        </caption>
                       
                 </table>        
        
         
        </div>

                       
                       
                       
                       
                       
                       
                       
                       
         </div>

       
    <br />
         <br />

   </asp:Panel>
</asp:Content>
