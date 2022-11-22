<%@ Page Title="" Language="C#" MasterPageFile="~/User/User.Master" AutoEventWireup="true" CodeBehind="userviewreply.aspx.cs" Inherits="ProjectNest.User.userviewreply" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <center>
        <h3>View Reply</h3>
        <table>
            <tr>
                <th>
                    Product
                </th>
                <td></td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <th>
                    Question
                </th>
                <td></td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server" TextMode="MultiLine" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <th>
                    Reply
                </th>
                <td></td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server" ReadOnly="False" TextMode="MultiLine"></asp:TextBox>
                </td>
            </tr>
            
        </table>
    </center>
</asp:Content>
