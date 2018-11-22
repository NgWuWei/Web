<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Web.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Page</title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Panel ID="panelLogin" runat="server">
            <h1>Login</h1>
            User Id: <asp:TextBox ID="userId" runat="server"></asp:TextBox><br />
            Password: <asp:TextBox ID="Password" runat="server" TextMode="Password"></asp:TextBox>
            <asp:CheckBox ID="CheckBox1" runat="server" Text="Remember me" />
            <br />
            <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="BtnLogin_Click"/>
            &nbsp;
            <!--TODO change OnClick here to -->
            <asp:Button ID="btnHelp" runat="server" Text="Forgot Password?"/><br />
            <div>Dont have an account? Sign up
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Register.aspx">here</asp:HyperLink>
            </div>
        </asp:Panel>
        <asp:Panel ID="panelHelp" runat="server">
            <!--<asp:PasswordRecovery runat="server"></asp:PasswordRecovery><br />-->
        </asp:Panel>
    </form>
</body>
</html>