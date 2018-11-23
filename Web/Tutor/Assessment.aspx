<%@ Page Language="C#" MasterPageFile="~/AssessmentMenu.Master" AutoEventWireup="true" CodeBehind="Assessment.aspx.cs" Inherits="Web.Tutor.Assessment" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="body" runat="server">
    <div><h1>tutor page
        tutor add question 
         </h1>
        Create assessment
        &nbsp;
        View assessment
        &nbsp;
        Update assessment
        &nbsp;
        Delete assessment
        <br />
        Steps to create assessment
        <br />
        1. Create title (title, subject, time given, )
        2. Generate questions (add questions and answer with marks)
        3. ??? (Sum all marks in answer to get 100% total marks)
        3b. store answer and questions into database
        4. To students
    </div>
</asp:Content>
