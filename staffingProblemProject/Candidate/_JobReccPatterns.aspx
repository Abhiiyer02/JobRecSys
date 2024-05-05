<%@ Page Title="" Language="C#" MasterPageFile="~/Candidate/CandidateMP.Master" AutoEventWireup="true" CodeBehind="_JobReccPatterns.aspx.cs" Inherits="staffingProblemProject.Candidate._JobReccPatterns" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<asp:Panel ID="Panel1" runat="server">
    <!-- Start contact Area -->  
    <div class="container">

        <div class="section-title">
           <h2><span>JOB RECOMMENDATION </span> PATTERNS !</h2>
        </div>

        <div class="row">

        <!-- single-well start-->
       
        <!-- single-well end-->
       
              <a href="#">
                <h4 class="sec-head">Finding relationship between parameters and Job Domains using Apriori Algorithm</h4>
              </a>
             
                 <table style="width:100%;">
                     <tr>
                         <td>
                             <p>
                                 Enter Support (0.045, 0.05, ..., 0.075)</p>
                         </td>
                         <td>
                             &nbsp;</td>
                         <td>
                             &nbsp;</td>
                     </tr>
                     <tr>
                         <td>
                             <asp:TextBox ID="txtSupport" runat="server" Height="30px" Width="300px"></asp:TextBox>
                         </td>
                         <td>
                             <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                 ControlToValidate="txtSupport" CssClass="error" ErrorMessage="Enter Support" 
                                 ValidationGroup="a"></asp:RequiredFieldValidator>
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
                             <p>
                                 Enter Confidence (0.1, 0.2, 0.3, 0.5, ...)</p>
                         </td>
                         <td>
                             &nbsp;</td>
                         <td>
                             &nbsp;</td>
                     </tr>
                     <tr>
                         <td>
                             <asp:TextBox ID="txtConfidence" runat="server" Height="30px" Width="300px"></asp:TextBox>
                         </td>
                         <td>
                             <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                 ControlToValidate="txtConfidence" CssClass="error" 
                                 ErrorMessage="Enter Confidence" ValidationGroup="a"></asp:RequiredFieldValidator>
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
                             <asp:Button ID="btnPredict" runat="server" Height="50px" 
                                 onclick="btnPredict_Click" 
                                 Text="Generate Job Patterns" ValidationGroup="a" 
                                 Width="750px" />
                         </td>
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
                     <tr>
                         <td>
                             <asp:Label ID="lblTime" runat="server" Font-Bold="True" Font-Size="Medium"></asp:Label>
                         </td>
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
                     <tr>
                         <td>
                             <asp:Table ID="Table4" runat="server">
                             </asp:Table>
                         </td>
                         <td>
                             &nbsp;</td>
                         <td>
                             &nbsp;</td>
                     </tr>
            </table>

          <p>
              &nbsp;</p>
  <br />

          <br />

    <br />
  

               
            
    <asp:Panel ID="Panel2" runat="server" Visible="False" Width="721px">
        <h2>
            <span>PATTERNS DETAILS</span> </h2>
        <table style="width: 75%;">
            <tr>
                <td style="width: 351px" valign="top">
                    <strong>Distinct Items</strong></td>
                <td>
                    <strong>Dataset</strong></td>
            </tr>
            <tr>
                <td style="width: 351px" valign="top">
                    <asp:ListBox ID="lv_Items" runat="server" Height="175px" Width="211px">
                    </asp:ListBox>
                </td>
                <td style="width: 151px">
                    <asp:ListBox ID="lv_Transactions" runat="server" Height="175px" Width="324px">
                    </asp:ListBox>
                </td>
            </tr>
        </table>
        <table style="width: 75%;">
            <tr>
                <td>
                    <strong>Frequent Item Set (L)</strong></td>
                <td>
                    <strong>Final Output [displaying patterns]</strong></td>
            </tr>
            <tr>
                <td>
                    <asp:ListBox ID="ListBox1" runat="server" Height="161px" Width="211px">
                    </asp:ListBox>
                </td>
                <td>
                    <asp:ListBox ID="ListBox2" runat="server" Height="161px" Width="324px">
                    </asp:ListBox>
                </td>
            </tr>
        </table>
        <br />
    </asp:Panel>


        

     

        <!-- End col-->
      </div>
    </div>
   
  <!-- End Contact Area -->


    </asp:Panel>
</asp:Content>
