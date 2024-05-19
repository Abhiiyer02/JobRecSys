<%@ Page Title="" Language="C#" MasterPageFile="~/Candidate/CandidateMP.Master" AutoEventWireup="true" CodeBehind="_JobPrediction.aspx.cs" Inherits="staffingProblemProject.Candidate._JobPrediction" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 32px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<asp:Panel ID="panelAdminPassword" runat="server">

  <div class="container">

        <div class="section-title">
           <h2><span> JOB </span> DOMAIN PREDICTION </h2>
        </div>

        <div class="row">


                
              <a href="#">
                <h4 class="sec-head">Applicant's Parameters</h4>
                  <table style="width: 95%;">
                      <tr>
                          <td>
                              <p> SSLC</p>
                          </td>
                          <td>
                              <asp:DropDownList ID="DropDownListSSLC" runat="server">
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
                              <a href="#">
                              </a>DBMS</td>
                          <td>
                              <a href="#">
                              <asp:DropDownList ID="DropDownListDBMS" runat="server">
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
                                  Pre-University</p>
                          </td>
                          <td>
                              <asp:DropDownList ID="DropDownListPUC" runat="server">
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
                              <a href="#">
                              </a>DSA</td>
                          <td>
                              <a href="#">
                              <asp:DropDownList ID="DropDownListDS" runat="server">
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
                                  Communication</p>
                          </td>
                          <td>
                              <asp:DropDownList ID="DropDownListCS" runat="server">
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
                          <td>Operating Systems</td>
                          <td>
                              <a href="#">
                              <asp:DropDownList ID="DropDownListOS" runat="server">
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
                             
                                  Problem Solving
                          </td>
                          <td>
                              <asp:DropDownList ID="DropDownListPSolving" runat="server">
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
                          <td>Cloud Computing</td>
                          <td>
                              
                              <asp:DropDownList ID="DropDownListCloud" runat="server">
                                  <asp:ListItem Value="1">Beginner </asp:ListItem>
                                  <asp:ListItem Value="2">Intermediate</asp:ListItem>
                                  <asp:ListItem Value="3">Advanced</asp:ListItem>
                                   <asp:ListItem Value="4">Expert</asp:ListItem>
                              </asp:DropDownList>
                          </td>
                      </tr>
                      <tr>
                          <td>
                              <p>
                                  Networks</p>
                          </td>
                          <td>
                              <asp:DropDownList ID="DropDownListNetworks" runat="server">
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
                                  <asp:ListItem Value="1">Beginner </asp:ListItem>
                                  <asp:ListItem Value="2">Intermediate</asp:ListItem>
                                  <asp:ListItem Value="3">Advanced</asp:ListItem>
                                  <asp:ListItem Value="4">Expert</asp:ListItem>
                              </asp:DropDownList>
                              </a></td>
                      </tr>
                      <tr>
                          <td>
                              System Design</td>
                          <td>
                              <a href="#">
                              <asp:DropDownList ID="DropDownListSD" runat="server">
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
                                  <asp:ListItem Value="1">Beginner </asp:ListItem>
                                  <asp:ListItem Value="2">Intermediate</asp:ListItem>
                                  <asp:ListItem Value="3">Advanced</asp:ListItem>
                                  <asp:ListItem Value="4">Expert</asp:ListItem>
                              </asp:DropDownList>
                              </a></td>
                      </tr>
                      <tr>
                          <td>
                              Version Control Systems</td>
                          <td>
                              <a href="#">
                              <asp:DropDownList ID="DropDownListVCS" runat="server">
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
                              JavaScript/TypeScript</td>
                          <td>
                              <a href="#">
                              <asp:DropDownList ID="DropDownListJS" runat="server">
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
                                  <asp:ListItem Value="1">Beginner </asp:ListItem>
                                  <asp:ListItem Value="2">Intermediate</asp:ListItem>
                                  <asp:ListItem Value="3">Advanced</asp:ListItem>
                                  <asp:ListItem Value="4">Expert</asp:ListItem>
                              </asp:DropDownList>
                              </a>
                          </td>
                      </tr>
                      <tr>
                          <td class="auto-style1">
                              Java</td>
                          <td class="auto-style1">
                              <a href="#">
                              <asp:DropDownList ID="DropDownListJava" runat="server">
                                  <asp:ListItem Value="1">Beginner </asp:ListItem>
                                  <asp:ListItem Value="2">Intermediate</asp:ListItem>
                                  <asp:ListItem Value="3">Advanced</asp:ListItem>
                                  <asp:ListItem Value="4">Expert</asp:ListItem>
                              </asp:DropDownList>
                              </a>
                          </td>
                          <td class="auto-style1">
                              </td>
                          <td class="auto-style1">
                              </td>
                          <td class="auto-style1">
                              </td>
                          <td class="auto-style1">
                              </td>
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
                              onclick="btnSubmit_Click" Text="Predict My Job Domain" ValidationGroup="a" />
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

                 <div>
                
                    <br />
                     <br />
                     <br />
                     <br />
                     <br />
                     <br />
                     <br />
                     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="ResultAnnouncement" runat="server"><h5 class="sec-head" style="display:inline">Your Predicted Domain is ... </h5></asp:Label>
                     &nbsp;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="lblResult" runat="server" Font-Names="poppins" Font-Italic="True" Font-Size="X-Large"></asp:Label>
               
                </div>
        </div>
      <br />
      <br />
          <div>
              <div class="row">
                  <asp:Label runat="server" ID="jobstxt"><h3 class="sec-head">Here are a few jobs related to your predicted domain...</h3></asp:Label>
              </div>
              <br />
              <table align="center" style="width: 93%;">
                <tr>
                    <td>
                     <div id="popup">
                 <div style="height:400px; width:auto; overflow:auto">
                        <asp:Table ID="Table4" runat="server" Font-Size="Small" Font-Names="poppins" HorizontalAlign="Center" Width="100%">
                        </asp:Table>
                        </div>
                        </div>
                    </td>
                </tr>
            </table>
          </div>
       </div>

       <br />

      

    </asp:Panel>
</asp:Content>
