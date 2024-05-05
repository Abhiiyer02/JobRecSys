<%@ Page Title="" Language="C#" MasterPageFile="~/Candidate/CandidateMP.Master" AutoEventWireup="true" CodeBehind="frmModel.aspx.cs" Inherits="staffingProblemProject.frmModel" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<asp:Panel ID="Panel1" runat="server">
    <!-- Start contact Area -->  
<div class="container">

        <div class="section-title">
           <h2><span>ML MODEL </span> EVALUATION - JOB RECOMMENDATIONS</h2>
        </div>

        <div class="row">
        <br />
            <div style="height:350px; width:auto; overflow:auto">

                         <h3>Testing Dataset</h3>

                             <table style="width: 100%;">
                                 <tr>
                                     <td>
                                         &nbsp;
                                         <asp:GridView ID="GridView1" runat="server" BackColor="White" 
                                             BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4">
                                             <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                                             <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
                                             <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
                                             <RowStyle BackColor="White" ForeColor="#330099" />
                                             <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                                             <SortedAscendingCellStyle BackColor="#FEFCEB" />
                                             <SortedAscendingHeaderStyle BackColor="#AF0101" />
                                             <SortedDescendingCellStyle BackColor="#F6F0C0" />
                                             <SortedDescendingHeaderStyle BackColor="#7E0000" />
                                         </asp:GridView>
                                     </td>
                                     <td>
                                         &nbsp;
                                     </td>
                                     <td>
                                         &nbsp;
                                     </td>
                                 </tr>
                                 <tr>
                                     <td>
                                         &nbsp;
                                     </td>
                                     <td>
                                         &nbsp;
                                     </td>
                                     <td>
                                         &nbsp;
                                     </td>
                                 </tr>
                                 <tr>
                                     <td>
                                         &nbsp;
                                     </td>
                                     <td>
                                         &nbsp;
                                     </td>
                                     <td>
                                         &nbsp;
                                     </td>
                                 </tr>
                             </table>

                             <br />
                        <br />
            </div>
              <br />
              <br />
               <h2><span>JOB </span> PREDICTION USING NAIVE BAYES</h2>
              <hr />
              <br />
              <br />
                      <table style="width: 35%;">
                          <tr>
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
                                  <asp:Button ID="btnPrediction" runat="server" 
                                      class="btn btn-primary btn-block btn-lg" Height="50px" 
                                      onclick="btnPrediction_Click" Text="Predict Output" Width="200px" />
                              </td>
                              <td>
                                  &nbsp;</td>
                              <td>
                                  <asp:Button ID="btnResults" runat="server" 
                                      class="btn btn-primary btn-block btn-lg" Height="50px" 
                                      onclick="btnResults_Click" Text="Result Analysis" Width="200px" 
                                      Visible="False" />
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
                              <td>
                                  &nbsp;</td>
                          </tr>
                      </table>
            
            <br />
     
    </div>
    <asp:Table ID="tablePrediction" runat="server" >
</asp:Table>
     
</div>

    <div class="container">
        <br />
        <br />
    <div class="section-title">
       <h2><span>ML MODEL </span> RESULTS !</h2>
    </div>

    <div class="row">

    <div class="span12">
				<div class="cform" id="contact-form">
  
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
