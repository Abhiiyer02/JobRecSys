<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterpage.Master" AutoEventWireup="true" CodeBehind="ExistingUsers.aspx.cs" Inherits="staffingProblemProject.Admin.ExistingUsers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<asp:Panel ID="panelExistingUsers" runat="server">

 <div class="container">

        <div class="section-title">
           <h2><span>EXISTING MEMBERS (RECUITERS)</span> OF THE SYSTEM !</h2>
        </div>

        <div class="row">
          
                         <br />
                    <table align="center" style="width: 93%;">
                        <tr>
                            <td>
                             <div id="popup">
                         <div style="height:400px; width:auto; overflow:auto">
                                <asp:Table ID="Table4" runat="server" Font-Size="Small">
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
       <marquee scrolldelay="50" behavior="alternate">
       <asp:Image ID="Image1" runat="server" 
                              ImageUrl="~/images/job3.png" Height="200px" />
                          &nbsp
                          <asp:Image ID="Image2" runat="server" 
                             ImageUrl="~/images/job2.jpg" Height="200px" />
                            <asp:Image ID="Image3" runat="server" 
                            ImageUrl="~/images/job4.jpg" Height="200px" />
                   </marquee>     
                         
      <br />
      <br />
                   
       

    </asp:Panel>

</asp:Content>
