<%@ Page Title="" Language="C#" MasterPageFile="~/Guest/Site1.Master" AutoEventWireup="true" CodeBehind="UserRegister.aspx.cs" Inherits="ProjectNest.User.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table align="center">
        <tr>
            <td><b>User Registration</b></td>
        </tr>
         <tr>
            <td>
                <asp:Label Id="label1" runat="server" Text="Name"></asp:Label>
            </td>
             <td>
                 <asp:TextBox id="uname" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label Id="label2" runat="server" Text="Email"></asp:Label>
            </td>
             <td>
                 <asp:TextBox id="uemail" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label Id="label3" runat="server" Text="Phone"></asp:Label>
            </td>
             <td>
                 <asp:TextBox id="uphone" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label Id="label4" runat="server" Text="Password"></asp:Label>
            </td>
             <td>
                 <asp:TextBox id="pwd" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2"><center>
                <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click"  />
            </center></td>
        </tr>
    </table>
</asp:Content>
