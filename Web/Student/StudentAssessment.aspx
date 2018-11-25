<%@ Page Language="C#" MasterPageFile="~/AssessmentMenu.Master" AutoEventWireup="true" CodeBehind="StudentAssessment.aspx.cs" Inherits="Web.Student.Student" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="body" runat="server">
    <div><h1>Student
         </h1></div>
    <div>
        View assessment
        &nbsp;
        View Result
        &nbsp;
        <asp:HyperLink ID="HyperLink1" runat="server">Change Password</asp:HyperLink>
        <asp:HyperLink ID="HyperLink2" runat="server">View Profile</asp:HyperLink>
    </div>
</asp:Content>
