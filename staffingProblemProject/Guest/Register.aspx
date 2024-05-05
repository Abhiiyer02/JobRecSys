<%@ Page Title="" Language="C#" MasterPageFile="~/Guest/GuestMasterpage.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="staffingProblemProject.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<%--<link href="../ThemeBlue.css" rel="Stylesheet" type="text/css" />--%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

 <asp:Panel ID="panelRegister" runat="server">

  <div class="container">

        <div class="section-title">
         <h2><span>REGISTER </span> FORM FOR NEW COMPANY!</h2>
        </div>

        <div class="row">


      
     
            <br />
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
                                                    <b>Member Id</b></td>
                                                <td style="text-align: left; width: 151px">
                                                    <asp:TextBox ID="txtMemberId" runat="server" Font-Size="Small" Width="200px"></asp:TextBox>
                                                </td>
                                                <td style="text-align: left">
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                                                        ControlToValidate="txtMemberId" CssClass="failureNotification" 
                                                        ErrorMessage="Enter MemberId" Font-Size="Small" ToolTip="Enter MemberId" 
                                                        ValidationGroup="registration">*</asp:RequiredFieldValidator>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td style="text-align: left; width: 127px; font-size: small;">
                                                    <b>Password</b></td>
                                                <td style="text-align: left; width: 151px">
                                                    <asp:TextBox ID="txtPassword" runat="server" Font-Size="Small" MaxLength="10" 
                                                        TextMode="Password" Width="200px"></asp:TextBox>
                                                </td>
                                                <td style="text-align: left">
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                                        ControlToValidate="txtPassword" CssClass="failureNotification" 
                                                        ErrorMessage="Enter Password" Font-Size="Small" ToolTip="Enter Password" 
                                                        ValidationGroup="registration">*</asp:RequiredFieldValidator>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td style="text-align: left; width: 127px; font-size: small;">
                                                    <b>Confirm</b></td>
                                                <td style="text-align: left; width: 151px">
                                                    <asp:TextBox ID="txtConfirm" runat="server" Font-Size="Small" 
                                                        TextMode="Password" Width="200px"></asp:TextBox>
                                                </td>
                                                <td style="text-align: left">
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                                        ControlToValidate="txtConfirm" CssClass="failureNotification" 
                                                        ErrorMessage="Enter Password again" Font-Size="Small" ToolTip="field required" 
                                                        ValidationGroup="registration">*</asp:RequiredFieldValidator>
                                                    <asp:CompareValidator ID="CompareValidator1" runat="server" 
                                                        ControlToCompare="txtPassword" ControlToValidate="txtConfirm" 
                                                        CssClass="failureNotification" ErrorMessage="Password Mismatch" 
                                                        Font-Size="Small" ToolTip="mismatch" ValidationGroup="registration">*</asp:CompareValidator>
                                                </td>
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
                                                    <strong>CompanyName</strong></td>
                                                <td style="text-align: left; width: 151px">
                                                    <asp:TextBox ID="txtCompanyName" runat="server" Width="200px"></asp:TextBox>
                                                </td>
                                                <td style="text-align: left">
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" 
                                                        ControlToValidate="txtCompanyName" CssClass="failureNotification" 
                                                        ErrorMessage="Enter Company Name" ToolTip="Enter Company Name" 
                                                        ValidationGroup="registration">*</asp:RequiredFieldValidator>
                                                </td>
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
                                                <td style="text-align: left; width: 127px; font-size: small;">
                                                    <strong>Company Logo</strong></td>
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
                                                    <strong>Receipt Number</strong></td>
                                                <td style="text-align: left; width: 151px">
                                                    <asp:TextBox ID="txtReceipt" runat="server" Width="200px"></asp:TextBox>
                                                </td>
                                                <td style="text-align: left">
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" 
                                                        ControlToValidate="txtReceipt" CssClass="failureNotification" 
                                                        ErrorMessage="Enter Receipt Number" ToolTip="Enter Receipt Number" 
                                                        ValidationGroup="registration">*</asp:RequiredFieldValidator>
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
                       
                       
                       
                       
                       
                        <%--<asp:Image ID="Image1" runat="server" 
                            ImageUrl="~/assets/img/portfolio/portfolio-4.jpg" Height="200px" />
                            <br />
                             <br />
                          <asp:Image ID="Image2" runat="server" 
                            ImageUrl="~/assets/img/portfolio/portfolio-5.jpg" Height="200px" />
                            <br />
                             <br />
                            <asp:Image ID="Image3" runat="server" 
                            ImageUrl="~/assets/img/portfolio/portfolio-6.jpg" Height="200px"/>
                       --%>
                       
                       
                       
                       
                       
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
