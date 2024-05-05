<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterpage.Master" AutoEventWireup="true" CodeBehind="NewUsers.aspx.cs" Inherits="staffingProblemProject.Admin.NewUsers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<asp:Panel ID="panelNewUsers" runat="server">

 <div class="container">

        <div class="section-title">
           <h2><span>NEW MEMBERS (RECRUITERS)</span> TO THE SYSTEM</h2>
        </div>

        <div class="row">

    
     

        
            <table align="center" style="width: 86%; text-align: center;">
                <tr>
                    <td align="left">
                        &nbsp;</td>
                    <td style="width: 370px">
                        &nbsp;</td>
                    <td align="right">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td align="left">
                        <asp:Button ID="btn_Approve" runat="server" Font-Size="Small" 
                            onclick="btn_Approve_Click" 
                            onclientclick="return confirm('Are you sure want to Approve?')" Text="Approve" 
                            Width="100px" />
                    </td>
                    <td style="width: 370px">
                        &nbsp;</td>
                    <td align="right">
                        <asp:Button ID="btn_Reject" runat="server" Font-Size="Small" 
                            onclick="btn_Reject_Click" 
                            onclientclick="return confirm('Are you sure want to Reject?')" Text="Reject" 
                            Width="100px" />
                    </td>
                </tr>
            </table>
            <br />
            <table align="center" style="width: 86%;">
                <tr>
                    <td style="text-align: center">
                     <div id="popup">
                         <div style="height:400px; width:auto; overflow:auto">
                        <asp:Table ID="Table1" runat="server" HorizontalAlign="Center">
                        </asp:Table>
                        </div>
                        </div>
                    </td>
                </tr>
            </table>

      <br />

      </div>

       <br />
       <marquee scrolldelay="50" behavior="alternate">
       <asp:Image ID="Image1" runat="server" 
                            ImageUrl="~/assets/img/portfolio/portfolio-1.jpg" Height="200px" />
                          &nbsp
                          <asp:Image ID="Image2" runat="server" 
                            ImageUrl="~/assets/img/portfolio/portfolio-2.jpg" Height="200px" />
                           &nbsp
                            <asp:Image ID="Image3" runat="server" 
                            ImageUrl="~/assets/img/portfolio/portfolio-3.jpg" Height="200px"/>
                   </marquee>     
                         
      <br />
      <br />
      </div>

     

    </asp:Panel>



</asp:Content>
