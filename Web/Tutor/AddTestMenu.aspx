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
        <asp:TextBox ID="txtTestName" runat="server" style="text-align:center" CssClass="auto-style2"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="AddTestbtn" runat="server" BackColor="#FF3300" ForeColor="White" Text="Start Adding Question"   OnClick="AddTestbtn_Click"    />
        <br />
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="TestName" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="TestName" HeaderText="TestName" ReadOnly="True" SortExpression="TestName" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString2 %>" SelectCommand="SELECT * FROM [Test]"></asp:SqlDataSource>
    </div>
    



</asp:Content>
