<%@ Page Title="" Language="C#" MasterPageFile="~/Member/MemberMasterpage.Master" AutoEventWireup="true" CodeBehind="MemberHomepage.aspx.cs" Inherits="staffingProblemProject.Member.MemberHomepage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<asp:Panel ID="Panel1" runat="server">


 <div class="container">

        <div class="section-title">
             <h2><span>WELCOME</span> TO MEMBER HOME PAGE !</h2>
        </div>

        <div class="row">

   

  

     
 
       </div>
       <br />
       <br />
           <marquee scrolldelay="50" behavior="alternate">
                        <asp:Image ID="Image1" runat="server" 
                             ImageUrl="~/images/job1.jpg" Height="200px" />
                           &nbsp
                          <asp:Image ID="Image2" runat="server" 
                             ImageUrl="~/images/job4.jpg" Height="200px" />
                          &nbsp
                            <asp:Image ID="Image3" runat="server" 
                             ImageUrl="~/images/job5.jpg" Height="200px" />
                       
                        </marquee>

                         <br />
       <br />
    </asp:Panel>

</asp:Content>
