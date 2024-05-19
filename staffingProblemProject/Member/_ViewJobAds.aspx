<%@ Page Title="" Language="C#" MasterPageFile="~/Member/MemberMasterpage.Master" AutoEventWireup="true" CodeBehind="_ViewJobAds.aspx.cs" Inherits="staffingProblemProject.Member._ViewJobAds" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="panelExistingUsers" runat="server">

 <div class="container">

        <div class="section-title">
           <h2><span>MANAGE JOBS</span> </h2>
        </div>

        <div class="row">
          
                         <br />
                    <table align="center" style="width: 93%;">
                        <tr>
                            <td>
                             <div id="popup">
                         <div style="height:400px; width:auto; overflow:auto">
                                <asp:Table ID="Table4" runat="server" Font-Size="Small" Font-Names="poppins" HorizontalAlign="Center">
                                </asp:Table>
                                </div>
                                </div>
                            </td>
                        </tr>
                    </table>
                   
       
       </div>
       </div>
       <br />
        <br />
       <%--<marquee scrolldelay="50" behavior="alternate">
       <asp:Image ID="Image1" runat="server" 
                            ImageUrl="~/assets/img/portfolio/portfolio-1.jpg" Height="200px" />
                          &nbsp
                          <asp:Image ID="Image2" runat="server" 
                            ImageUrl="~/assets/img/portfolio/portfolio-2.jpg" Height="200px" />
                           &nbsp
                            <asp:Image ID="Image3" runat="server" 
                            ImageUrl="~/assets/img/portfolio/portfolio-3.jpg" Height="200px"/>
                   </marquee>     --%>
                         
      <br />
      <br />
                   
       

    </asp:Panel>

</asp:Content>
