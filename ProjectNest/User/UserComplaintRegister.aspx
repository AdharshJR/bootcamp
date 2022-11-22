<%@ Page Title="" Language="C#" MasterPageFile="~/User/User.Master" AutoEventWireup="true" CodeBehind="UserComplaintRegister.aspx.cs" Inherits="ProjectNest.User.UserRegister" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>
        <h3>Add Complaint</h3><br /><br />
        <table>
            <tr>
                <th>Select Product</th>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True"></asp:DropDownList>

                </td>
            </tr>
            <tr>
                <th>Complaint</th>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" TextMode="MultiLine"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <th colspan="2">
                    <asp:Button ID="Button1" runat="server" Text="Add" OnClick="Button1_Click" />
                </th>
            </tr>
        </table>
        <table align="center">
            <tr>
                <td>
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
                        <Columns>
                            <asp:BoundField DataField="query_Id" HeaderText="Query Id" />
                            <asp:BoundField DataField="pname" HeaderText="Product Name" />
                            <asp:BoundField DataField="query" HeaderText="Query" />
                            <asp:BoundField DataField="date" HeaderText="Date" />
                            <asp:HyperLinkField DataNavigateUrlFields="query_Id" DataNavigateUrlFormatString="userviewreply.aspx?query_Id={0}" HeaderText="Details" Text="View Details" />
                        </Columns>

                    </asp:GridView>
                </td>
            </tr>
        </table>
    </center>
</asp:Content>
