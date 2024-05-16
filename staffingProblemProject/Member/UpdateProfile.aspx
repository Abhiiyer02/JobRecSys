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
                                                        Text="Update Profile" ValidationGroup="registration" />
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
                        </table>
                    </td>
                    <td>
                       
                        
                       
                 </table> 
        </div>       
        </div>
        <hr />
        <div class="container">

       <div class="section-title">
          <h2><span>CHANGE</span> PASSWORD</h2>
       </div>

       <div class="row">

  


   
    
     <br />
    <table style="width:55%;">
                   <tr>
                       <td>
                           &nbsp;</td>
                       <td>
                         <fieldset>
               <table align="center" style="width: 95%;">
                   <tr>
                       <td class="style1">
                          
                       </td>
                       <td>
                           &nbsp;</td>
                       <td>
                           &nbsp;</td>
                   </tr>
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
                           <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
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
