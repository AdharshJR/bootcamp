<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="AdminQuery.aspx.cs" Inherits="ProjectNest.Admin.AdminQuery" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>
        <h3>Complaints</h3>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" >
            <Columns>
                <asp:BoundField DataField="query_Id" HeaderText="Id" />
                <asp:BoundField DataField="pname" HeaderText="Product Name" />
                <asp:BoundField DataField="username" HeaderText="username" />
                <asp:BoundField DataField="query" HeaderText="Query" />
                <asp:BoundField DataField="reply" HeaderText="Reply" />
                <asp:BoundField DataField="date" HeaderText="Date" />
                <asp:HyperLinkField DataNavigateUrlFields="query_Id" DataNavigateUrlFormatString="AdminQueryReply.aspx?query_Id={0}" HeaderText="Reply" Text="reply" />
            </Columns>
        </asp:GridView>
    </center>
</asp:Content>
