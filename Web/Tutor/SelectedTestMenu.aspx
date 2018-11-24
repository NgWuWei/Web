<%@ Page Title="" Language="C#" MasterPageFile="~/AssessmentMenu.Master" AutoEventWireup="true" CodeBehind="SelectedTestMenu.aspx.cs" Inherits="Web.Tutor.TestMenu1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            margin-top: 46px;
        }
        .auto-style2 {
            margin-left: 36px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" runat="server">
    <asp:Panel ID="Panel1" runat="server">
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    </asp:Panel>
    <br />
    <asp:Panel ID="Panel2" runat="server" CssClass="auto-style1">
        <h3>Ready to give your Test?</h3>
        <br />
        <asp:Button ID="Assignbtn" runat="server" Text="Assign" CssClass="auto-style2" />
    </asp:Panel>
</asp:Content>
