<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterpage.Master" AutoEventWireup="true" CodeBehind="AdminHomepage.aspx.cs" Inherits="staffingProblemProject.Admin.AdminHomepage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<asp:Panel ID="panelAdminHome" runat="server">

 <div class="container">

        <div class="section-title">
                <h2><span>WELCOME TO ADMIN</span> HOME PAGE !</h2>
        </div>

        <div class="row">

    


       <table style="width: 98%;">
           <tr>
               <td>
                   <p>Admin related Modules;
	
</p>

                   <p>Login Module</p>
                   <p>Member Verification</p>

                   <p>View Registered Users(Decision Maker)</p>
                   <p>Discussion Forum Module</p>
                   <p>Change Password Module</p>

               </td>
           </tr>
       </table>

       </div>
       </div>
       <br />
         <br />
           <marquee scrolldelay="50" behavior="alternate">
                        <asp:Image ID="Image1" runat="server" 
                             ImageUrl="~/images/job4.jpg" Height="200px" />
                           &nbsp
                          <asp:Image ID="Image2" runat="server" 
                             ImageUrl="~/images/job5.jpg" Height="200px" />
                          &nbsp
                            <asp:Image ID="Image3" runat="server" 
                             ImageUrl="~/images/job6.jpg" Height="200px" />
                       
                        </marquee>

                         <br />
       <br />
    </asp:Panel>


</asp:Content>
