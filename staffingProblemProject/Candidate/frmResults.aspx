<%@ Page Title="" Language="C#" MasterPageFile="~/Candidate/CandidateMP.Master" AutoEventWireup="true" CodeBehind="frmResults.aspx.cs" Inherits="staffingProblemProject.frmResults" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<asp:Panel ID="Panel1" runat="server">
    <!-- Start contact Area -->  
<div class="container">

        <div class="section-title">
           <h2><span>ML MODEL </span> RESULTS !</h2>
        </div>

        <div class="row">

        <div class="span12">
					<div class="cform" id="contact-form">
      
      <br />
                        <asp:Panel ID="Panel2" runat="server" HorizontalAlign="Center">
                         <asp:Label ID="lblCourse" runat="server"></asp:Label>
                        </asp:Panel>
                        <br />
                       
      <asp:Table ID="Table1" runat="server" HorizontalAlign="Center">
      </asp:Table>
     
      <br />
        
     
  </div>
</div>
</div>
</div>

    </asp:Panel>
</asp:Content>
