<%@ Page Title="" Language="C#" MasterPageFile="~/Guest/GuestMasterpage.Master" AutoEventWireup="true" CodeBehind="DatasetAddition.aspx.cs" Inherits="staffingProblemProject.Candidate.DatasetAddition" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 95%;
        }
        .auto-style7 {
            width: 51%;
            height: 32px;
        }
        .auto-style8 {
            height: 32px;
        }
        .auto-style9 {
            width: 51%
        }
        .auto-style10 {
            height: 32px;
            width: 75%;
        }
        .auto-style11 {
            height: 32px;
            width: 105%;
        }
        .auto-style12 {
            width: 105%
        }
        .auto-style13 {
            height: 32px;
            width: 89%;
        }
        .auto-style14 {
            width: 89%;
        }
        .auto-style15 {
            width: 171px;
        }
        .auto-style16 {
            width: 220px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">


                
              <a href="#">
                <h4 class="sec-head">Select your proficiency levels in the following areas/domains</h4>
                      <table style="width: 95%;border-spacing:1rem">
        <tr>
            <td class="auto-style9">
                <p> SSLC</p>
            </td>
            <td class="w-75">
                <asp:DropDownList ID="DropDownListSSLC" runat="server" Width="117px"> 
                    <asp:ListItem Value="-1">Select</asp:ListItem>
                    <asp:ListItem Value="1">40% - 60%</asp:ListItem>
                    <asp:ListItem Value="2">60% - 75%</asp:ListItem>
                    <asp:ListItem Value="3">75% - 90%</asp:ListItem>
                     <asp:ListItem Value="4">> 90%</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                &nbsp;</td>
            <td class="auto-style14">
                &nbsp;</td>
            <td class="auto-style12">
                <a href="#">
                </a>DBMS</td>
            <td>
                <a href="#">
                <asp:DropDownList ID="DropDownListDBMS" runat="server">
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
            <td class="auto-style7">
                <p>
                    Pre-University</p>
            </td>
            <td class="auto-style10">
                <asp:DropDownList ID="DropDownListPUC" runat="server" Width="117px">
                    <asp:ListItem Value="-1">Select</asp:ListItem>
                    <asp:ListItem Value="1">40% - 60%</asp:ListItem>
                    <asp:ListItem Value="2">60% - 75%</asp:ListItem>
                    <asp:ListItem Value="3">75% - 90%</asp:ListItem>
                     <asp:ListItem Value="4">> 90%</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="auto-style8">
                </td>
            <td class="auto-style13">
                </td>
            <td class="auto-style11">
                <a href="#">
                </a>DSA</td>
            <td class="auto-style8">
                <a href="#">
                <asp:DropDownList ID="DropDownListDS" runat="server">
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
            <td class="auto-style9">
                <p>
                    Communication</p>
            </td>
            <td class="w-75">
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
            <td class="auto-style14">
                &nbsp;</td>
            <td class="auto-style12"><p class="auto-style15">Operating Systems</p></td>
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
            <td class="auto-style9">
                <p>
                Problem Solving</p>
            </td>
            <td class="w-75">
                <asp:DropDownList ID="DropDownListPSolving" runat="server">
                    <asp:ListItem Value="-1">Select</asp:ListItem>
                   <asp:ListItem Value="1">Beginner </asp:ListItem>
                    <asp:ListItem Value="2">Intermediate</asp:ListItem>
                    <asp:ListItem Value="3">Advanced</asp:ListItem>
                     <asp:ListItem Value="4">Expert</asp:ListItem>
       </asp:DropDownList>
            </td>
            <td>
                &nbsp;</td>
            <td class="auto-style14">
                &nbsp;</td>
            <td class="auto-style12">Cloud Computing</td>
            <td>
                
                <asp:DropDownList ID="DropDownListCloud" runat="server">
                    <asp:ListItem Value="-1">Select</asp:ListItem>
                    <asp:ListItem Value="1">Beginner </asp:ListItem>
                    <asp:ListItem Value="2">Intermediate</asp:ListItem>
                    <asp:ListItem Value="3">Advanced</asp:ListItem>
                     <asp:ListItem Value="4">Expert</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style9">
                <p>
                    Networks</p>
            </td>
            <td class="w-75">
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
            <td class="auto-style14">
                &nbsp;</td>
            <td class="auto-style12">
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
            <td class="auto-style9">
                <p>
                System Design</p></td>
            <td class="w-75">
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
            <td class="auto-style14">
                &nbsp;</td>
            <td class="auto-style12">
                <p>Mathematics</p>
                </td>
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
            <td class="auto-style9">
                <p class="auto-style16">Version Control Systems</p>
                </td>
            <td class="w-75">
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
            <td class="auto-style14">
                &nbsp;</td>
            <td class="auto-style12">
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
            <td class="auto-style9">
                <p>JavaScript/TypeScript</p>
                </td>
            <td class="w-75">
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
            <td class="auto-style14">
                &nbsp;</td>
            <td class="auto-style12">
                <p>C/C++/C#</p>
                </td>
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
            <td class="auto-style9">
                <p>Java</p>
                </td>
            <td class="w-75">
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
            <td class="auto-style1">
                </td>
            <td class="auto-style14">
                </td>
            <td class="auto-style12">
                </td>
            <td class="auto-style1">
                </td>
        </tr>
        <tr>
            <td class="auto-style9">
                &nbsp;</td>
            <td class="w-75">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="auto-style14">
                &nbsp;</td>
            <td class="auto-style12">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    <tr>
        <td class="auto-style9">
            &nbsp;</td>
        <td class="w-75">
            <asp:Button ID="btnSubmit" runat="server" Height="50px" 
                onclick="btnSubmit_Click" Text="Submit" ValidationGroup="a" Width="140px" />
        </td>
        <td>
            &nbsp;</td>
        <td class="auto-style14">
            &nbsp;</td>
        <td class="auto-style12">
            &nbsp;</td>
        <td>
            &nbsp;</td>
</tr>
    </table>
              </a>
           
        </div>
        </div>
      <br />
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
 <asp:Label ID="Label1"  runat="server" Text="Please Select proficiency level for All parameters!" ForeColor="Red"></asp:Label>
</asp:Content>
