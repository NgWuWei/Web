<%@ Page Title="" Language="C#" MasterPageFile="~/AssessmentMenu.Master" AutoEventWireup="true" CodeBehind="AddTestMenu.aspx.cs" Inherits="Web.Tutor.TestMenu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            margin-top: 175px;
            width: 494px;
            height: 98px;
            margin-left: 304px;
        }
        .auto-style2 {
            margin-left: 90px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" runat="server">


    <div style="border-style:groove;align-items:center;text-align:center" class="auto-style1">
        <asp:Label ID="lblNewTest" runat="server" Text="Test Name : " ></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" style="text-align:center" CssClass="auto-style2"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="txtAddTest" runat="server" BackColor="#FF3300" ForeColor="White" Text="Start Adding Question" PostBackUrl="~/Tutor/AddTestDetails.aspx"  />
    </div>
    



</asp:Content>
