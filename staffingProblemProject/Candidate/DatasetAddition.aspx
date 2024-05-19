<%@ Page Title="" Language="C#" MasterPageFile="~/Guest/GuestMasterpage.Master" AutoEventWireup="true" CodeBehind="DatasetAddition.aspx.cs" Inherits="staffingProblemProject.Candidate.DatasetAddition" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 95%;
        }
        .auto-style2 {
            height: 10px;
        }
        .auto-style4 {
            height: 23px;
        }
        .auto-style5 {
            height: 5px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
        <div class="row">


                
              <a href="#">
                <h4 class="sec-head">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Select your proficiency levels for the following skills</h4>
              <p class="sec-head">
                  <table class="auto-style1">
                      <tr>
                          <td class="auto-style4">
                              <p>
                                  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                  SSLC</p>
                          </td>
                          <td class="auto-style4">
                              <asp:DropDownList ID="DropDownListSSLC" runat="server">
                                  <asp:ListItem Value="-1">Select</asp:ListItem>
                                  <asp:ListItem Value="1">Beginner </asp:ListItem>
                                  <asp:ListItem Value="2">Intermediate</asp:ListItem>
                                  <asp:ListItem Value="3">Advanced</asp:ListItem>
                                   <asp:ListItem Value="4">Expert</asp:ListItem>
                              </asp:DropDownList>
                          </td>
                          <td class="auto-style4">
                              </td>
                          <td class="auto-style4">
                              </td>
                          <td class="auto-style4">
                              <a href="#">
                              </a>DBMS</td>
                          <td class="auto-style4">
                              <a href="#">
                              <asp:DropDownList ID="DropDownListDBMS" runat="server">
                                    <asp:ListItem Value="-1">Select</asp:ListItem  > 
                                    <asp:ListItem Value="1">Beginner </asp:ListItem>
                                    <asp:ListItem Value="2">Intermediate</asp:ListItem>
                                    <asp:ListItem Value="3">Advanced</asp:ListItem>
                                    <asp:ListItem Value="4">Expert</asp:ListItem>  
                              </asp:DropDownList>
                              </a>
                          </td>
                      </tr>
                      <tr>
                          <td class="auto-style2">
                              <p>
                                  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                  Pre-University</p>
                          </td>
                          <td class="auto-style2">
                              <asp:DropDownList ID="DropDownListPUC" runat="server">
                                    <asp:ListItem Value="-1">Select</asp:ListItem>
                                    <asp:ListItem Value="1">Beginner </asp:ListItem>
                                    <asp:ListItem Value="2">Intermediate</asp:ListItem>
                                    <asp:ListItem Value="3">Advanced</asp:ListItem>
                                     <asp:ListItem Value="4">Expert</asp:ListItem>
                              </asp:DropDownList>
                          </td>
                          <td class="auto-style2">
                              </td>
                          <td class="auto-style2">
                              </td>
                          <td class="auto-style2">
                              <a href="#">
                              </a>DSA </td>
                          <td class="auto-style2">
                              <a href="#">
                              <asp:DropDownList ID="DropDownListDS" runat="server" >
                                    <asp:ListItem Value="-1">Select</asp:ListItem>
                                    <asp:ListItem Value="1">Beginner </asp:ListItem>
                                    <asp:ListItem Value="2">Intermediate</asp:ListItem>
                                    <asp:ListItem Value="3">Advanced</asp:ListItem>
                                    <asp:ListItem Value="4">Expert</asp:ListItem>
                              </asp:DropDownList>
                              </a>
                          </td>
                      </tr>
                      <tr>
                          <td>
                              <p>
                                  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                  Communication</p>
                          </td>
                          <td>
                              <asp:DropDownList ID="DropDownListCS" runat="server">
                               <asp:ListItem Value="-1">Select</asp:ListItem>
                                <asp:ListItem Value="1">Beginner </asp:ListItem>
                                <asp:ListItem Value="2">Intermediate</asp:ListItem>
                                <asp:ListItem Value="3">Advanced</asp:ListItem>
                                 <asp:ListItem Value="4">Expert</asp:ListItem>    
                               </asp:DropDownList>
                          </td>
                          <td>
                              &nbsp;</td>
                          <td>
                              &nbsp;</td>
                          <td>
                             
                                  Operating Systems
                              </a></td>
                          <td>
                              <a href="#">
                              <asp:DropDownList ID="DropDownListOS" runat="server">
                                <asp:ListItem Value="-1">Select</asp:ListItem>
                                <asp:ListItem Value="1">Beginner </asp:ListItem>
                                <asp:ListItem Value="2">Intermediate</asp:ListItem>
                                <asp:ListItem Value="3">Advanced</asp:ListItem>
                                    <asp:ListItem Value="4">Expert</asp:ListItem>
                              </asp:DropDownList>
                              </a>
                          </td>
                      </tr>
                      <tr>
                          <td class="auto-style5">
                             
                                  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                             
                                  Problem Solving
                          </td>
                          <td class="auto-style5">
                                <asp:DropDownList ID="DropDownListPSolving" runat="server">
                                    <asp:ListItem Value="-1">Select</asp:ListItem>
                                    <asp:ListItem Value="1">Beginner </asp:ListItem>
                                    <asp:ListItem Value="2">Intermediate</asp:ListItem>
                                    <asp:ListItem Value="3">Advanced</asp:ListItem>
                                     <asp:ListItem Value="4">Expert</asp:ListItem> 
                                </asp:DropDownList>
                          </td>
                          <td class="auto-style5">
                              </td>
                          <td class="auto-style5">
                              </td>
                          <td class="auto-style5">
                            
                             
                                  Cloud Computing 
                              </a></td>
                          <td class="auto-style5">
                              
                              <asp:DropDownList ID="DropDownListCloud" runat="server">
                                <asp:ListItem Value="-1">Select</asp:ListItem>
                                <asp:ListItem Value="1">Beginner </asp:ListItem>
                                <asp:ListItem Value="2">Intermediate</asp:ListItem>
                                <asp:ListItem Value="3">Advanced</asp:ListItem>
                                <asp:ListItem Value="4">Expert</asp:ListItem> 

                              </asp:DropDownList>
                              </a>
                          </td>
                      </tr>
                      <tr>
                          <td>
                              <p>
                                  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                  Networks</p>
                          </td>
                          <td>
                              <asp:DropDownList ID="DropDownListNetworks" runat="server">
                                <asp:ListItem Value="-1">Select</asp:ListItem>
                                <asp:ListItem Value="1">Beginner </asp:ListItem>
                                <asp:ListItem Value="2">Intermediate</asp:ListItem>
                                <asp:ListItem Value="3">Advanced</asp:ListItem>
                                <asp:ListItem Value="4">Expert</asp:ListItem> 

                     </asp:DropDownList>
                          </td>
                          <td>
                              &nbsp;</td>
                          <td>
                              &nbsp;</td>
                          <td>
                              Containers</td>
                          <td>
                              <a href="#">
                              <asp:DropDownList ID="DropDownListContainers" runat="server">
                                    <asp:ListItem Value="-1">Select</asp:ListItem>
                                    <asp:ListItem Value="1">Beginner </asp:ListItem>
                                    <asp:ListItem Value="2">Intermediate</asp:ListItem>
                                    <asp:ListItem Value="3">Advanced</asp:ListItem>
                                    <asp:ListItem Value="4">Expert</asp:ListItem> 

                              </asp:DropDownList>
                              </a></td>
                      </tr>
                      <tr>
                          <td>
                              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                              System Design</td>
                          <td>
                              <a href="#">
                              <asp:DropDownList ID="DropDownListSD" runat="server">
                                  <asp:ListItem Value="-1">Select</asp:ListItem>
                                  <asp:ListItem Value="1">Beginner </asp:ListItem>
                                  <asp:ListItem Value="2">Intermediate</asp:ListItem>
                                  <asp:ListItem Value="3">Advanced</asp:ListItem>
                                  <asp:ListItem Value="4">Expert</asp:ListItem>
                              </asp:DropDownList>
                              </a></td>
                          <td>
                              &nbsp;</td>
                          <td>
                              &nbsp;</td>
                          <td>
                              Mathematics</td>
                          <td>
                              <a href="#">
                              <asp:DropDownList ID="DropDownListM" runat="server">
                                  <asp:ListItem Value="-1">Select</asp:ListItem>
                                  <asp:ListItem Value="1">Beginner </asp:ListItem>
                                  <asp:ListItem Value="2">Intermediate</asp:ListItem>
                                  <asp:ListItem Value="3">Advanced</asp:ListItem>
                                  <asp:ListItem Value="4">Expert</asp:ListItem>
                              </asp:DropDownList>
                              </a></td>
                      </tr>
                      <tr>
                          <td>
                              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                              Version Control Systems</td>
                          <td>
                              <a href="#">
                              <asp:DropDownList ID="DropDownListVCS" runat="server">
                                  <asp:ListItem Value="-1">Select</asp:ListItem>
                                  <asp:ListItem Value="1">Beginner </asp:ListItem>
                                  <asp:ListItem Value="2">Intermediate</asp:ListItem>
                                  <asp:ListItem Value="3">Advanced</asp:ListItem>
                                  <asp:ListItem Value="4">Expert</asp:ListItem>
                              </asp:DropDownList>
                              </a>
                          </td>
                          <td>
                              &nbsp;</td>
                          <td>
                              &nbsp;</td>
                          <td>
                              Python</td>
                          <td>
                              <a href="#">
                              <asp:DropDownList ID="DropDownListPython" runat="server">
                                  <asp:ListItem Value="-1">Select</asp:ListItem>
                                  <asp:ListItem Value="1">Beginner </asp:ListItem>
                                  <asp:ListItem Value="2">Intermediate</asp:ListItem>
                                  <asp:ListItem Value="3">Advanced</asp:ListItem>
                                  <asp:ListItem Value="4">Expert</asp:ListItem>
                              </asp:DropDownList>
                              </a>
                          </td>
                      </tr>
                      <tr>
                          <td>
                              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                              JavaScript/TypeScript</td>
                          <td>
                              <a href="#">
                              <asp:DropDownList ID="DropDownListJS" runat="server">
                                  <asp:ListItem Value="-1">Select</asp:ListItem>
                                  <asp:ListItem Value="1">Beginner </asp:ListItem>
                                  <asp:ListItem Value="2">Intermediate</asp:ListItem>
                                  <asp:ListItem Value="3">Advanced</asp:ListItem>
                                  <asp:ListItem Value="4">Expert</asp:ListItem>
                              </asp:DropDownList>
                              </a>
                          </td>
                          <td>
                              &nbsp;</td>
                          <td>
                              &nbsp;</td>
                          <td>
                              C/C++/C#</td>
                          <td>
                              <a href="#">
                              <asp:DropDownList ID="DropDownListCCCP" runat="server">
                                  <asp:ListItem Value="-1">Select</asp:ListItem>
                                  <asp:ListItem Value="1">Beginner </asp:ListItem>
                                  <asp:ListItem Value="2">Intermediate</asp:ListItem>
                                  <asp:ListItem Value="3">Advanced</asp:ListItem>
                                  <asp:ListItem Value="4">Expert</asp:ListItem>
                              </asp:DropDownList>
                              </a>
                          </td>
                      </tr>
                      <tr>
                          <td>
                              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                              Java</td>
                          <td>
                              <a href="#">
                              <asp:DropDownList ID="DropDownListJava" runat="server">
                                  <asp:ListItem Value="-1">Select</asp:ListItem>
                                  <asp:ListItem Value="1">Beginner </asp:ListItem>
                                  <asp:ListItem Value="2">Intermediate</asp:ListItem>
                                  <asp:ListItem Value="3">Advanced</asp:ListItem>
                                  <asp:ListItem Value="4">Expert</asp:ListItem>
                              </asp:DropDownList>
                              </a>
                          </td>
                          <td>
                              &nbsp;</td>
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
                          <asp:Button ID="btnSubmit" runat="server" Height="50px" 
                              onclick="btnSubmit_Click" Text="Submit" ValidationGroup="a" />
                      </td>
                      
                      <td>
                          &nbsp;</td>
                      <td>
                          &nbsp;</td>
                      <td>
                          &nbsp;</td>
                      <td>
                          &nbsp;</td>
              </tr>
                  </table>
              
              </p>
              </a>
           
        </div>
      <br />
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
 <asp:Label ID="Label1"  runat="server" Text="Please Select proficiency level for All parameters!" ForeColor="Red"></asp:Label>
</asp:Content>
