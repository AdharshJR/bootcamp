<%@ Page Title="" Language="C#" MasterPageFile="~/User/User.Master" AutoEventWireup="true" CodeBehind="QueryRegister.aspx.cs" Inherits="ProjectNest.User.QueryRegister" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <center>
        <h3>Add Queries</h3><br /><br />
        <table>
            <tr>
                <th>Select Product</th>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True"></asp:DropDownList>

                </td>
            </tr>
            <tr>
                <th>Ask a Question</th>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" TextMode="MultiLine"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <th colspan="2">
                    <asp:Button ID="Button1" runat="server" Text="Ok" OnClick="Button1_Click" />
                </th>
            </tr>
        </table>
         <table>
             <tr>
                 <td>
                     <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
                         <Columns>
                <asp:BoundField DataField="queryId" HeaderText="Query Id" />
                <asp:BoundField DataField="product_name" HeaderText="Product Name" />
                <asp:BoundField DataField="query" HeaderText="Query" />
               
                <asp:BoundField DataField="query_date" HeaderText="Date" />
                <asp:HyperLinkField DataNavigateUrlFields="queryId" HeaderText="Details" Text="view details" DataNavigateUrlFormatString="userviewreply.aspx?qid={0}" />
                         </Columns>
                     </asp:GridView>
                 </td>
             </tr>
         </table>
    </center>
</asp:Content>
