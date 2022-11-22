<%@ Page Title="" Language="C#" MasterPageFile="~/Guest/Site1.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="ProjectNest.Admin.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table align="center">
        <tr>
            <td colspan="2"><b><center>Login</center></b></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="name" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="pwd" TextMode="Password" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2"><center>
                <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
            </center></td>
        </tr>
    </table>
</asp:Content>
