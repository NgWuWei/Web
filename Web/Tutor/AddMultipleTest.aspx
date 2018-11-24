<%@ Page Title="" Language="C#" MasterPageFile="~/AssessmentMenu.Master" AutoEventWireup="true" CodeBehind="AddMultipleTest.aspx.cs" Inherits="Web.Tutor.AddTestDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style5 {
            height: 23px;
        }
        .auto-style7 {
            height: 23px;
            width: 171px;
        }
        .auto-style8 {
            width: 100%;
            margin-top: 73px;
        }
        .auto-style9 {
            margin-top: 0px;
        }
        .auto-style10 {
            height: 22px;
            width: 171px;
        }
        .auto-style11 {
            height: 22px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" runat="server">
    <br />
    <br />
    
    <table class="auto-style8">
        <tr>
            <td class="auto-style7">Question Entry Options</td>
            <td class="auto-style5">Question Details</td>
        </tr>
        <tr>
            <td class="auto-style10">*QUESTION TYPE<br />
                <asp:DropDownList ID="QuestionTypeList" runat="server">
                    <asp:ListItem>Select Question Type</asp:ListItem>
                    <asp:ListItem>Multiple Question</asp:ListItem>
                    <asp:ListItem>True False</asp:ListItem>
                    <asp:ListItem>Matching</asp:ListItem>
                    <asp:ListItem>Essay</asp:ListItem>
                    <asp:ListItem>Free Text</asp:ListItem>
                </asp:DropDownList>
                <br />
                <br />
                *TOTAL QUESTION<br />
                <asp:Label ID="totalQuestionlabel" runat="server"></asp:Label>
            </td>
            <td class="auto-style11">
                <asp:TextBox ID="QuestionTxt" runat="server" CssClass="auto-style9" Height="126px" Width="535px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style7"></td>
            <td class="auto-style5" style="height:40px">
                
                <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
                <br />
                <br />
                <br />
                
                <asp:Button ID="Button1" runat="server" Text="Add More Question" OnClick="Button1_Click1" />
                
            </td>
        </tr>
    </table>
    
    
    
</asp:Content>
