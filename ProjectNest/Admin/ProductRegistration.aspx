<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="ProductRegistration.aspx.cs" Inherits="ProjectNest.Admin.ProductRegistration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table align="center">
        <tr>
            <td colspan="2"><b><center>Product Registration</center></b></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Product Name"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="name" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Price"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="desc" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2"><center>
                <asp:Button ID="Button1" runat="server" Text="Add" OnClick="Button1_Click" />
            </center></td>
        </tr>
    </table>
    <table>
        <tr>
            <td>
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="pid" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating">
                <Columns>
                    <asp:BoundField DataField="pid" HeaderText="ID" />
                    <asp:BoundField DataField="pname" HeaderText="Product Name" />
                    <asp:BoundField DataField="pprice" HeaderText="Product Price" />
                    <asp:CommandField HeaderText="Edit" ShowEditButton="True" />
                    <asp:CommandField HeaderText="Delete" ShowDeleteButton="True" />
                </Columns>
            </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>
